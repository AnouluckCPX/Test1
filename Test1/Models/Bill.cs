//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public int ID { get; set; }
        public string BillNo { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<int> UserID { get; set; }
    }
}
