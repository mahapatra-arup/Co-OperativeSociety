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
    
    public partial class FinancialYear
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinancialYear()
        {
            this.LedgersStatus = new HashSet<LedgersStatu>();
        }
    
        public long ID { get; set; }
        public string FinancialYearName { get; set; }
        public System.DateTime StartingDate { get; set; }
        public System.DateTime EndingDate { get; set; }
        public bool IsCurentyear { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LedgersStatu> LedgersStatus { get; set; }
    }
}