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
    
    public partial class InterviewQuestionMaster
    {
        public InterviewQuestionMaster()
        {
            this.InterviewQuestionChilds = new HashSet<InterviewQuestionChild>();
        }
    
        public long IQM_Id { get; set; }
        public string IQM_Question { get; set; }
        public string IQM_Exempt { get; set; }
        public Nullable<System.DateTime> IQM_Date { get; set; }
        public string IQM_IsActive { get; set; }
    
        public virtual ICollection<InterviewQuestionChild> InterviewQuestionChilds { get; set; }
    }
}