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
    
    public partial class Prod_Flex_Part_Wise_Operation
    {
        public int ID { get; set; }
        public int MID { get; set; }
        public int PID { get; set; }
        public string Part_Number { get; set; }
        public Nullable<bool> AFC_Op { get; set; }
        public Nullable<bool> Deburring_Op { get; set; }
        public Nullable<bool> Gauging_Op { get; set; }
        public Nullable<bool> Visual_Inspenction_Op { get; set; }
        public Nullable<bool> Flocking_Op { get; set; }
        public Nullable<bool> Heating_Op { get; set; }
        public Nullable<bool> Overflock_Gauging_Op { get; set; }
        public Nullable<bool> Silicon_Op { get; set; }
        public Nullable<bool> Tapping_Op { get; set; }
        public Nullable<bool> Assembly_Op { get; set; }
        public Nullable<bool> Final_Inspection_Op { get; set; }
        public Nullable<bool> Roll_Test_Op { get; set; }
        public Nullable<bool> QC_Inspection_Op { get; set; }
        public Nullable<bool> Packing_Op { get; set; }
        public Nullable<System.DateTime> upload_date { get; set; }
        public Nullable<int> rev_no { get; set; }
    }
}
