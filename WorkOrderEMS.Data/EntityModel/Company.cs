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
    
    public partial class Company
    {
        public Company()
        {
            this.Bills = new HashSet<Bill>();
            this.CompanyAccountDetails = new HashSet<CompanyAccountDetail>();
            this.CompanyDetails = new HashSet<CompanyDetail>();
            this.CompanyFacilityMappings = new HashSet<CompanyFacilityMapping>();
            this.CompanyQBKs = new HashSet<CompanyQBK>();
            this.Contracts = new HashSet<Contract>();
            this.Contracts1 = new HashSet<Contract>();
            this.Insurances = new HashSet<Insurance>();
            this.Licenses = new HashSet<License>();
            this.LocationCompanyMappings = new HashSet<LocationCompanyMapping>();
            this.LogBills = new HashSet<LogBill>();
            this.LogCompanies = new HashSet<LogCompany>();
            this.LogCompanyAccountDetails = new HashSet<LogCompanyAccountDetail>();
            this.LogCompanyDetails = new HashSet<LogCompanyDetail>();
            this.LogCompanyFacilityMappings = new HashSet<LogCompanyFacilityMapping>();
            this.LogContracts = new HashSet<LogContract>();
            this.LogContracts1 = new HashSet<LogContract>();
            this.LogInsurances = new HashSet<LogInsurance>();
            this.LogLicenses = new HashSet<LogLicense>();
            this.LogLocationCompanyMappings = new HashSet<LogLocationCompanyMapping>();
            this.LogMiscellaneous = new HashSet<LogMiscellaneou>();
            this.LogPreBills = new HashSet<LogPreBill>();
            this.Miscellaneous = new HashSet<Miscellaneou>();
            this.PreBills = new HashSet<PreBill>();
        }
    
        public long CMP_Id { get; set; }
        public string CMP_NameLegal { get; set; }
        public string CMP_NameDBA { get; set; }
        public Nullable<long> CMP_VDT_Id { get; set; }
        public long CMP_COT_Id { get; set; }
        public string CMP_CompanyDocument { get; set; }
        public string CMP_IsActive { get; set; }
        public Nullable<long> CMP_UserId { get; set; }
    
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual CompanyType CompanyType { get; set; }
        public virtual VendorType VendorType { get; set; }
        public virtual ICollection<CompanyAccountDetail> CompanyAccountDetails { get; set; }
        public virtual ICollection<CompanyDetail> CompanyDetails { get; set; }
        public virtual ICollection<CompanyFacilityMapping> CompanyFacilityMappings { get; set; }
        public virtual ICollection<CompanyQBK> CompanyQBKs { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Contract> Contracts1 { get; set; }
        public virtual ICollection<Insurance> Insurances { get; set; }
        public virtual ICollection<License> Licenses { get; set; }
        public virtual ICollection<LocationCompanyMapping> LocationCompanyMappings { get; set; }
        public virtual ICollection<LogBill> LogBills { get; set; }
        public virtual ICollection<LogCompany> LogCompanies { get; set; }
        public virtual ICollection<LogCompanyAccountDetail> LogCompanyAccountDetails { get; set; }
        public virtual ICollection<LogCompanyDetail> LogCompanyDetails { get; set; }
        public virtual ICollection<LogCompanyFacilityMapping> LogCompanyFacilityMappings { get; set; }
        public virtual ICollection<LogContract> LogContracts { get; set; }
        public virtual ICollection<LogContract> LogContracts1 { get; set; }
        public virtual ICollection<LogInsurance> LogInsurances { get; set; }
        public virtual ICollection<LogLicense> LogLicenses { get; set; }
        public virtual ICollection<LogLocationCompanyMapping> LogLocationCompanyMappings { get; set; }
        public virtual ICollection<LogMiscellaneou> LogMiscellaneous { get; set; }
        public virtual ICollection<LogPreBill> LogPreBills { get; set; }
        public virtual ICollection<Miscellaneou> Miscellaneous { get; set; }
        public virtual ICollection<PreBill> PreBills { get; set; }
    }
}
