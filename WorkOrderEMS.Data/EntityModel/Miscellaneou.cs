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
    
    public partial class Miscellaneou
    {
        public long MIS_Number { get; set; }
        public long MIS_Id { get; set; }
        public Nullable<long> MIS_CCD_CostCode { get; set; }
        public long MIS_LocationId { get; set; }
        public Nullable<long> MIS_CMP_Id { get; set; }
        public string MIS_Discription { get; set; }
        public Nullable<decimal> MIS_InvoiceAmount { get; set; }
        public Nullable<System.DateTime> MIS_InvoiceDate { get; set; }
        public string MIS_InvoiceDocument { get; set; }
        public string MIS_IsActive { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual LocationMaster LocationMaster { get; set; }
        public virtual MisNumber MisNumber { get; set; }
    }
}
