using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CustomProperties
{
    public class CustomerEMIViewForTotal_Properties
    {
        //Paid
        public double TotalPaidPrinciple { get; set; }
        public double TotalPaidInterest { get; set; }
        public int TotalPaidNoofEMI { get; set; }


        //Due
        public double TotalDuePrinciple { get; set; }
        public double TotalDueInterest { get; set; }
        public int TotalDueNoofEMI { get; set; }
    }
}
