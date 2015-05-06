//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillingSystem.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public Payment()
        {
            this.PayHistories = new HashSet<PayHistory>();
        }
    
        public int PaymentId { get; set; }
        public string Expense { get; set; }
        public string Description { get; set; }
        public Nullable<double> MonthlyEstDues { get; set; }
        public Nullable<double> InterestRate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual ICollection<PayHistory> PayHistories { get; set; }
    }
}
