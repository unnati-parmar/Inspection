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
    
    public partial class PPAP_Data
    {
        public int ID { get; set; }
        public int MID { get; set; }
        public int PID { get; set; }
        public string PPAP_No { get; set; }
        public string ssw_part_no { get; set; }
        public string ssw_part_name { get; set; }
        public string cust_part_no { get; set; }
        public string cust_part_name { get; set; }
        public string reason_for_submission { get; set; }
        public string submission_level { get; set; }
        public Nullable<System.DateTime> ppap_upload_date { get; set; }
        public string remark { get; set; }
        public Nullable<System.DateTime> submission_date { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }
        public string customer_ppap_status { get; set; }
        public Nullable<System.DateTime> approve_date { get; set; }
        public Nullable<System.DateTime> not_approve_date { get; set; }
        public Nullable<System.DateTime> rejected_date { get; set; }
        public Nullable<System.DateTime> revise_date { get; set; }
        public string PPAP_Attachment { get; set; }
        public string PPAP_Update_History { get; set; }
        public Nullable<System.DateTime> PPAP_Update_Date { get; set; }
        public string ssw_drawing_no { get; set; }
        public string cust_drawing_no { get; set; }
        public string reason_for_not_approve { get; set; }
        public string End_Customer { get; set; }
        public string Other_Reason { get; set; }
        public string Re_qualification_Year { get; set; }
        public Nullable<System.DateTime> Re_qualification_date { get; set; }
        public Nullable<bool> Re_Qualification_Required { get; set; }
        public Nullable<int> revice_ID { get; set; }
    }
}
