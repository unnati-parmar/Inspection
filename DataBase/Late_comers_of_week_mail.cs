//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inspection.Web.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Late_comers_of_week_mail
    {
        public int ID { get; set; }
        public int MID { get; set; }
        public int PID { get; set; }
        public Nullable<int> Person_ID { get; set; }
        public string Person_Name { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.TimeSpan> time { get; set; }
        public Nullable<decimal> minutes_late { get; set; }
        public string day_of_week { get; set; }
    }
}
