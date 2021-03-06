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
    
    public partial class LogBill
    {
        public long LBLL_Id { get; set; }
        public Nullable<long> LBLL_POD_Id { get; set; }
        public Nullable<long> LBLL_MIS_Id { get; set; }
        public Nullable<long> LBLL_PBL_Id { get; set; }
        public Nullable<long> LBLL_BLL_Id { get; set; }
        public Nullable<long> LBLL_CMP_Id { get; set; }
        public long LBLL_LocationId { get; set; }
        public string LBLL_BillType { get; set; }
        public Nullable<decimal> LBLL_PoMisBdaAmount { get; set; }
        public Nullable<decimal> LBLL_InvoiceAmount { get; set; }
        public Nullable<System.DateTime> LBLL_InvoiceDate { get; set; }
        public string LBLL_InvoiceDocument { get; set; }
        public long LBLL_ModifiedBy { get; set; }
        public System.DateTime LBLL_ModifiedOn { get; set; }
        public Nullable<long> LBLL_ApprovedBy { get; set; }
        public Nullable<System.DateTime> LBLL_ApprovedOn { get; set; }
        public string LBLL_Comment { get; set; }
        public string LBLL_IsApprove { get; set; }
        public string LBLL_IsActive { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Company Company { get; set; }
        public virtual LocationMaster LocationMaster { get; set; }
    }
}
