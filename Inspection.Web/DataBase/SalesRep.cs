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
    
    public partial class SalesRep
    {
        public bool InActive { get; set; }
        public string Company { get; set; }
        public string SalesRepCode { get; set; }
        public string Name { get; set; }
        public decimal CommissionPercent { get; set; }
        public bool CommissionEarnedAt { get; set; }
        public bool AlertFlag { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int CountryNum { get; set; }
        public string OfficePhoneNum { get; set; }
        public string FaxPhoneNum { get; set; }
        public string CellPhoneNum { get; set; }
        public string PagerNum { get; set; }
        public string HomePhoneNum { get; set; }
        public string EMailAddress { get; set; }
        public string SalesRepTitle { get; set; }
        public string RepReportsTo { get; set; }
        public string Comment { get; set; }
        public int SalesMgrConfidence { get; set; }
        public string RoleCode { get; set; }
        public bool ViewAllTer { get; set; }
        public bool ViewCompPipe { get; set; }
        public bool WebSaleGetsCommission { get; set; }
        public string CnvEmpID { get; set; }
        public int PerConID { get; set; }
        public bool SyncNameToPerCon { get; set; }
        public bool SyncAddressToPerCon { get; set; }
        public bool SyncPhoneToPerCon { get; set; }
        public bool SyncEmailToPerCon { get; set; }
        public bool SyncLinksToPerCon { get; set; }
        public string WebSite { get; set; }
        public string IM { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public string FaceBook { get; set; }
        public string WebLink1 { get; set; }
        public string WebLink2 { get; set; }
        public string WebLink3 { get; set; }
        public string WebLink4 { get; set; }
        public string WebLink5 { get; set; }
        public int MgrWorstCsPct { get; set; }
        public int MgrBestCsPct { get; set; }
        public byte[] SysRevID { get; set; }
        public System.Guid SysRowID { get; set; }
        public bool WebSalesRep { get; set; }
        public string ECCSalesRepCode { get; set; }
        public string Character01 { get; set; }
        public Nullable<bool> CheckBox06 { get; set; }
        public Nullable<bool> CheckBox07 { get; set; }
        public Nullable<System.Guid> ForeignSysRowID { get; set; }
        public byte[] UD_SysRevID { get; set; }
        public Nullable<System.DateTime> CreationDate_c { get; set; }
        public string PrimarySalesRepEmail_c { get; set; }
    }
}
