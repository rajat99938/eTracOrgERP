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
    
    public partial class spGetApplicantTrafficConvictions_Result
    {
        public long ATC_Id { get; set; }
        public Nullable<long> ATC_APT_ApplicantId { get; set; }
        public Nullable<System.DateTime> ATC_ConvictedDate { get; set; }
        public string ATC_Violation { get; set; }
        public string ATC_StateOfViolation { get; set; }
        public string ATC_AtFaultAccident { get; set; }
        public string ATC_AtMovingViolation { get; set; }
        public Nullable<System.DateTime> ATC_Date { get; set; }
        public string ATC_IsActive { get; set; }
    }
}
