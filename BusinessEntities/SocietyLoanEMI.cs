//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SocietyLoanEMI
    {
        public long ID { get; set; }
        public string SocietyLoanSlNo { get; set; }
        public long NoOfEMI { get; set; }
        public System.DateTime EMIDate { get; set; }
        public double PrincipalAmount { get; set; }
        public double InterestAmount { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public string Remarks { get; set; }
        public string Transection_Ref_No { get; set; }
    
        public virtual SocietyLoanDetail SocietyLoanDetail { get; set; }
    }
}
