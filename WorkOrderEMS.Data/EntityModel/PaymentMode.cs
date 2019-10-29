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
    
    public partial class PaymentMode
    {
        public PaymentMode()
        {
            this.CompanyAccountDetails = new HashSet<CompanyAccountDetail>();
            this.Contracts = new HashSet<Contract>();
            this.LogCompanyAccountDetails = new HashSet<LogCompanyAccountDetail>();
            this.LogContracts = new HashSet<LogContract>();
        }
    
        public long PMD_Id { get; set; }
        public string PMD_PaymentMode { get; set; }
        public string PMD_IsActive { get; set; }
    
        public virtual ICollection<CompanyAccountDetail> CompanyAccountDetails { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<LogCompanyAccountDetail> LogCompanyAccountDetails { get; set; }
        public virtual ICollection<LogContract> LogContracts { get; set; }
    }
}
