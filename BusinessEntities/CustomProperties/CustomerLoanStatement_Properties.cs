using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CustomProperties
{
    /// <summary>
    /// Custom Properties Of Customer Loan statement
    /// </summary>
    [Description("Custom Properties Of Customer Loan statement")]
   public class CustomerLoanStatement_Properties
    {
        public System.Guid CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string mNo { get; set; }
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

    }
}
