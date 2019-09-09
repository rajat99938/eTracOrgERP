//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkOrderEMS.Data.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class MasterCountry
    {
        public MasterCountry()
        {
            this.MasterStates = new HashSet<MasterState>();
            this.AddressMasters = new HashSet<AddressMaster>();
        }
    
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCodeDigit { get; set; }
        public string CountryCode { get; set; }
        public long CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<long> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual ICollection<MasterState> MasterStates { get; set; }
        public virtual ICollection<AddressMaster> AddressMasters { get; set; }
    }
}
