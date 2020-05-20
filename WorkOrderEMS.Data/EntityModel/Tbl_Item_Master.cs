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
    
    public partial class Tbl_Item_Master
    {
        public long Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public Nullable<long> CategoryType { get; set; }
        public Nullable<long> RevenueCode { get; set; }
        public Nullable<long> ExpenseType { get; set; }
        public Nullable<decimal> ItemRate { get; set; }
        public Nullable<long> ItemUnit { get; set; }
        public string SpecialNote { get; set; }
        public Nullable<decimal> TaxPercentage { get; set; }
        public string EntryBy { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}