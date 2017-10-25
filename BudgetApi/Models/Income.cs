//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgetApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Income
    {
        public int Income_Pk { get; set; }
        public int Account_Fk { get; set; }
        public int IncomeSchedule_Fk { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual IncomeSchedule IncomeSchedule { get; set; }
    }
}
