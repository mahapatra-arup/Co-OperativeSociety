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
    
    public partial class LedgerBankDetail
    {
        public long ID { get; set; }
        public System.Guid LedgerID { get; set; }
        public int BankID { get; set; }
        public string ACNo { get; set; }
        public string IFSC { get; set; }
        public string MICR { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string Address { get; set; }
        public string ACType { get; set; }
    
        public virtual Bank Bank { get; set; }
        public virtual Ledger Ledger { get; set; }
    }
}
