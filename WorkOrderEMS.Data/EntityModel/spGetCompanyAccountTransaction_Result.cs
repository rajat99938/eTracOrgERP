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
    
    public partial class spGetCompanyAccountTransaction_Result
    {
        public long CAT_Id { get; set; }
        public long CAT_CMP_IdDr { get; set; }
        public long CAT_CMP_IdCr { get; set; }
        public Nullable<long> CAT_CAD_IdDr { get; set; }
        public Nullable<long> CAT_CAD_IdCr { get; set; }
        public Nullable<long> CAT_BLL_Id { get; set; }
        public decimal CAT_Amount { get; set; }
        public Nullable<int> CAT_ChequeNo { get; set; }
        public string CAT_Discription { get; set; }
        public System.DateTime CAT_TransactionDate { get; set; }
        public Nullable<long> CAT_PayBy { get; set; }
        public string CAT_IsActive { get; set; }
        public Nullable<long> CAT_PMD_Id { get; set; }
        public Nullable<long> CAT_ClientInvoice_Id { get; set; }
    }
}