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
    
    public partial class LedgerSubAccount
    {
        public int ID { get; set; }
        public string AccountName { get; set; }
        public string ParentAccount { get; set; }
        public string Nature { get; set; }
        public Nullable<bool> IsFixed { get; set; }
    }
}
