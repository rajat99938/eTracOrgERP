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
    
    public partial class UserVehicleSeatingMap
    {
        public long UVM_Id { get; set; }
        public long UVM_UserId { get; set; }
        public long UVM_VST_Id { get; set; }
        public Nullable<System.DateTime> UVM_Date { get; set; }
        public string UVM_IsActive { get; set; }
    
        public virtual UserRegistration UserRegistration { get; set; }
    }
}