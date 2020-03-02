using BusinessEntities;
using BusinessEntities._enum;
using CoOperativeSociety.Others;
using CoOperativeSociety.Tools;
using SocietyBusinessAccess;
using SocietyBusinessAccess.Customer;
using SocietyBusinessAccess.Ledgers;
using SocietyBusinessAccess.Loans;
using SocietyBusinessAccess.Transections;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CoOperativeSociety.Loans
{
    public partial class CustomerLoanEntry : Form
    {
        #region ====Object Type===========
        //Object Type
        TransectionBA transectionBA = new TransectionBA();
        private static LoanTypeBA loanTypeBA = new LoanTypeBA();
        CustomerDetailsBA customerDetailsBA = new CustomerDetailsBA();
        CustomerLoanBA customerLoanBA = new CustomerLoanBA();
        LoanCalculationBA loanCalculationBA = new LoanCalculationBA();
        LedgerBA ledgerBA = new LedgerBA();
        #endregion

        string _CustomerId = string.Empty;
        Guid _SocitySavingLoanAmLedgerId;

        public CustomerLoanEntry()
        {
            InitializeComponent();

            //=====Add Loan Serial No=======
            cmbLoanSlNo.AddLoanSerialNo();

            //==GetCustomer==
            cmbCustomerName.AddCustomerName();
            //==Get Loan Type==
            cmbLoanType.AddLoanType();
            //======Add Bank Ledger===
            #region ==========SocietyBank==============
            List<LedgerEnum._LedgerCategoryValues> lstSocityBankAttribute = new List<LedgerEnum._LedgerCategoryValues>();
            lstSocityBankAttribute.Add(LedgerEnum._LedgerCategoryValues.Society_Saving_AC);
            lstSocityBankAttribute.Add(LedgerEnum._LedgerCategoryValues.Society_Current_AC);
            cmbSocietyMainBank.AddLedger(LedgerEnum._LedgerAttributes.Category, lstSocityBankAttribute);
            #endregion

            cmbShareDipositTo.AddLedger(LedgerEnum._LedgerAttributes.Category, LedgerEnum._LedgerCategoryValues.ShareDeposit);

            //Set Reference No
            txtRefNo.Text = transectionBA.GenerateTransectionsRefNo();
        }


        #region ==========================Method========================
        private void FillpnlForLoanType(int id)
        {
            LoanSubType lst = loanTypeBA.GetLoanSubTypeDetailsById(id);
            if (lst.ISValidObject())
            {
                txtEmiPeriod.Text = Convert.ToString(lst.EMIPeriod);
                txtInstallMentPeriodFormate.Text = Convert.ToString(lst.EMIPeriodFormate);
            }
            else
            {
                txtEmiPeriod.Text = "00";
                txtInstallMentPeriodFormate.Text = "00";
            }
        }

        private void FillCustomerDetails(string customerId)
        {
            CustomerList lst = customerDetailsBA.GetCustomerList(customerId);
            if (lst.ISValidObject())
            {
                lblDob.Text = Convert.ToDateTime(lst.DOB).ToString("dd-MMM-yyyy");
                lblPhNo.Text = Convert.ToString(lst.mNo);

                string address = "Permanent :--- " + "Dist : " + lst.pmDist + ", Pin : " + lst.pmPIN + ", PS : " + lst.pmPS + ", Vill : " + lst.pmVill +
                Environment.NewLine +
                "Present :--- " + "Dist : " + lst.prDist + ", Pin : " + lst.PrPIN + ", PS : " + lst.PrPS + ", Vill : " + lst.PrVill;
                txtAddress.Text = address;
            }


        }
        private void InsertData()
        {
            //Get Share Deposit and insurance paid from socity Ledger ID
            Guid _ShareDepositLedgerId = ((KeyValuePair<Guid, string>)cmbShareDipositTo.SelectedItem).Key;
            Guid _SocietyMainBankLedgerId = ((KeyValuePair<Guid, string>)cmbSocietyMainBank.SelectedItem).Key;
           
            //GetInsurance From Customer  Ledger Id
            Guid _InsuranceFromCustomer = ledgerBA.GetLedger(LedgerEnum._FixedLedgerName.Insurance_From_Customer).LedgerId;
            Guid _InsuranceFromSociety = ledgerBA.GetLedger(LedgerEnum._FixedLedgerName.Insurance_From_Socity).LedgerId;


            //Customer Loan details
            CustomerLoanDetail frmCLD = new CustomerLoanDetail();


            //Customer Loans EMIs
            List<CustomerLoanEMI> lstCLE = new List<CustomerLoanEMI>();
            GetLoanDetailsWithEMI(out frmCLD, out lstCLE);

           //Transection
            List<Transection> lstTransection = customerLoanBA.LoanTransection(frmCLD, lstCLE,_SocietyMainBankLedgerId,_SocitySavingLoanAmLedgerId, _ShareDepositLedgerId, _InsuranceFromCustomer,_InsuranceFromSociety);

            //Insert Process
            if (frmCLD.ISValidObject() && lstCLE.IsValidList() && lstTransection.ISValidObject())
            {
                if (!transectionBA.IsExistTransection_Ref_No(txtRefNo.Text))
                {
                    if (customerLoanBA.InsertCustomerLoanWithLoanEMI(frmCLD, lstCLE, lstTransection))
                    {
                        MessageBox.Show("Loan Paid Successfull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Loan Details are Not Valid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GetLoanDetailsWithEMI(out CustomerLoanDetail lstCustomerDetail, out List<CustomerLoanEMI> lstCustomerLoanEMI)
        {
            Guid _customerLoanId = Guid.NewGuid();
            //===========Boject DataType======
            lstCustomerDetail = new CustomerLoanDetail();
            lstCustomerLoanEMI = new List<CustomerLoanEMI>();
            List<LoanCalCulatorEntities> lstEmiView = new List<LoanCalCulatorEntities>();


            DateTime _LoanDate = dtpDateOfLoan.Value;
            int _EmiPaymentDay = (int)nudEmiPaidDay.Value;

            lstEmiView = GenerateLoanDetails();

            /* ===============Install ment period Means =======================
             # After Which time paid EMI like >> One Month / 3 Month /6 Month/1 Year */
            int _installmentPeriod = Convert.ToInt32(txtEmiPeriod.Text);

            #region ==================Loan Details================
            lstCustomerDetail = (new CustomerLoanDetail
            {
                LoanId = _customerLoanId,
                SocietyLoanSlNo = cmbLoanSlNo.Text,
                Date = _LoanDate,
                CustomerId = new Guid(_CustomerId),
                SanctionedAmount = Convert.ToDouble(txtSectionAm.Text),
                RateOfInterest = Convert.ToDouble(nudSectionROI.Value),
                EMIPrincipalAmount = Convert.ToDouble(txtPrincipalAm.Text),
                EMIInterestAmount = Convert.ToDouble(txtSectionROIAm.Text),
                ShareAmount = Convert.ToDouble(txtShareAm.Text),
                ROIShare = Convert.ToDouble(txtShareROI.Text),
                InsuranceAmount = Convert.ToDouble(txtInsuranceAm.Text),
                PaidInsuranceFromSociety = Convert.ToDouble(txtInsuranceFromSocity.Text),
                PayableAmount = Convert.ToDouble(txtPayableAmount.Text),

                NoOfEMI = (long)nudNoOfEmi.Value,
                LoanTypeName = cmbLoanType.Text,
                LoanSubTypeName = cmbLoanSubType.Text,
                EMIPeriodFormate = txtInstallMentPeriodFormate.Text,
                EMIPeriod = Convert.ToInt32(txtEmiPeriod.Text),
                EMIPaidDay = (int)nudEmiPaidDay.Value,
                IsCompoundInterest = false,
                Remarks = txtPurpose.Text,
                Transection_Ref_No = txtRefNo.Text

            });
            #endregion

            #region ===============Per Month EMI===================
            int countEmi = 1;
            foreach (LoanCalCulatorEntities item in lstEmiView)
            {
                #region ----------==Date Calculate==-----------
                if (txtInstallMentPeriodFormate.Text.Trim().ToUpper() == "MONTH")
                {
                    var EmiPaymentDateOfMonth = new DateTime(_LoanDate.Year, _LoanDate.Month, _EmiPaymentDay);
                    _LoanDate = EmiPaymentDateOfMonth.AddMonths(_installmentPeriod);
                }
                //else //===Year===
                //{
                // var firstDayOfMonth = new DateTime(_LoanDate.Year, _LoanDate.Month, 1);
                //    _LoanDate = _LoanDate.AddYears(_installmentPeriod).AddDays(_EmiPaymentDay);
                //} 
                #endregion

                //Amount
                double principle = item._IPrincipal;
                double interest = item._ITotalInterest;

                //Fill
                lstCustomerLoanEMI.Add(new CustomerLoanEMI
                {
                    LoanId = _customerLoanId,
                    NoOfEMI = countEmi,
                    EMIDate = _LoanDate,
                    PrincipalAmount = principle,
                    InterestAmount = interest,
                    IsPaid = false
                });

                countEmi++;
            }
            #endregion
        }
        private List<LoanCalCulatorEntities> GenerateLoanDetails()
        {
            double _monthlyEmi = 0;
            LoanCalCulatorEntities loanCalCulatorEntities = new LoanCalCulatorEntities();
            //Get Value
            List<LoanCalCulatorEntities> lstEmiView = new List<LoanCalCulatorEntities>();
            //Return Value
            List<LoanCalCulatorEntities> lstReturn_I_P = new List<LoanCalCulatorEntities>();

            int _NoOfEMI = Convert.ToInt32(nudNoOfEmi.Value);
            DateTime _LoanDate = dtpDateOfLoan.Value;


            if (_NoOfEMI > 0)
            {
                //=======Get Value====
                loanCalCulatorEntities._INoOfPeriod = _NoOfEMI;
                loanCalCulatorEntities._IRate = (double)nudSectionROI.Value;
                loanCalCulatorEntities._IPrincipal = Convert.ToDouble(txtSectionAm.Text);

                double _totoalInterest = 0;
                double _totalPrincipal = 0;

                //Month Wise
                _monthlyEmi = loanCalculationBA.CalculateEMI(loanCalCulatorEntities, LoanCalculationBA._LoanInterVal.Month, out lstEmiView, out _totoalInterest, out _totalPrincipal);


                if (lstEmiView.IsValidList())
                {
                    dgvEMIView.Rows.Clear();
                    foreach (LoanCalCulatorEntities item in lstEmiView)
                    {
                        #region ==============Fill Gried===========
                        //Fill Gried
                        dgvEMIView.Rows.Add(item._INoOfPeriod.ToString(), item._IAmount,
                        item._ITotalInterest, item._IPrincipal, item._IOthersBalence);
                        #endregion

                        //return interest and principal View
                        lstReturn_I_P.Add(new LoanCalCulatorEntities
                        {

                            _IPrincipal = item._IPrincipal,
                            _ITotalInterest = item._ITotalInterest,
                            _IAmount = item._IAmount
                        });
                    }
                    //Total Details 
                    dgvEMIView.Rows.Add("TOTAL", "", _totoalInterest.ToString("F4"), _totalPrincipal.ToString("F4"), "");
                }

                //Fill text Box
                txtSectionROIAm.Text = _totoalInterest.ToString();
                txtMonthlyEMIAm.Text = _monthlyEmi.ToString();
            }
            return lstReturn_I_P;
        }
        private bool Isvalid()
        {
            if (!cmbCustomerName.Text.ISNullOrWhiteSpace())
            {
                if (!cmbLoanSlNo.Text.ISNullOrWhiteSpace())
                {
                    if (!cmbLoanType.Text.ISNullOrWhiteSpace())
                    {
                        if (!cmbLoanSubType.Text.ISNullOrWhiteSpace())
                        {
                            if (!txtInstallMentPeriodFormate.Text.ISNullOrWhiteSpace())
                            {
                                if (!txtEmiPeriod.Text.ISNullOrWhiteSpace())
                                {
                                    if (nudNoOfEmi.Value > 0)
                                    {
                                        if (!txtSectionAm.Text.ISNullOrWhiteSpace())
                                        {
                                            if (nudSectionROI.Value > 0)
                                            {
                                                if (!txtSectionROIAm.Text.ISNullOrWhiteSpace())
                                                {
                                                    if (!txtPrincipalAm.Text.ISNullOrWhiteSpace())
                                                    {
                                                        if (nudEmiPaidDay.Value > 0)
                                                        {
                                                            if (!cmbShareDipositTo.Text.ISNullOrWhiteSpace())
                                                            {
                                                                if (!cmbSocietyMainBank.Text.ISNullOrWhiteSpace())
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
                                                                    MessageBox.Show("Paid Insurance From Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    cmbSocietyMainBank.Focus();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Share Diposit To Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                cmbShareDipositTo.Focus();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Emi Paid Day Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            nudEmiPaidDay.Focus();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Principal Amount Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        txtPrincipalAm.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Senction ROI Amount Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    txtSectionROIAm.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Senction ROI  Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                nudSectionROI.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Section Amount Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtSectionAm.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No Of Emi Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        nudNoOfEmi.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Emi Period  Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtEmiPeriod.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("InstallMent Period Formate  Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtInstallMentPeriodFormate.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Loan Sub Type Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmbLoanSubType.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Loan Type Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbLoanType.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Loan SlNo Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbLoanSlNo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Customer Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCustomerName.Focus();
            }
            return false;
        }
        private void CalculatePaybleAmount()
        {
            double sectionAm = 0, shareAm = 0, insuranceAm = 0;
            double.TryParse(txtSectionAm.Text, out sectionAm);
            double.TryParse(txtShareAm.Text, out shareAm);
            double.TryParse(txtInsuranceAm.Text, out insuranceAm);
            txtPayableAmount.Text = (sectionAm - (shareAm + insuranceAm)).ToString();
        }

        private void PreviousLoanDetais(string cusomertId)
        {
            if (_CustomerId.ISValidObject())
            {
                double _P = 0;
                double _I = 0;
                double _total = customerLoanBA.GetDueLoanAmount(cusomertId.ConvertToGuid(), out _P, out _I);
                lblPDueLoan.Text = _P.ConvertObjectToString();
                lblIDueLoan.Text = _I.ConvertObjectToString(); 
            }
        }
        #endregion


        #region ========================Event===========================
        private void cmbCustomerName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbCustomerName.SelectedIndex >= 0)
            {
                //Customer Id
                _CustomerId = ((KeyValuePair<string, string>)cmbCustomerName.SelectedItem).Key;
                //Get customer details
                FillCustomerDetails(_CustomerId);
                
                //Previous loan Details
                PreviousLoanDetais(_CustomerId);
                            }
        }
        private void cmbLoanType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbLoanType.SelectedIndex >= 0)
            {
                //Loan Type Id
                int _loanTypeId = ((KeyValuePair<int, string>)cmbLoanType.SelectedItem).Key;
                //GetLoanSubtype
                cmbLoanSubType.AddLoanSubType(_loanTypeId);
            }
        }
        private void cmbLoanSubType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbLoanSubType.SelectedIndex >= 0)
            {
                //Loan Type Id
                int _loanSubTypeId = ((KeyValuePair<int, string>)cmbLoanSubType.SelectedItem).Key;

                FillpnlForLoanType(_loanSubTypeId);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //=======Refresh payble amount=======
            btnRefresh.PerformClick();

            if (Isvalid())
            {
                if (_SocitySavingLoanAmLedgerId.ISValidObject())
                {
                    if (!customerLoanBA.IsLoanSlNoExist(_CustomerId.ConvertToGuid(),cmbLoanSlNo.Text))
                    {
                        InsertData();
                    }
                    else
                    {
                        MessageBox.Show(cmbCustomerName.Text +"was already collect Loan From SlNo.: " +cmbLoanSlNo.Text+ "\n Please Try Another Allotment loan", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Socity Loan Ac  Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnLoanCalculator_Click(object sender, EventArgs e)
        {
            LoanCalculator childForm = new LoanCalculator();
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowDialog();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            pnlInstructionDetails.Visible = true;
        }

        #region ..................Information panel Draging.......................
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.pnlInstructionDetails.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.pnlInstructionDetails.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            pnlInstructionDetails.Visible = false;
        }
        private void txtSectionAm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void nudSectionROI_ValueChanged(object sender, EventArgs e)
        {
            GenerateLoanDetails();
        }
        private void nudNoOfEmi_ValueChanged(object sender, EventArgs e)
        {
            nudSectionROI_ValueChanged(null, null);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GenerateLoanDetails();
            CalculatePaybleAmount();
        }
        private void txtSectionAm_TextChanged(object sender, EventArgs e)
        {
            txtPrincipalAm.Text = txtSectionAm.Text;
        }
        private void cmbLoanSlNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoanSlNo.SelectedIndex >= 0)
            {
                SocietyLoansBA societyLoansBA = new SocietyLoansBA();
                SocietyLoanDetail _societyLoanDetail = societyLoansBA.GetSocityLoanDetails(cmbLoanSlNo.Text);
                _SocitySavingLoanAmLedgerId = _societyLoanDetail.LedgerFrom;
            }
        }
        #endregion
    }
}
