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
    
    public partial class PartMasterTbl
    {
        public int id { get; set; }
        public string PartNum { get; set; }
        public string PartDescription { get; set; }
        public string Uom { get; set; }
        public Nullable<bool> is_deleted { get; set; }
        public Nullable<bool> is_lotRequired { get; set; }
    }
}
