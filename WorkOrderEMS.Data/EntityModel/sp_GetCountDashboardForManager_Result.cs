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
    
    public partial class sp_GetCountDashboardForManager_Result
    {
        public Nullable<long> WorkRequestCount { get; set; }
        public Nullable<long> DarCount { get; set; }
        public Nullable<long> RuleViolationCount { get; set; }
        public Nullable<long> FacilityRequestCount { get; set; }
        public Nullable<long> FacilityRequestCountLocation { get; set; }
        public Nullable<long> ContinuesRequestCount { get; set; }
        public Nullable<long> ProgressContinuesWO { get; set; }
        public Nullable<long> CompletedContinuesWO { get; set; }
        public Nullable<long> MissedContinuesWO { get; set; }
        public Nullable<long> LocationId { get; set; }
    }
}
