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
    
    public partial class Final_Inspection_Process
    {
        public int ID { get; set; }
        public int PID { get; set; }
        public int MID { get; set; }
        public string Inspection_ID { get; set; }
        public Nullable<int> Rework_Id { get; set; }
        public string Process { get; set; }
        public string JobNum { get; set; }
        public string PartNum { get; set; }
        public string Inspection_Type { get; set; }
        public Nullable<System.DateTime> Inspection_date { get; set; }
        public string starttime { get; set; }
        public Nullable<System.DateTime> endtime { get; set; }
        public Nullable<int> Inspection_Qty { get; set; }
        public string done_by { get; set; }
        public string Stage { get; set; }
        public Nullable<bool> CkMRB { get; set; }
        public Nullable<bool> Statuschange { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string Qualitystage { get; set; }
        public string sampleqty { get; set; }
    }
}
