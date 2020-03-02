using BusinessEntities;
using CoOperativeSociety.Tools;
using SocietyBusinessAccess.Customer;
using SocietyBusinessAccess.Ledgers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CoOperativeSociety.Customer
{
    public partial class AddCustomer : Form
    {
        #region ===========Propoerties For Edit===========
        public Guid _lCustomerId { get; set; }
        public bool _lIsForEdit { get; set; }
        private Guid _lCustomerLedgerIdForEdit { get; set; }
        private delegate void dDataUpdate();
        #endregion

        public  event Action onClose;
        CustomerDetailsBA customerDetailsBA = new CustomerDetailsBA();
        LedgerBA ledgerBA = new LedgerBA();
        private bool IsvalidPhnoAndEmail = false;

        public AddCustomer()
        {
            InitializeComponent();
            //AddDist
            cmbPmDist.AddDist();
            cmbPrDist.AddDist();
            //Bank
            cmbBankName.AddBanksName();
            
        }

        #region ----------User Define Method--------------

        #region ==================Insert Request===================
        private CustomerDetail GetFormValuesDataForInsert(out CustomerBankDetail frmCB, out CustomerAddressDetail frmCA, out List<Ledger> frmlstLedger)
        {
            frmlstLedger = new List<Ledger>();
            CustomerDetail frmCD = new CustomerDetail();
            Ledger frmLoan_Ledger = null;
            Ledger frmSavind_Ledger = null;
            Ledger frmLedger = null;

            //Guid Id
            Guid gidForCustomerId = Guid.NewGuid();
            Guid gidForParentLedgerId = gidForCustomerId;
            Guid gidForSaving_LedgerId = Guid.NewGuid();
            Guid gidForLoan_LedgerId = Guid.NewGuid();

            //Bank Id
            int bankid = ((KeyValuePair<int, string>)cmbBankName.SelectedItem).Key;

            //Ledger
            #region ==============Ledger=========
            frmLedger = new Ledger
            {
                #region ====Ledger====
                LedgerId = gidForParentLedgerId,
                LedgerName = txtLedgerName.Text,//unique
                TemplateName = txtCustomerName.Text,//not unique
                Category = cmbCategory.Text,
                SubAccount = lblSubAccount.Text,
                ParentLedgerId = (Guid?)null,
                Type = null
                #endregion
            };//out

            frmlstLedger.Add(frmLedger);

            #region ====saving Ledger====
            //========Saving Account Ledger==========
            string _SavingLedgerString = "_Saving_AC";
            frmSavind_Ledger = new Ledger
            {

                LedgerId = gidForSaving_LedgerId,
                LedgerName = txtLedgerName.Text + _SavingLedgerString,//unique
                TemplateName = txtCustomerName.Text + _SavingLedgerString,
                Category = cmbCategory.Text + _SavingLedgerString,
                SubAccount = lblSavingSubAc.Text,
                ParentLedgerId = gidForParentLedgerId,
                Type = null

            };//out
            frmlstLedger.Add(frmSavind_Ledger);
            #endregion

            #region ====Loan Ledger====
            if (chkLoanLedger.Checked)
            {
                string _LoanLedgerString = "_Loan_AC";
                frmLoan_Ledger = new Ledger
                {

                    LedgerId = gidForLoan_LedgerId,
                    LedgerName = txtLedgerName.Text + _LoanLedgerString,
                    TemplateName = txtCustomerName.Text + _LoanLedgerString,
                    Category = cmbCategory.Text + _LoanLedgerString,
                    SubAccount = lblLoanAcSubAc.Text,
                    ParentLedgerId = gidForParentLedgerId,
                    Type = null

                };//out 

                frmlstLedger.Add(frmLoan_Ledger);
            }
            #endregion 
            #endregion

            //Customer Details
            #region =====Customer Details========
            frmCD.Customername = txtCustomerName.Text;
            frmCD.PanNo = txtPanNO.Text;
            frmCD.AadhaarNo = GenerateAadhaarNo();
            frmCD.DOB = dtpDOB.Value;
            //
            frmCD.LedgerId = gidForParentLedgerId;
            frmCD.CustomerId = gidForCustomerId;
            #endregion

            //Bank Details
            frmCB = new CustomerBankDetail
            {
                #region ===Bank Details====
                CustomerId = gidForCustomerId,
                BankID = bankid,
                BranchName = txtBranchName.Text,
                BankIFC = txtBankIFSCcode.Text,
                MICRCode = txtBankMICRcode.Text,
                AccountNo = txtBankAccountNo.Text,
                BranchCode = txtBranchCode.Text
                #endregion
            };//out


            //Customer Address Details
            frmCA = new CustomerAddressDetail
            {
                #region ===Address Details===
                CustomerId = gidForCustomerId,
                //pr
                PrVill = txtPrVill.Text,
                PrPS = txtPrPs.Text,
                PrPIN = txtPrPIN.Text,
                prDist = txtPrVill.Text,
                //pm
                pmVill = txtPmVill.Text,
                pmPS = txtPmPS.Text,
                pmPIN = txtPmPIN.Text,
                pmDist = cmbPmDist.Text,

                //Contect 
                mNo = txtPhone.Text,
                lNo = "",
                emailID = txtEmail.Text
                #endregion
            };//out



            //Return Customer Details
            return frmCD;
        }

        private void DataSave()
        {
            if (IsValidField())
            {
                if (!customerDetailsBA.IsAlreadyExist(txtCustomerName.Text, txtPhone.Text, string.Empty))
                {
                    CustomerDetail frmCD = new CustomerDetail();
                    CustomerBankDetail frmCB = new CustomerBankDetail();
                    CustomerAddressDetail frmCA = new CustomerAddressDetail();
                    List<Ledger> frmlstLedger = new List<Ledger>();

                    //get
                    frmCD = GetFormValuesDataForInsert(out frmCB, out frmCA, out frmlstLedger);

                    //Insert Data
                    if (customerDetailsBA.InsertCustomerDetails(frmCD, frmCA, frmCB, frmlstLedger))
                    {
                        MessageBox.Show("Customer Details Save Successfull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Customer Name / Ph No are alredy hold another customer", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCustomerName.Select();
                }
            }
        } 
        #endregion

        #region ====================Update=========================

        private void DataUpdate()
        {
            //Decleration Of Delegate;
            dDataUpdate MdDataUpdate = delegate
            {
                CustomerDetail frmCD = new CustomerDetail();
                CustomerBankDetail frmCB = new CustomerBankDetail();
                CustomerAddressDetail frmCA = new CustomerAddressDetail();
                List<Ledger> frmlstLedger = new List<Ledger>();

                //get
                frmCD = GetFormValuesDataForUpdate(_lCustomerId,out frmCB, out frmCA, out frmlstLedger);

                //Update Data
                if (customerDetailsBA.UpdateCustomerDetails(frmCD, frmCA, frmCB, frmlstLedger))
                {
                    MessageBox.Show("Customer Details Update Successfull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            };


            if (IsValidField())
            {
                string sQuery= " CustomerId not in('"+_lCustomerId+"') ";
                if (!customerDetailsBA.IsAlreadyExist(txtCustomerName.Text, txtPhone.Text, sQuery))
                {
                    //Call  Delegate;
                    MdDataUpdate();
                }
                else
                {
                    MessageBox.Show("Customer Name / Ph No are alredy hold another customer", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCustomerName.Select();
                }
            }
        }
        private void FillDetails(Guid _custmerId)
        {
            CustomerList lst = customerDetailsBA.GetCustomerList(_custmerId);
            if (lst.ISValidObject())
            {
                //Details
                txtCustomerName.Text = lst.Customername;
                dtpDOB.Value = lst.DOB.ConvertObjectToDateTime();


                //Address
                //pm
                txtPmVill.Text = lst.pmVill;
                txtPmPS.Text = lst.pmPS;
                cmbPmDist.Text = lst.pmDist;
                txtPmPIN.Text = lst.pmPIN;
                //pr
                txtPrVill.Text = lst.PrVill;
                txtPrPs.Text = lst.PrPS;
                cmbPrDist.Text = lst.pmDist;
                txtPrPIN.Text = lst.pmPIN;

                //Bank
                cmbBankName.Text= lst.BankName;
                txtBranchCode.Text = lst.BranchCode;
                txtBankMICRcode.Text = lst.MICRCode;
                txtBankIFSCcode.Text = lst.BankIFC;
                txtBankAccountNo.Text = lst.AccountNo;

                //Identity
                FillAadhaarNo(lst.AadhaarNo);
                txtPanNO.Text = lst.PanNo;

                //Contact
                txtEmail.Text = lst.emailID;
                txtPhone.Text = lst.mNo;

                //Account
                txtLedgerName.Text = lst.LedgerName;
                _lCustomerLedgerIdForEdit = lst.LedgerId.ConvertToGuid();
            }
        }

        private CustomerDetail GetFormValuesDataForUpdate(Guid llCustomerId,out CustomerBankDetail frmCB, out CustomerAddressDetail frmCA, out List<Ledger> frmlstLedger)
        {
            frmlstLedger = new List<Ledger>();
            CustomerDetail frmCD = new CustomerDetail();
            Ledger frmLoan_Ledger = null;
            Ledger frmSavind_Ledger = null;
            Ledger frmLedger = null;

            //Guid Id
            string gidForCustomerLedgerId = _lCustomerLedgerIdForEdit.ToString();
            string gidForSaving_LedgerId ;
            string gidForLoan_LedgerId;
            ledgerBA.GetLedgerofCustomer(gidForCustomerLedgerId, out gidForLoan_LedgerId,out gidForSaving_LedgerId);

            //Bank Id
            int bankid = ((KeyValuePair<int, string>)cmbBankName.SelectedItem).Key;

            //Ledger
            #region ==============Ledger=========
            frmLedger = new Ledger
            {
                #region ====Ledger====
                LedgerId = gidForCustomerLedgerId.ConvertToGuid(),
                LedgerName = txtLedgerName.Text,//unique
                TemplateName = txtCustomerName.Text,//not unique
                #endregion
            };//out

            frmlstLedger.Add(frmLedger);

            #region ====saving Ledger====
            //========Saving Account Ledger==========
            string _SavingLedgerString = "_Saving_AC";
            frmSavind_Ledger = new Ledger
            {
                LedgerId = gidForSaving_LedgerId.ConvertToGuid(),
                LedgerName = txtLedgerName.Text + _SavingLedgerString,//unique
                TemplateName = txtCustomerName.Text + _SavingLedgerString,
               
            };//out
            frmlstLedger.Add(frmSavind_Ledger);
            #endregion

            #region ====Loan Ledger====
            if (chkLoanLedger.Checked)
            {
                string _LoanLedgerString = "_Loan_AC";
                frmLoan_Ledger = new Ledger
                {
                    LedgerId = gidForLoan_LedgerId.ConvertToGuid(),
                    LedgerName = txtLedgerName.Text + _LoanLedgerString,
                    TemplateName = txtCustomerName.Text + _LoanLedgerString,
                   
                };//out 

                frmlstLedger.Add(frmLoan_Ledger);
            }
            #endregion 
            #endregion

            //Customer Details
            #region =====Customer Details========
            frmCD.Customername = txtCustomerName.Text;
            frmCD.PanNo = txtPanNO.Text;
            frmCD.AadhaarNo = GenerateAadhaarNo();
            frmCD.DOB = dtpDOB.Value;
            //
            frmCD.LedgerId = _lCustomerLedgerIdForEdit;
            frmCD.CustomerId = llCustomerId;
            #endregion

            //Bank Details
            frmCB = new CustomerBankDetail
            {
                #region ===Bank Details====
                CustomerId = llCustomerId,
                BankID = bankid,
                BranchName = txtBranchName.Text,
                BankIFC = txtBankIFSCcode.Text,
                MICRCode = txtBankMICRcode.Text,
                AccountNo = txtBankAccountNo.Text,
                BranchCode = txtBranchCode.Text
                #endregion
            };//out


            //Customer Address Details
            frmCA = new CustomerAddressDetail
            {
                #region ===Address Details===
                CustomerId = llCustomerId,
                //pr
                PrVill = txtPrVill.Text,
                PrPS = txtPrPs.Text,
                PrPIN = txtPrPIN.Text,
                prDist = txtPrVill.Text,
                //pm
                pmVill = txtPmVill.Text,
                pmPS = txtPmPS.Text,
                pmPIN = txtPmPIN.Text,
                pmDist = cmbPmDist.Text,

                //Contect 
                mNo = txtPhone.Text,
                lNo = "",
                emailID = txtEmail.Text
                #endregion
            };//out



            //Return Customer Details
            return frmCD;
        }

        #endregion

        #region =================Gets & Check & Fill===============
        private string GenerateAadhaarNo()
        {
            return txtAadherNo1.Text + "-" + txtAadherNo1.Text + "-" + txtAadherNo1.Text;
        }

        private void FillAadhaarNo(string _aadhaarNo)
        {
            try
            {
                string[] aadNo = _aadhaarNo.Split('-');
                txtAadherNo1.Text = aadNo[0];
                txtAadherNo1.Text = aadNo[1];
                txtAadherNo1.Text = aadNo[2];
            }
            catch (Exception ex)
            {
                ex.ToWriteLog(Environment.StackTrace, "N/A");
            }
        }

        private void AadhaarNoManage(ref TextBox txt)
        {
            if (txt.Name== txtAadherNo1.Name && txtAadherNo1.TextLength==4)
            {
                txtAadherNo2.Focus();
            }
            else if (txt.Name == txtAadherNo2.Name && txtAadherNo2.TextLength == 4)
            {
                txtAadherNo3.Focus();
            }
        }

        private void Clear()
        {
            txtLedgerName.Text = "";
            txtCustomerName.Text = "";
            txtPmVill.Text = ""; txtPrVill.Text = "";
            txtPmPS.Text = ""; txtPrPs.Text = "";
            cmbPmDist.Text = ""; cmbPrDist.Text = "";
            txtPmPIN.Text = ""; txtPrPIN.Text = "";
            cmbBankName.SelectedIndex = -1;
            txtBranchCode.Text = "";
            txtAadherNo1.Text = ""; txtAadherNo2.Text = ""; txtAadherNo3.Text = "";
            txtEmail.Text = ""; txtPhone.Text = ""; txtBankMICRcode.Text = "";
            txtBankIFSCcode.Text = ""; txtBankAccountNo.Text = "";
            txtPanNO.Text = "";
        }

        /// <summary>
        /// Form Control Validation Check,
        /// </summary>
        /// <returns></returns>
        private bool IsValidField()
        {
            if (!txtCustomerName.Text.ISNullOrWhiteSpace())
            {
                if (!dtpDOB.Text.ISNullOrWhiteSpace())
                {
                    if (!txtPhone.Text.ISNullOrWhiteSpace())
                    {
                        if (!cmbBankName.Text.ISNullOrWhiteSpace())
                        {
                            if (IsvalidPhnoAndEmail)
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Ph No / Email is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bank Name is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPhone.Select();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone No is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhone.Select();
                    }
                }
                else
                {
                    MessageBox.Show("DOB  is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDOB.Select();
                }
            }
            else
            {
                MessageBox.Show("Customer Name is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Select();
            }

            return false;
        }

        /// <summary>
        /// Add Customer name and phone no and  show in ledger textbox
        /// </summary>
        private void CreateLedgerName()
        {
            txtLedgerName.Text = txtCustomerName.Text + "_" + txtPhone.Text;
        }

        private void FillSameAddress()
        {
            if (chkSameAddress.Checked)
            {
                txtPmVill.Text = txtPrVill.Text;
                txtPmPS.Text = txtPrPs.Text;
                cmbPmDist.Text = cmbPrDist.Text;
                txtPmPIN.Text = txtPrPIN.Text;
            }
        }

       
        #endregion

        #endregion

        #region -----------------Event--------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_lIsForEdit == true&&_lCustomerId.ISValidObject())
            {
                DataUpdate();
            }
            else
            {
                DataSave();
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            #region ============Validation============
            if (!ValidationUtils.PhoneValidation(txtPhone.Text))
            {
                txtPhone.ForeColor = System.Drawing.Color.Red;
                IsvalidPhnoAndEmail = false;
            }
            else
            {
                txtPhone.ForeColor = System.Drawing.Color.Black;
                IsvalidPhnoAndEmail = true;
            }
            txtPhone.Refresh();
            #endregion

            CreateLedgerName();
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            #region .................Validation...............
            if (!ValidationUtils.EmailValidation(txtEmail.Text))
            {
                txtEmail.ForeColor = System.Drawing.Color.Red;
                IsvalidPhnoAndEmail = false;

            }
            else
            {
                txtEmail.ForeColor = System.Drawing.Color.Black;
                IsvalidPhnoAndEmail = true;
            }
            txtEmail.Refresh();
            #endregion
        }
        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            CreateLedgerName();
        }
        private void chkSameAddress_CheckedChanged(object sender, EventArgs e)
        {
            FillSameAddress();
        }
        private void AddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (onClose != null)
            {
                onClose();
            }
        }
        private void AddCustomer_Shown(object sender, EventArgs e)
        {
            //If Catch Update Request
            lblMessege.Text = "Request For New Entry ::";
            if (_lIsForEdit == true && _lCustomerId.ISValidObject())
            {
                FillDetails(_lCustomerId);
                lblMessege.Text = "Request For Modify ::";
            }
        }


        #region ----------Aadhaar No Manage---------
        private void txtAadherNo1_TextChanged(object sender, EventArgs e)
        {
            AadhaarNoManage(ref txtAadherNo1);
        }


        private void txtAadherNo2_TextChanged(object sender, EventArgs e)
        {
            AadhaarNoManage(ref txtAadherNo2);
        }

        #endregion

       

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.NumberValidation(sender, e);
        }
        #endregion
    }
}
