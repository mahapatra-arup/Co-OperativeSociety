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
    
    public partial class CustomerBankDetail
    {
        public long ID { get; set; }
        public System.Guid CustomerId { get; set; }
        public int BankID { get; set; }
        public string BranchName { get; set; }
        public string BankIFC { get; set; }
        public string MICRCode { get; set; }
        public string AccountNo { get; set; }
        public string BranchCode { get; set; }
    
        public virtual Bank Bank { get; set; }
        public virtual CustomerDetail CustomerDetail { get; set; }
    }
}
