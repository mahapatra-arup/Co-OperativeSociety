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
    
    public partial class District
    {
        public int Id { get; set; }
        public string DistName { get; set; }
        public Nullable<int> StateID { get; set; }
    
        public virtual State State { get; set; }
    }
}
