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
    
    public partial class formula_history_tbl
    {
        public int id { get; set; }
        public Nullable<int> formula_id { get; set; }
        public string active_time { get; set; }
        public string deactive_time { get; set; }
        public string active_by { get; set; }
        public string deactive_by { get; set; }
    }
}
