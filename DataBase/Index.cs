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
    
    public partial class Index
    {
        public int TableID { get; set; }
        public string Name { get; set; }
        public int IndexID { get; set; }
        public byte Type { get; set; }
        public bool IsUnique { get; set; }
        public Nullable<bool> IsPrimaryKey { get; set; }
        public Nullable<bool> IgnoreDuplicateKey { get; set; }
        public Nullable<bool> AllowPageLocks { get; set; }
        public Nullable<bool> AllowRowLocks { get; set; }
        public Nullable<bool> IsDisabled { get; set; }
        public byte[] SysRevID { get; set; }
        public System.Guid SysRowID { get; set; }
    }
}
