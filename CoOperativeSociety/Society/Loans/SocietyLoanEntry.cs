using BusinessEntities;
using BusinessEntities._enum;
using CoOperativeSociety.Others;
using CoOperativeSociety.Tools;
using SocietyBusinessAccess;
using SocietyBusinessAccess.Loans;
using SocietyBusinessAccess.Transections;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoOperativeSociety.Society.Loans
{
    public partial class SocietyLoanEntry : Form
    {
        //Object Type
        #region ================Object Type===========
        private static LoanTypeBA loanTypeBA = new LoanTypeBA();
        SocietyLoansBA societyLoansBA = new SocietyLoansBA();
        LoanCalculationBA loanCalculationBA = new LoanCalculationBA();
        TransectionBA transectionBA = new TransectionBA();
        #endregion

        public SocietyLoanEntry()
        {
            InitializeComponent();

            //==Get Loan Type==
            cmbLoanType.AddLoanType();
            //Get Bank parent ledger 
            cmbLedgerBank.AddLedger(LedgerEnum._LedgerAttributes.Category, LedgerEnum._LedgerCategoryValues.Bank);

            //Set Reference No
            txtRefNo.Text = transectionBA.GenerateTransectionsRefNo();
        }

        #region ==================Method==============
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
                                                        if (!cmbLoanBank.Text.ISNullOrWhiteSpace())
                                                        {
                                                            if (!cmbSavingBank.Text.ISNullOrWhiteSpace())
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
                                                                MessageBox.Show("Saving Bank Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                cmbSavingBank.Focus();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Loan Bank Is Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            cmbLoanBank.Focus();
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
            return false;

        }
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
        private void InsertData()
        {
            //Ledger Details
            Guid _loanbankLedgerId = ((KeyValuePair<Guid, string>)cmbLoanBank.SelectedItem).Key;
            Guid _savingbankLedgerId = ((KeyValuePair<Guid, string>)cmbSavingBank.SelectedItem).Key;

            //Socity Loan details
            SocietyLoanDetail frmCLD = new SocietyLoanDetail();

            //Socity Loan EMIs
            List<SocietyLoanEMI> lstCLE = new List<SocietyLoanEMI>();
            GetLoanDetailsWithEMI(out frmCLD, out lstCLE, _loanbankLedgerId, _savingbankLedgerId);

            //Socity Loan Transection
            List<Transection> lstTransection = societyLoansBA.TransectionGenerate(frmCLD, _loanbankLedgerId, _savingbankLedgerId);

            //Insert Process
            if (frmCLD.ISValidObject() && lstCLE.IsValidList() && lstTransection.ISValidObject())
            {
                if (!transectionBA.IsExistTransection_Ref_No(txtRefNo.Text))
                {
                    if (societyLoansBA.InsertSocityLoanWithLoanEMI(frmCLD, lstCLE, lstTransection))
                    {
                        MessageBox.Show("loan gave is successfull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void GetLoanDetailsWithEMI(out SocietyLoanDetail lstSocityDetail, out List<SocietyLoanEMI> lstSocityLoanEMI, Guid _loanbankLedgerId, Guid _savingbankLedgerId)
        {
            Guid _customerLoanId = Guid.NewGuid();

            //===========object DataType======
            lstSocityDetail = new SocietyLoanDetail();
            lstSocityLoanEMI = new List<SocietyLoanEMI>();
            List<LoanCalCulatorEntities> lstEmiView = new List<LoanCalCulatorEntities>();


            DateTime _LoanDate = dtpDateOfLoan.Value;
            int _EmiPaymentDay = nudEmiPaidDay.Value.ConvertObjectToInt();

            //emi View
            lstEmiView = GenerateLoanDetails();

            /* ===============Install ment period Means =======================
              # After Which time paid EMI like >> One Month / 3 Month /6 Month/1 Year */
            int _installmentPeriod = Convert.ToInt32(txtEmiPeriod.Text);

            #region ==================Loan Details================
            lstSocityDetail = (new SocietyLoanDetail
            {
                SocietyLoanSlNo = cmbLoanSlNo.Text,
                Date = _LoanDate,
                SanctionedAmount = Convert.ToDouble(txtSectionAm.Text),
                RateOfInterest = Convert.ToDouble(nudSectionROI.Value),
                EMIPrincipalAmount = Convert.ToDouble(txtPrincipalAm.Text),
                EMIInterestAmount = Convert.ToDouble(txtSectionROIAm.Text),
                PayableAmount = Convert.ToDouble(txtPayableAmount.Text),

                NoOfEMI = (long)nudNoOfEmi.Value,
                LoanTypeName = cmbLoanType.Text,
                LoanSubTypeName = cmbLoanSubType.Text,
                EMIPeriodFormate = txtInstallMentPeriodFormate.Text,
                EMIPeriod = Convert.ToInt32(txtEmiPeriod.Text),
                EMIPaidDay = nudEmiPaidDay.Value.ConvertObjectToInt(),
                IsCompoundInterest = false,
                Remarks = txtPurpose.Text,
                Transection_Ref_No = txtRefNo.Text,

                //transection
                LedgerFrom = _savingbankLedgerId,//Loan Acount are store this account
                LedgerTo = _loanbankLedgerId,
            });
            #endregion

            #region ===============PerMonth EMI====================
            int countEmi = 1;
            foreach (LoanCalCulatorEntities item in lstEmiView)
            {
                #region ----------==Date Calculate==-----------
                if (txtInstallMentPeriodFormate.Text.Trim().ToUpper() == "MONTH")
                {
                    var EmiPaymentDateOfMonth = new DateTime(_LoanDate.Year, _LoanDate.Month, _EmiPaymentDay);
                    _LoanDate = EmiPaymentDateOfMonth.AddMonths(_installmentPeriod);
                }
                //else//Year
                //{
                // var firstDayOfMonth = new DateTime(_LoanDate.Year, _LoanDate.Month, 1);
                //    _LoanDate = _LoanDate.AddYears(_installmentPeriod).AddDays(_EmiPaymentDay);
                //} 
                #endregion

                //Amount
                double principle = item._IPrincipal;
                double interest = item._ITotalInterest;


                lstSocityLoanEMI.Add(new SocietyLoanEMI
                {
                    SocietyLoanSlNo = cmbLoanSlNo.Text,
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

        #endregion

        #region ==================Event===============

        private void cmbLedgerBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbLedgerBank.Text.ISNullOrWhiteSpace())
            {
                Guid _ParentBankLedgerId = ((KeyValuePair<Guid, string>)cmbLedgerBank.SelectedItem).Key;

                //Add Loan Bank and Saving Bank Ac/Current Bank Account
                #region ==========Society Bank saving/current and loan bank ac==============
                //Saving
                var lstSocityBankAttribute = new List<LedgerEnum._LedgerCategoryValues>();
                lstSocityBankAttribute.Add(LedgerEnum._LedgerCategoryValues.Society_Saving_AC);
                lstSocityBankAttribute.Add(LedgerEnum._LedgerCategoryValues.Society_Current_AC);
                cmbSavingBank.AddChildLedgers(_ParentBankLedgerId, LedgerEnum._LedgerAttributes.Category, lstSocityBankAttribute);

                //Loan
                lstSocityBankAttribute = new List<LedgerEnum._LedgerCategoryValues>();
                lstSocityBankAttribute.Add(LedgerEnum._LedgerCategoryValues.Society_Loan_AC);
                cmbLoanBank.AddChildLedgers(_ParentBankLedgerId, LedgerEnum._LedgerAttributes.Category, lstSocityBankAttribute);
                #endregion
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                if (!societyLoansBA.IsLoanSlNoExist(cmbLoanSlNo.Text))
                {
                    InsertData();
                }
                else
                {
                    MessageBox.Show("Loan SlNo Is Exist", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbLoanSlNo.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudSectionROI_ValueChanged(object sender, EventArgs e)
        {
            GenerateLoanDetails();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GenerateLoanDetails();
        }

        private void txtSectionAm_TextChanged(object sender, EventArgs e)
        {
            txtPayableAmount.Text = txtSectionAm.Text;
            txtPrincipalAm.Text = txtSectionAm.Text;
        }


        private void btnLoanCalculator_Click(object sender, EventArgs e)
        {
            LoanCalculator childForm = new LoanCalculator();
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowDialog();
        }

        private void txtSectionAm_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.FlotingNumberValidation(sender, e);
        }
        private void cmbLoanType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cmbLoanSubType.Text = string.Empty;
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

        #endregion
    }
}
