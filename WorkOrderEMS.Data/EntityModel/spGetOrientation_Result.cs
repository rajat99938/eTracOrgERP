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
    
    public partial class spGetOrientation_Result
    {
        public long OTN_Id { get; set; }
        public string OTN_EMP_EmployeeID { get; set; }
        public Nullable<long> OTN_LocationId { get; set; }
        public Nullable<System.DateTime> ONT_OrientationDate { get; set; }
        public Nullable<System.TimeSpan> ONT_Orientationtime { get; set; }
        public Nullable<System.DateTime> ONT_Date { get; set; }
        public string ONT_IsActive { get; set; }
    }
}
