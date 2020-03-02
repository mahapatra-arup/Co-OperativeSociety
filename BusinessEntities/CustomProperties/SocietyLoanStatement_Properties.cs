using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CustomProperties
{
    /// <summary>
    /// Socity Properties Of Socity Loan statement
    /// </summary>
    [Description("Socity Properties Of Socity Loan statement")]
    public class SocietyLoanStatement_Properties
    {
        public string Transection_Ref_No { get; set; }
        public string No { get; set; }
        public DateTime Date { get; set; }

        //Loan
        public double TotalLoanAmount { get; set; }
        public double TotalLoanInterestAmount { get; set; }

        //Paid
        public double TotalPaidPrincipalAmount { get; set; }
        public double TotalPaidInterestAmount { get; set; }

        //EMI
        public int TotalEMI { get; set; }
        public int TotalPaidEMI
        {
            get; set;
        }
      
        //Bank
        public Guid? LoanBankLedgerId { get; set; }
        public string LoanBank { get; set; }

        public Guid? LoanReceiveLedgerId { get; set; }
        public string LoanReceiveBank { get; set; }
    }
}
