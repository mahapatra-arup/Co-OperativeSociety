using BusinessEntities;
using BusinessEntities._enum;
using CoOperativeSociety.Tools;
using SocietyBusinessAccess.Loans;
using SocietyBusinessAccess.Transections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CoOperativeSociety.Society.Loans
{
    public partial class SocityLoanRePayment : Form
    {
        #region =========Var With Properties===========
        public event Action onClose;
        Guid lLoanBankId;
        string lLoanSlNo = string.Empty;
        bool _IsPaid = false;
        long _mEmiId = 0;

        public Guid _lLoanBankId { get => lLoanBankId; set => lLoanBankId = value; }
        public string _LoanSlNo { get => lLoanSlNo; set => lLoanSlNo = value; }
        public long _MEmiId { get => _mEmiId; set => _mEmiId = value; }

        #endregion

        //====Object Type===
        TransectionBA transectionBA = new TransectionBA();
        SocietyLoansBA societyLoansBA = new SocietyLoansBA();

        public SocityLoanRePayment()
        {
            InitializeComponent();

            //=Add Loan Bank=
            cmbloanBank.AddLedger(LedgerEnum._LedgerAttributes.Category, LedgerEnum._LedgerCategoryValues.Society_Loan_AC);


            #region ==========Society Saving Bank==============
            List<LedgerEnum._LedgerCategoryValues> lstSocityBankAttribute = new List<LedgerEnum._LedgerCategoryValues>();
            lstSocityBankAttribute.Add(LedgerEnum._LedgerCategoryValues.Society_Saving_AC);
            lstSocityBankAttribute.Add(LedgerEnum._LedgerCategoryValues.Society_Current_AC);
            cmbSocietySavingBank.AddLedger(LedgerEnum._LedgerAttributes.Category, lstSocityBankAttribute);
            #endregion

            //Set Reference No
            txtRefNo.Text = transectionBA.GenerateTransectionsRefNo();

        }

        #region ==================Method=======================

        private void FillLoanDetails()
        {
            _IsPaid = false;
            _MEmiId = 0;

            //Get
            SocietyLoanEMI lst = (societyLoansBA.GetSocityLoanEMI(_LoanSlNo, _IsPaid)).OrderBy(m => m.ID).ThenBy(m => m.NoOfEMI).ThenBy(m => m.EMIDate).FirstOrDefault();//With OrderBy

            //Check & Fill
            if (lst.ISValidObject())
            {
                txtPrincipalAm.Text = lst.PrincipalAmount.ConvertObjectToString();
                txtROIAm.Text = lst.InterestAmount.ConvertObjectToString();
                dtpLastDayOfPaid.Value = lst.EMIDate;
                txtNoOfEmi.Text = lst.NoOfEMI.ConvertObjectToString();

                //EmiId for Update 
                _MEmiId = lst.ID;
                txtEMIIIdOfLoan.Text = _MEmiId.ConvertObjectToString();
            }
        }

        private SocietyLoanEMI getFormValue(Guid _LoanledgerIs, out List<Transection> frmListTransection)
        {
            //Socity Saving .current account Ledger
            Guid _SocietySavingBankLedgerId = ((KeyValuePair<Guid, string>)cmbSocietySavingBank.SelectedItem).Key;
            //Socity Saving .current account Ledger
            Guid _ReceiveLoanBankLedgerId = ((KeyValuePair<Guid, string>)cmbloanBank.SelectedItem).Key;

            //Class Object
            TransectionBA transectionBA = new TransectionBA();
            SocietyLoanEMI frmSLE = new SocietyLoanEMI();
            frmListTransection = new List<Transection>();

            #region ====Socity Loan EMI====
            frmSLE.VoucherNo = txtVoucherNo.Text;
            frmSLE.IsPaid = true;
            frmSLE.ID = txtEMIIIdOfLoan.Text.ConvertObjectToInt();
            frmSLE.Remarks = txtPurpose.Text;
            frmSLE.PaidDate = dtpPaidDay.Value;
            frmSLE.ID = _MEmiId;
            //Amount
            frmSLE.InterestAmount = txtROIAm.Text.ConvertObjectToDouble();
            frmSLE.PrincipalAmount = txtPrincipalAm.Text.ConvertObjectToDouble();
            frmSLE.Transection_Ref_No = txtRefNo.Text;
            #endregion

            #region ====Transection===
            frmListTransection = societyLoansBA.LoanRepaymentTransection(frmSLE, _SocietySavingBankLedgerId, _ReceiveLoanBankLedgerId);
            #endregion

            return frmSLE;
        }

        private bool IsValid()
        {
            if (!cmbloanBank.Text.ISNullOrWhiteSpace())
            {
                if (!cmbLoanSlNo.Text.ISNullOrWhiteSpace())
                {
                    if (!cmbSocietySavingBank.Text.ISNullOrWhiteSpace())
                    {
                        if (!txtRefNo.Text.ISNullOrWhiteSpace())
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Reference No Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtRefNo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Socity Bank Is Required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbSocietySavingBank.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Loan Sl.No. Is Required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbLoanSlNo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Customer Name Is Required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbloanBank.Focus();
            }
            return false;
        }

        private void Save()
        {
            if (IsValid())
            {

                //Class Object
                var frmListTransection = new List<Transection>();

                //---get Details--
                SocietyLoanEMI frmCLE = getFormValue(_lLoanBankId, out frmListTransection);

                if (frmCLE.ID > 0)
                {
                    if (!transectionBA.IsExistTransection_Ref_No(txtRefNo.Text))
                    {
                        if (societyLoansBA.UpdateSocityLoanEmiWithTransection(frmCLE, frmListTransection))
                        {
                            MessageBox.Show("Paid SuccessFull", "Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Transection Ref No Already Exist", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Something Wrong. EMI Id Not Valid", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        #endregion

        #region =====================Event=====================
        private void cmbloanBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbloanBank.SelectedIndex >= 0)
            {
                _lLoanBankId = ((KeyValuePair<Guid, string>)cmbloanBank.SelectedItem).Key;
            }
            //==Add Loan SlNo==
            cmbLoanSlNo.AddLoanSerialNo(_lLoanBankId);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //===Clear===
            txtNoOfEmi.Text = "0";
            txtPrincipalAm.Text = "0";
            txtROIAm.Text = "0";
            dtpLastDayOfPaid.Value = DateTime.Today;

            //====Get abd Fill===
            //Fill Loan Details
            FillLoanDetails();

            //---Purpose---
            txtPurpose.Text = @"Paid " + txtNoOfEmi.Text + " Loan From " + cmbloanBank.Text + " where Loan SlNo:" + cmbLoanSlNo.Text + "";

        }

        private void cmbLoanSlNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoanSlNo.SelectedIndex >= 0)
            {
                _LoanSlNo = cmbLoanSlNo.Text;
            }
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            Save();
        }
       

        private void SocityLoanRePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onClose!=null)
            {
                onClose();
            }
        }
        #endregion
    }
}
