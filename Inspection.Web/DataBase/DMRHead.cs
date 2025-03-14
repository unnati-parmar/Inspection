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
    
    public partial class DMRHead
    {
        public string Company { get; set; }
        public int DMRNum { get; set; }
        public bool OpenDMR { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public int ConNum { get; set; }
        public string CommentText { get; set; }
        public decimal TotDiscrepantQty { get; set; }
        public decimal TotRejectedQty { get; set; }
        public decimal TotAcceptedQty { get; set; }
        public decimal AvgMtlUnitCost { get; set; }
        public decimal AvgLbrUnitCost { get; set; }
        public decimal AvgBurUnitCost { get; set; }
        public decimal AvgSubUnitCost { get; set; }
        public decimal AvgMtlBurUnitCost { get; set; }
        public string PartNum { get; set; }
        public string PartDescription { get; set; }
        public string DimCode { get; set; }
        public string LotNum { get; set; }
        public string IUM { get; set; }
        public bool CheckOff1 { get; set; }
        public bool CheckOff2 { get; set; }
        public bool CheckOff3 { get; set; }
        public bool CheckOff4 { get; set; }
        public bool CheckOff5 { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public int OprSeq { get; set; }
        public string ResourceID { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string RevisionNum { get; set; }
        public decimal MaterialMtlCost { get; set; }
        public decimal MaterialLabCost { get; set; }
        public decimal MaterialSubCost { get; set; }
        public decimal MaterialBurCost { get; set; }
        public bool ReqDMR { get; set; }
        public string VendRMANum { get; set; }
        public string TranDocTypeID { get; set; }
        public string LegalNumber { get; set; }
        public byte[] SysRevID { get; set; }
        public System.Guid SysRowID { get; set; }
        public string Plant { get; set; }
        public int PONum { get; set; }
        public bool EpicorFSA { get; set; }
        public int RMANum { get; set; }
        public int RMALine { get; set; }
        public string Character01 { get; set; }
        public string Character02 { get; set; }
        public string Character03 { get; set; }
        public Nullable<System.Guid> ForeignSysRowID { get; set; }
        public byte[] UD_SysRevID { get; set; }
    }
}
