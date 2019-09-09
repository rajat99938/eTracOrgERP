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
    
    public partial class CostCode
    {
        public CostCode()
        {
            this.LogCostCodes = new HashSet<LogCostCode>();
            this.CostCodeLocationMappings = new HashSet<CostCodeLocationMapping>();
            this.LogCompanyFacilityMappings = new HashSet<LogCompanyFacilityMapping>();
            this.LogMiscellaneous = new HashSet<LogMiscellaneou>();
            this.Miscellaneous = new HashSet<Miscellaneou>();
            this.CompanyFacilityMappings = new HashSet<CompanyFacilityMapping>();
        }
    
        public long CCD_CostCode { get; set; }
        public long CCD_CCM_CostCode { get; set; }
        public string CCD_Description { get; set; }
        public string CCD_IsActive { get; set; }
        public long CCD_QBKId { get; set; }
        public string CCD_FacilityType { get; set; }
    
        public virtual CostCodeMaster CostCodeMaster { get; set; }
        public virtual ICollection<LogCostCode> LogCostCodes { get; set; }
        public virtual ICollection<CostCodeLocationMapping> CostCodeLocationMappings { get; set; }
        public virtual ICollection<LogCompanyFacilityMapping> LogCompanyFacilityMappings { get; set; }
        public virtual ICollection<LogMiscellaneou> LogMiscellaneous { get; set; }
        public virtual ICollection<Miscellaneou> Miscellaneous { get; set; }
        public virtual ICollection<CompanyFacilityMapping> CompanyFacilityMappings { get; set; }
    }
}
