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
    
    public partial class Items_of_EPO_temp
    {
        public int ID { get; set; }
        public int line_no { get; set; }
        public int PID { get; set; }
        public string product_description { get; set; }
        public string product_group { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> unitprice { get; set; }
        public string uom { get; set; }
        public string dept { get; set; }
        public string account_no { get; set; }
        public string gujarat { get; set; }
        public Nullable<decimal> tax { get; set; }
        public Nullable<decimal> dis { get; set; }
        public Nullable<decimal> unityprice_qty { get; set; }
        public Nullable<decimal> qty_unitprice_tax { get; set; }
        public Nullable<decimal> totalcost_dis { get; set; }
        public string gst { get; set; }
        public Nullable<decimal> cgst { get; set; }
        public Nullable<decimal> sgst { get; set; }
        public Nullable<decimal> igst { get; set; }
        public Nullable<decimal> extended_cost { get; set; }
        public string purchase { get; set; }
        public Nullable<int> EPO_no { get; set; }
        public Nullable<decimal> received_qty { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }
        public Nullable<decimal> cgst_value { get; set; }
        public Nullable<decimal> sgst_value { get; set; }
        public Nullable<decimal> tax_value { get; set; }
        public Nullable<decimal> igst_value { get; set; }
        public string Currency_Type { get; set; }
    }
}
