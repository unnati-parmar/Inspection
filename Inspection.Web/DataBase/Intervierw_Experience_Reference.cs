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
    
    public partial class Intervierw_Experience_Reference
    {
        public int Id { get; set; }
        public int MID { get; set; }
        public Nullable<int> Personal_Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> from_date { get; set; }
        public Nullable<System.DateTime> to_date { get; set; }
        public string designation { get; set; }
        public string monthly_salary { get; set; }
        public string type { get; set; }
        public string contact_no { get; set; }
        public string Main_Subject { get; set; }
    }
}
