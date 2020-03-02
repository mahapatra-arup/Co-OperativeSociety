using BusinessEntities;
using BusinessEntities._enum;
using CoOperativeSociety.Tools;
using SocietyBusinessAccess.Ledgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CoOperativeSociety.Ledgers
{
    public partial class BankLedgeEntry : Form
    {
        LedgerBA frmLedgerBA = new LedgerBA();
        public BankLedgeEntry()
        {
            InitializeComponent();
            //Fill Bank
            cmbBankName.AddBanksName();
            //
            cmbAcType.AddSocityBankCategory();
            cmbcrdr.SelectedIndex = 0;
        }

        #region =============Method======================
        private bool IsvalidData()
        {
            if (cmbBankName.Text.ISNullOrWhiteSpace())
            {
                MessageBox.Show("Select bank name", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbBankName.Select();
                return false;
            }
            if (txtAcNo.Text.ISNullOrWhiteSpace())
            {
                MessageBox.Show("Enter Account number", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtAcNo.Focus();
                return false;
            }
            if (txtLedgerName.Text.ISNullOrWhiteSpace())
            {
                MessageBox.Show("Enter Account Name", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLedgerName.Focus();
                return false;
            }
            return true;
        }
        private void DataSave()
        {
            //Object Type
            List<Ledger> frmLedger = new List<Ledger>();
            List<LedgerBankDetail> frmLedgerBD = new List<LedgerBankDetail>();
            List<LedgersStatu> frmledgersStatu = new List<LedgersStatu>();

            //Get
            FillFromValues(out frmLedger, out frmLedgerBD, out frmledgersStatu);

            //Execute
            if (frmLedgerBA.InsertLedgerWithBankAndStatus(frmLedger, frmLedgerBD, frmledgersStatu))
            {
                MessageBox.Show("Bank Create Successfull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bank Create Un-Successfull", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void FillFromValues(out List<Ledger> frmLedger, out List<LedgerBankDetail> frmLedgerBD, out List<LedgersStatu> frmledgersStatu)
        {
            //Object Type
            frmLedger = new List<Ledger>();
            frmLedgerBD = new List<LedgerBankDetail>();
            frmledgersStatu = new List<LedgersStatu>();
            Guid? _ParentLedger = (Guid?)null;
            int _bankid = ((KeyValuePair<int, string>)cmbBankName.SelectedItem).Key;

            //fill
            #region ---=Main Bank Head Ledger only Generate First Time=---
            //Check This Main Head ledger Generate Or Not
            var lstledgerusebankname = frmLedgerBA.GetLedgers(cmbBankName.Text);
            if (!lstledgerusebankname.ISValidObject() && !frmLedgerBA.GetLedgerBankDetails(_bankid).ISValidIEnumerableList())
            {
                _ParentLedger = Guid.NewGuid();
                frmLedger.Add(new Ledger
                {
                    LedgerId = _ParentLedger.ConvertToGuid(),
                    LedgerName = cmbBankName.Text,
                    TemplateName = cmbBankName.Text,
                    Category = LedgerEnum._LedgerCategoryValues.Bank.GetEnumName(),
                    SubAccount = null,
                    ParentLedgerId = null,
                    Type = null
                });
            }
            else
            {
                //If Exist Then
                _ParentLedger = lstledgerusebankname.LedgerId;
            }

            #endregion

            if (_ParentLedger.ISValidObject())
            {
                #region =====Saving/Current/Loabn Ac  Ledger====

                frmLedger.Add(new Ledger
                {
                    LedgerId = Guid.NewGuid(),
                    LedgerName = txtLedgerName.Text,
                    TemplateName = txtLedgerName.Text,
                    Category = cmbAcType.Text,
                    SubAccount = frmLedgerBA.GetSocityBankSubACByCategory(cmbAcType.Text),
                    ParentLedgerId = _ParentLedger,
                    Type = null
                });

                #endregion

                #region =====Ledger Bank Detail=================

                frmLedgerBD.Add(new LedgerBankDetail
                {
                    LedgerID = _ParentLedger.ConvertToGuid(),
                    BankID = _bankid,
                    ACNo = txtAcNo.Text,
                    IFSC = txtIFSC.Text,
                    MICR = txtMICR.Text,
                    BranchName = txtBranchName.Text,
                    BranchCode = txtBranchCode.Text,
                    Address = txtAddress.Text,
                    ACType = cmbAcType.Text
                });

                #endregion

                #region =====Ledgers Status======================

                frmledgersStatu.Add(new LedgersStatu
                {
                    LedgerID = _ParentLedger.ConvertToGuid(),
                    FinYearID = 1,//change
                    OpeningBalance = cmbcrdr.Text == "Dr." ? txtOpeningAmount.Text.ConvertObjectToDouble() : -(txtOpeningAmount.Text.ConvertObjectToDouble()),
                    Date = dtpDate.Value,
                });

                #endregion 
            }
            else
            {
                MessageBox.Show(cmbBankName.Text + " - Parent Ledger create Problem", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region ===============Event=====================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsvalidData())
            {
                //BankId
                int _bankid = ((KeyValuePair<int, string>)cmbBankName.SelectedItem).Key;
              var _LedgerCatVal=(LedgerEnum._LedgerCategoryValues)Enum.Parse(typeof(LedgerEnum._LedgerCategoryValues), cmbAcType.Text);
                if (!frmLedgerBA.AlredyExistBankByCategry(_bankid, _LedgerCatVal))
                {
                    DataSave(); 
                }
                else
                {
                    MessageBox.Show(cmbAcType.Text+" is already present in  bank of " +cmbBankName.Text, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbBankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbBankName.Text.ISNullOrWhiteSpace())
            {
                txtLedgerName.Text = cmbBankName.Text + "(" + cmbAcType.Text + ")";
            }
        }
        private void txtOpeningAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.FlotingNumberValidation(sender, e);
        }
        #endregion
    }
}
