using BusinessEntities;
using BusinessEntities._enum;
using CoOperativeSociety.Tools;
using SocietyBusinessAccess.Customer;
using SocietyBusinessAccess.Loans;
using SocietyBusinessAccess.Transections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CoOperativeSociety.Customer.Loans.LoanRePayment
{
    
    public partial class CustomerLoanRePayment : Form
    {
        //OnClose Event 
        public event Action onClose;
        #region =========Var With Properties===========
        Guid lCustomerId;
        string lLoanSlNo = string.Empty;
        bool _IsPaid = false;
        long _mEmiId = 0;
        public Guid _CustomerId { get => lCustomerId; set => lCustomerId = value; }
        public string _LoanSlNo { get => lLoanSlNo; set => lLoanSlNo = value; }
        public long _MEmiId { get => _mEmiId; set => _mEmiId = value; }
        #endregion
        TransectionBA transectionBA = new TransectionBA();
        CustomerDetailsBA customerDetailsBA = new CustomerDetailsBA();
        CustomerLoanBA customerLoanBA = new CustomerLoanBA();

        public CustomerLoanRePayment()
        {
            InitializeComponent();

            //=Add Customer=
            cmbCustomerName.AddCustomerName();
            //==Add SlNo==
            cmbLoanSlNo.AddLoanSerialNo();

            #region ==========SocietyBank==============
            List<LedgerEnum._LedgerCategoryValues> lstSocityBankAttribute = new List<LedgerEnum._LedgerCategoryValues>();
            lstSocityBankAttribute.Add(LedgerEnum._LedgerCategoryValues.Society_Saving_AC);
            lstSocityBankAttribute.Add(LedgerEnum._LedgerCategoryValues.Society_Current_AC);
            cmbSocietySavingBank.AddLedger(LedgerEnum._LedgerAttributes.Category, lstSocityBankAttribute);
            #endregion

            //=Voucher No=
            lblVoucherNo.Text = (customerLoanBA.GetMaxVoucherNo() + 1).ConvertObjectToString();

            //Set Reference No
            txtRefNo.Text = transectionBA.GenerateTransectionsRefNo();
        }

        #region ==================Method================
        private void FillCustomerDetails(Guid customerId)
        {
            CustomerList customerDetails = customerDetailsBA.GetCustomerList((object)customerId);
            if (DataTableExtension.ISValidObject((object)customerDetails))
            {
                lblDob.Text = Convert.ToDateTime(customerDetails.DOB).ToString("dd-MMM-yyyy");
                lblPhNo.Text = Convert.ToString(customerDetails.mNo);
                string text = "Permanent :--- Dist : " + customerDetails.pmDist + ", Pin : " + customerDetails.pmPIN + ", PS : " + customerDetails.pmPS +
                    ", Vill : " + customerDetails.pmVill + Environment.NewLine + "Present :--- Dist : " + customerDetails.prDist + ", Pin : " + customerDetails.PrPIN +
                    ", PS : " + customerDetails.PrPS + ", Vill : " + customerDetails.PrVill;
                txtAddress.Text = text;
            }
        }

        private void FillLoanDetails()
        {
            _IsPaid = false;
            _MEmiId = 0;
            CustomerLoanEMI lst = (customerLoanBA.GetCustomerLoanEMI(_CustomerId, _LoanSlNo, _IsPaid)).OrderBy(EmiNo => EmiNo.NoOfEMI).FirstOrDefault();//With OrderBy
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

        private CustomerLoanEMI getFormValue(string customerId, out List<Transection> frmListTransection)
        {
            //Socity Saving .current account Ledger
            Guid _SocietySavingBankLedgerId = ((KeyValuePair<Guid, string>)cmbSocietySavingBank.SelectedItem).Key;

            //Class Object
            TransectionBA transectionBA = new TransectionBA();
            CustomerLoanEMI frmCLE = new CustomerLoanEMI();
            frmListTransection = new List<Transection>();

            #region ====CustomerLoanEMI====
            frmCLE.VoucherNo = lblVoucherNo.Text.ConvertObjectToInt();
            frmCLE.IsPaid = true;
            frmCLE.ID = txtEMIIIdOfLoan.Text.ConvertObjectToInt();
            frmCLE.Remarks = txtPurpose.Text;
            frmCLE.PaidDate = dtpPaidDay.Value;
            frmCLE.ID = _MEmiId;
            //Amount
            frmCLE.InterestAmount = txtROIAm.Text.ConvertObjectToDouble();
            frmCLE.PrincipalAmount = txtPrincipalAm.Text.ConvertObjectToDouble();
            frmCLE.Transection_Ref_No = txtRefNo.Text;
            #endregion

            #region ====Transection===
            frmListTransection = customerLoanBA.LoanRepaymentTransection(customerId, frmCLE, _SocietySavingBankLedgerId);
            #endregion

            return frmCLE;
        }

        private bool IsValid()
        {
            if (!cmbCustomerName.Text.ISNullOrWhiteSpace())
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
                cmbCustomerName.Focus();
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
                CustomerLoanEMI frmCLE = getFormValue(_CustomerId.ConvertObjectToString(), out frmListTransection);

                if (frmCLE.ID > 0)
                {
                    if (!transectionBA.IsExistTransection_Ref_No(txtRefNo.Text))
                    {
                        if (customerLoanBA.UpdateCustomerLoanEmiWithTransection(frmCLE, frmListTransection))
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

        #region ====================Event===============

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerName.SelectedIndex >= 0)
            {
                _CustomerId = ((KeyValuePair<string, string>)cmbCustomerName.SelectedItem).Key.ConvertToGuid();
            }
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void cmbLoanSlNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoanSlNo.SelectedIndex >= 0)
            {
                _LoanSlNo = cmbLoanSlNo.Text;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //===Clear===
            txtNoOfEmi.Text = "0";
            txtPrincipalAm.Text = "0";
            txtROIAm.Text = "0";
            dtpLastDayOfPaid.Value = DateTime.Today;

            //====Get abd Fill===
            FillCustomerDetails(_CustomerId);
            //Fill Loan Details
            FillLoanDetails();

            //---Purpose---
            txtPurpose.Text = @"Paid " + txtNoOfEmi.Text + " Loan From " + cmbCustomerName.Text + " where Loan SlNo:" + cmbLoanSlNo.Text + "";
        }
        #endregion

        private void CustomerLoanRePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onClose!=null)
            {
                onClose();
            }
        }
    }
}
