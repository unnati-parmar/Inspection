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
    
    public partial class SubShipD
    {
        public string Company { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public decimal ShipQty { get; set; }
        public int Packages { get; set; }
        public string PartNum { get; set; }
        public string LineDesc { get; set; }
        public string IUM { get; set; }
        public string ShipComment { get; set; }
        public string WUM { get; set; }
        public string LotNum { get; set; }
        public string DimCode { get; set; }
        public string DUM { get; set; }
        public decimal DimConvFactor { get; set; }
        public int PONum { get; set; }
        public int POLine { get; set; }
        public int PORelNum { get; set; }
        public byte[] SysRevID { get; set; }
        public System.Guid SysRowID { get; set; }
        public Nullable<decimal> Number01 { get; set; }
        public Nullable<System.Guid> ForeignSysRowID { get; set; }
        public byte[] UD_SysRevID { get; set; }
    }
}
