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
    
    public partial class ApplicantContactInfo
    {
        public long ACI_Id { get; set; }
        public Nullable<long> ACI_APT_ApplicantId { get; set; }
        public Nullable<long> ACI_PhoneNo { get; set; }
        public string ACI_eMail { get; set; }
        public string ACI_PrefredContactMethod { get; set; }
        public Nullable<System.DateTime> ACI_Date { get; set; }
        public string ACI_IsActive { get; set; }
    }
}
