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
    
    public partial class spGetPOFacilityItemForEdit_Result
    {
        public Nullable<long> POF_Id { get; set; }
        public long CFM_Id { get; set; }
        public long CFM_CMP_Id { get; set; }
        public long CFM_CCD_CostCode { get; set; }
        public string CFM_FacilityType { get; set; }
        public Nullable<decimal> CFM_Rate { get; set; }
        public Nullable<decimal> CFM_Tax { get; set; }
        public string CFM_Discription { get; set; }
        public Nullable<decimal> BCM_BalanceAmount { get; set; }
    }
}
