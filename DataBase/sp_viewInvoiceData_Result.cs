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
    
    public partial class sp_viewInvoiceData_Result
    {
        public string supplier_id { get; set; }
        public string slip_no { get; set; }
        public Nullable<System.DateTime> invoice_date { get; set; }
        public string invoice_no { get; set; }
        public string supp_name { get; set; }
        public Nullable<double> total_cost { get; set; }
        public Nullable<bool> requestForDelete { get; set; }
    }
}
