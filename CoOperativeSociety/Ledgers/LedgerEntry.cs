using BusinessEntities;
using BusinessEntities._enum;
using SocietyBusinessAccess.Ledgers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoOperativeSociety.Ledgers
{
    public partial class LedgerEntry : Form
    {
        LedgerBA lLedgerBA = new LedgerBA();
        public LedgerEntry()
        {
            InitializeComponent();
            //
            cmbSubAccount.AddSubAccountName();
            AddCategory(ref cmbCategory);
           
            //CD/DR
            cmbcrdr.SelectedIndex = 0;
           
        }

        #region ================Method========================
        public  void AddCategory(ref ComboBox cmb)
        {
            cmb.Items.Add(LedgerEnum._LedgerCategoryValues.Interest.GetEnumName());
            cmb.Items.Add(LedgerEnum._LedgerCategoryValues.Others_Income.GetEnumName());
            cmb.Items.Add(LedgerEnum._LedgerCategoryValues.Others_Expence.GetEnumName());
        }
        private void Save()
        {
            //Object Type
            List<Ledger> frmLedger = new List<Ledger>();
            List<LedgersStatu> frmledgersStatu = new List<LedgersStatu>();

            //Get
            FillFromValues(out frmLedger, out frmledgersStatu);

            //Execute
            if (lLedgerBA.InsertLedgerWithBankAndStatus(frmLedger, new List<LedgerBankDetail>(), frmledgersStatu))
            {
                MessageBox.Show("Ledger Create Successfull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ledger Create Un-Successfull", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private bool IsvalidData()
        {
            if (txtLedgerName.Text.ISNullOrWhiteSpace())
            {
                MessageBox.Show("Ledger Is Required", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLedgerName.Select();
                return false;
            }
            if (cmbCategory.Text.ISNullOrWhiteSpace())
            {
                MessageBox.Show("Category Is Required", "Invalid Entryt", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbCategory.Focus();
                return false;
            }
            if (cmbSubAccount.Text.ISNullOrWhiteSpace())
            {
                MessageBox.Show("Sub Account is Required", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbSubAccount.Focus();
                return false;
            }
            return true;
        }
        private void FillFromValues(out List<Ledger> frmLedger, out List<LedgersStatu> frmledgersStatu)
        {
            //Object Type
            frmLedger = new List<Ledger>();
            frmledgersStatu = new List<LedgersStatu>();
            string _ledgerName = txtLedgerName.Text;
            Guid _LedgerId = Guid.NewGuid();

            //Fill
            #region ============Ledger=======================
            frmLedger.Add(new Ledger
            {
                LedgerId = _LedgerId,
                LedgerName = _ledgerName,
                TemplateName = _ledgerName,
                Category = cmbCategory.Text,
                SubAccount = cmbSubAccount.Text,
                ParentLedgerId = null,
                Type = cmbType.Text
            });
            #endregion

            #region =====Ledgers Status======================

            frmledgersStatu.Add(new LedgersStatu
            {
                LedgerID = _LedgerId,
                FinYearID = 1,//change
                OpeningBalance = cmbcrdr.Text== "Dr." ? txtOpeningAmount.Text.ConvertObjectToDouble(): -(txtOpeningAmount.Text.ConvertObjectToDouble()),
                Date = dtpDate.Value
            });

            #endregion
        }

        #endregion

        #region ---------------Event--------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsvalidData())
            {
                var existledger = lLedgerBA.GetLedgers(txtLedgerName.Text);
                if (existledger.ISValidObject()? existledger.LedgerId.ISValidObject()?false:true:true)
                {
                    Save();
                }
                else
                {
                    MessageBox.Show("Ledger is alredy Exist, Try another !!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void txtOpeningAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.FlotingNumberValidation(sender, e);
        }
        #endregion

        private void iControl_GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

