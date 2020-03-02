using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SocietyBusinessAccess
{
   public  class LoanCalculationBA
    {
    
        public enum _LoanInterVal{ Month,Year }


        /// <summary>
        /// Column are [_IPrincipal,_INoOfPeriod,_IRate]
        /// </summary>
        /// <param name="loanEntities"></param>
        /// <param name="_loanInterVal"></param>
        /// <param name="_EMIView"></param>
        /// <returns></returns>
        public double CalculateEMI(LoanCalCulatorEntities loanEntities, _LoanInterVal _loanInterVal, out List<LoanCalCulatorEntities> _EMIView, out double _totalInterest, out double _totalPrincipal)
        {
            //Month OF Year 
            int MonthOfYear = 12;
            double t = 0d;
            double emi;
            _EMIView = new List<LoanCalCulatorEntities>();

            // one month period
            switch (_loanInterVal)
            {
                case _LoanInterVal.Month:
                    t = loanEntities._INoOfPeriod;
                    break;
                case _LoanInterVal.Year:
                    t = loanEntities._INoOfPeriod * MonthOfYear;
                    break;
                default:
                    break;
            }

            //Calculate Monthly EMI
            emi = GetEMIAmount(loanEntities._IPrincipal, loanEntities._IRate, t, MonthOfYear);

            //===============Monthly View ========================
            _totalInterest = 0;
            _totalPrincipal = 0;

            _EMIView = CalculateEMIPayments(loanEntities._IPrincipal, t, loanEntities._IRate,
            emi,out  _totalInterest, out  _totalPrincipal);

            return emi;//monthly Total Emi
        }

      


        private double GetEMIAmount(double loanamount, double interestRate, double t, int monthOfYear)
        {
            double emi;

            #region =============Calculate EMI=============
            // one month interest
            interestRate = interestRate / (monthOfYear * 100);

            emi = (loanamount * interestRate * Math.Pow(1 + interestRate, t))
                   / (Math.Pow(1 + interestRate, t) - 1);
            #endregion

            return emi;
        }

        public List<LoanCalCulatorEntities> CalculateEMIPayments(double pPrincipal, double pDuration, double interestRate, double monthlyEmiPayment, out double totalInterest, out double totalPrincipal)
        {
            //Total
            totalInterest = 0;
            totalPrincipal = 0;

            //Monthly
            double monthInterest;
            double monthPrincipal;
            double _balanceamount = pPrincipal;


            List<LoanCalCulatorEntities> paymentList = new List<LoanCalCulatorEntities>();
            for (int count = 1; count <= pDuration; count++)
            {
                LoanCalCulatorEntities frm = new LoanCalCulatorEntities();

                //====Calculate====
                monthInterest = getInterestamt(_balanceamount, interestRate);
                monthPrincipal = monthlyEmiPayment - monthInterest;

                _balanceamount -= monthPrincipal;

                //  MessageBox.Show(monthInterest+"/"+ monthPrincipal+"/"+ b);
                //Time
                frm._INoOfPeriod = count;

                //Asol Main Balence decrese Per Month For paid InstallMent
                frm._IOthersBalence = _balanceamount;

                //Monthly Paid Amount With Out Interest
                frm._IPrincipal = monthPrincipal;

                //Monthly Interest
                frm._ITotalInterest = monthInterest;

                //Monthly Paid Emi Installment Sud-Asol
                frm._IAmount = monthlyEmiPayment;

                //Fill
                paymentList.Add(frm);


                //====================Total====================
                //Total Asol Store Globally 
                totalPrincipal += frm._IPrincipal;
                //Total Interest Calculate
                totalInterest += frm._ITotalInterest;

            }
            return paymentList;
        }
        public double getInterestamt(double principal, double interest)
        {
            return principal * ((interest / 100) * (1.0 / 12.0));
        }

    }
}
