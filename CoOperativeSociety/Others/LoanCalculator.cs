using BusinessEntities;
using SocietyBusinessAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoOperativeSociety.Others
{
    public partial class LoanCalculator : Form
    {
        LoanCalculationBA loanCalculationBA = new LoanCalculationBA();

        public LoanCalculator()
        {
            InitializeComponent();
        }
        private void FillDetails()
        {
            //Clear
            dgvView.Rows.Clear();

            //Logic
           LoanCalCulatorEntities loanCalCulatorEntities = new LoanCalCulatorEntities();
            List<LoanCalCulatorEntities> _DtEMIView = new List<LoanCalCulatorEntities>(); 
            double _totalInterest = 0;
            double _totalPrincipal = 0;

            //Send Details
            LoanCalculationBA._LoanInterVal loanInterVal = cmbRepaymentInterVal.Text.Trim().ToUpper() == "YEAR" ? LoanCalculationBA._LoanInterVal.Year : LoanCalculationBA._LoanInterVal.Month;

            loanCalCulatorEntities._IPrincipal = Convert.ToDouble(txtLoanAmount.Text);
            loanCalCulatorEntities._IRate = Convert.ToDouble(txtRate.Text);
            loanCalCulatorEntities._INoOfPeriod = Convert.ToDouble(txtNoOfPayment.Text);
            double _MonthlyEmi = loanCalculationBA.CalculateEMI(loanCalCulatorEntities, loanInterVal, out _DtEMIView, out _totalInterest, out _totalPrincipal);

            //EMI/Month
            txtEmiAmount.Text = "   EMI/MONTH : "+_MonthlyEmi.ToString();

            //Fill gried
            if (_DtEMIView.IsValidList())
            {
                foreach (LoanCalCulatorEntities item in _DtEMIView)
                {
                    dgvView.Rows.Add(item._INoOfPeriod.ToString(), item._IAmount.ToString("F4"),
                    item._ITotalInterest.ToString("F4"), item._IPrincipal.ToString("F4"), item._IOthersBalence.ToString("F4")+"");

                }
                //Total Details 
                dgvView.Rows.Add("TOTAL", "",  _totalInterest.ToString("F4"), _totalPrincipal.ToString("F4"),"");
            }
        }

        #region =============Event=================
        private void txtLoanAmount_KeyPress(object sender, KeyPressEventArgs ex)
        {
            ValidationUtils.FlotingNumberValidation(sender, ex);
        }
        private void btnCalCulate_Click(object sender, EventArgs e)
        {
            if (txtLoanAmount.Text != string.Empty)
            {
                if (!txtNoOfPayment.Text.ISNullOrWhiteSpace())
                {
                    FillDetails();
                }
                else
                {

                }
            }
            else
            {

            }
        } 
        #endregion
    }
}
