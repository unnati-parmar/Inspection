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
    
    public partial class VMS_FTO_Request
    {
        public int ID { get; set; }
        public string PersonID { get; set; }
        public string personname { get; set; }
        public Nullable<System.DateTime> startdate { get; set; }
        public string s_leave_type { get; set; }
        public Nullable<System.DateTime> enddate { get; set; }
        public string e_leave_type { get; set; }
        public string Type_of_leave { get; set; }
        public string other_type { get; set; }
        public Nullable<int> EFL_Days_given { get; set; }
        public Nullable<int> EFL_Days_Used { get; set; }
        public Nullable<int> EFL_Balance { get; set; }
        public Nullable<int> EFL_Days_Requested { get; set; }
        public Nullable<int> EVL_Days_Given { get; set; }
        public Nullable<int> EVL_Days_Used { get; set; }
        public Nullable<int> EVL_Balance { get; set; }
        public Nullable<int> EVL_Days_Requested { get; set; }
        public string Employee_comment { get; set; }
        public string Supervisor_Notes { get; set; }
        public string HR_Notes { get; set; }
        public string Supervisor_approval { get; set; }
        public string HR_approval { get; set; }
        public string MPC_approval { get; set; }
        public Nullable<decimal> EFL_Days_given_new { get; set; }
        public Nullable<decimal> EFL_Days_Used_new { get; set; }
        public Nullable<decimal> EFL_Balance_new { get; set; }
        public Nullable<decimal> EFL_Days_Requested_new { get; set; }
        public Nullable<decimal> EVL_Days_Given_new { get; set; }
        public Nullable<decimal> EVL_Days_Used_new { get; set; }
        public Nullable<decimal> EVL_Balance_new { get; set; }
        public Nullable<decimal> EVL_Days_Requested_new { get; set; }
    }
}
