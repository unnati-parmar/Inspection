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
    
    public partial class VMSFORExport
    {
        public int ID { get; set; }
        public string personid { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string late { get; set; }
        public string early { get; set; }
        public string chckin { get; set; }
        public string checkout { get; set; }
        public string hours { get; set; }
        public string gender { get; set; }
        public string typeofemployee { get; set; }
        public string PID { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<decimal> overtime { get; set; }
        public Nullable<decimal> totalworkinghours { get; set; }
    }
}
