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
    
    public partial class InterviewProposalTime
    {
        public long IPT_Id { get; set; }
        public long IPT_JPS_JobPostingId { get; set; }
        public Nullable<long> IPT_APT_ApplicantId { get; set; }
        public long IPT_EMP_EmployeeID_HM { get; set; }
        public Nullable<long> IPT_EMP_EmployeeID_SE { get; set; }
        public Nullable<long> IPT_EMP_EmployeeID_TE { get; set; }
        public Nullable<long> IPT_BST_Id_HM { get; set; }
        public Nullable<long> IPT_BST_Id_SE { get; set; }
        public Nullable<long> IPT_BST_Id_TE { get; set; }
        public Nullable<System.DateTime> IPT_InterviewDateTime { get; set; }
        public string IPT_Status { get; set; }
        public Nullable<int> IPT_SentCount { get; set; }
        public Nullable<System.DateTime> IPT_Date { get; set; }
        public string IPT_IsActive { get; set; }
    }
}
