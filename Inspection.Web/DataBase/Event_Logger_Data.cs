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
    
    public partial class Event_Logger_Data
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> Event_Date { get; set; }
        public string Shift { get; set; }
        public string Dept { get; set; }
        public string Machine_type { get; set; }
        public string MachineNo { get; set; }
        public Nullable<decimal> Hour_Meter_Reading { get; set; }
        public string Operator { get; set; }
        public Nullable<bool> Lock { get; set; }
        public string Supervisor_ID { get; set; }
        public string PartNum_at_time_of_reading { get; set; }
        public string OpNo { get; set; }
        public string Entry_type { get; set; }
        public string End_of_Product_enter_time_with_AM_PM { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Footage_Counter_Reading { get; set; }
        public Nullable<decimal> Counter_Totalizer_Reading { get; set; }
        public string If_down_all_day_reason { get; set; }
        public string other_remark { get; set; }
        public Nullable<decimal> Power_On_Hours { get; set; }
        public Nullable<decimal> Runtime_Hrs { get; set; }
        public Nullable<decimal> Cutting_Time_Hrs { get; set; }
        public Nullable<decimal> Cycletime_min { get; set; }
        public string uploadby { get; set; }
        public Nullable<System.DateTime> uploaddate { get; set; }
        public string JobNo { get; set; }
        public Nullable<decimal> Previous_Power_On_Hours { get; set; }
    }
}
