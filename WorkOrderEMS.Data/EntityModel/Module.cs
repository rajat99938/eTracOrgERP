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
    
    public partial class Module
    {
        public Module()
        {
            this.Rules = new HashSet<Rule>();
            this.eForms = new HashSet<eForm>();
        }
    
        public long MDL_Id { get; set; }
        public string MDL_ModuleName { get; set; }
        public Nullable<System.DateTime> MDL_Date { get; set; }
        public string MDL_IsActive { get; set; }
    
        public virtual ICollection<Rule> Rules { get; set; }
        public virtual ICollection<eForm> eForms { get; set; }
    }
}
