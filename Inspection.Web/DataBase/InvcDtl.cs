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
    
    public partial class InvcDtl
    {
        public string Company { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public string LineType { get; set; }
        public int ContractNum { get; set; }
        public string XPartNum { get; set; }
        public string XRevisionNum { get; set; }
        public string PartNum { get; set; }
        public string LineDesc { get; set; }
        public string IUM { get; set; }
        public string RevisionNum { get; set; }
        public string POLine { get; set; }
        public string TaxExempt { get; set; }
        public string TaxCatID { get; set; }
        public bool Commissionable { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DocUnitPrice { get; set; }
        public string PricePerCode { get; set; }
        public decimal OurOrderQty { get; set; }
        public decimal ExtPrice { get; set; }
        public decimal DocExtPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal DocDiscount { get; set; }
        public decimal TotalMiscChrg { get; set; }
        public decimal DocTotalMiscChrg { get; set; }
        public string ProdCode { get; set; }
        public decimal OurShipQty { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public int ShipToCustNum { get; set; }
        public string ShipToNum { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public string ShipViaCode { get; set; }
        public decimal AdvanceBillCredit { get; set; }
        public decimal DocAdvanceBillCredit { get; set; }
        public int CustNum { get; set; }
        public string InvoiceComment { get; set; }
        public int ShpConNum { get; set; }
        public decimal MtlUnitCost { get; set; }
        public decimal LbrUnitCost { get; set; }
        public decimal BurUnitCost { get; set; }
        public decimal SubUnitCost { get; set; }
        public decimal MtlBurUnitCost { get; set; }
        public bool COSPostingReqd { get; set; }
        public bool COSPosted { get; set; }
        public string ContractCode { get; set; }
        public int CallNum { get; set; }
        public string CallCode { get; set; }
        public int RMANum { get; set; }
        public int RMALine { get; set; }
        public string SalesCatID { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string JournalCode { get; set; }
        public int JournalNum { get; set; }
        public decimal SellingOrderQty { get; set; }
        public decimal SellingShipQty { get; set; }
        public string SalesUM { get; set; }
        public decimal SellingFactor { get; set; }
        public string ProjectID { get; set; }
        public string MilestoneID { get; set; }
        public decimal ListPrice { get; set; }
        public decimal DocListPrice { get; set; }
        public decimal OrdBasedPrice { get; set; }
        public decimal DocOrdBasedPrice { get; set; }
        public decimal AdvGainLoss { get; set; }
        public string SellingFactorDirection { get; set; }
        public decimal RepRate1 { get; set; }
        public decimal RepRate2 { get; set; }
        public decimal RepRate3 { get; set; }
        public decimal RepRate4 { get; set; }
        public decimal RepRate5 { get; set; }
        public int RepSplit1 { get; set; }
        public int RepSplit2 { get; set; }
        public int RepSplit3 { get; set; }
        public int RepSplit4 { get; set; }
        public int RepSplit5 { get; set; }
        public int BTCustNum { get; set; }
        public decimal JCMtlUnitCost { get; set; }
        public decimal JCLbrUnitCost { get; set; }
        public decimal JCBurUnitCost { get; set; }
        public decimal JCSubUnitCost { get; set; }
        public decimal JCMtlBurUnitCost { get; set; }
        public string ChangedBy { get; set; }
        public Nullable<System.DateTime> ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public string RevChargeMethod { get; set; }
        public bool OverrideReverseCharge { get; set; }
        public bool RevChargeApplied { get; set; }
        public bool TaxConnectCalc { get; set; }
        public bool GetDfltTaxIds { get; set; }
        public decimal Rpt1AdvanceBillCredit { get; set; }
        public decimal Rpt2AdvanceBillCredit { get; set; }
        public decimal Rpt3AdvanceBillCredit { get; set; }
        public decimal Rpt1Discount { get; set; }
        public decimal Rpt2Discount { get; set; }
        public decimal Rpt3Discount { get; set; }
        public decimal Rpt1ExtPrice { get; set; }
        public decimal Rpt2ExtPrice { get; set; }
        public decimal Rpt3ExtPrice { get; set; }
        public decimal Rpt1ListPrice { get; set; }
        public decimal Rpt2ListPrice { get; set; }
        public decimal Rpt3ListPrice { get; set; }
        public decimal Rpt1OrdBasedPrice { get; set; }
        public decimal Rpt2OrdBasedPrice { get; set; }
        public decimal Rpt3OrdBasedPrice { get; set; }
        public decimal Rpt1TotalMiscChrg { get; set; }
        public decimal Rpt2TotalMiscChrg { get; set; }
        public decimal Rpt3TotalMiscChrg { get; set; }
        public decimal Rpt1UnitPrice { get; set; }
        public decimal Rpt2UnitPrice { get; set; }
        public decimal Rpt3UnitPrice { get; set; }
        public decimal Rpt1AdvGainLoss { get; set; }
        public decimal Rpt2AdvGainLoss { get; set; }
        public decimal Rpt3AdvGainLoss { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarID { get; set; }
        public string TaxRegionCode { get; set; }
        public bool UseOTS { get; set; }
        public string OTSName { get; set; }
        public string OTSAddress1 { get; set; }
        public string OTSAddress2 { get; set; }
        public string OTSAddress3 { get; set; }
        public string OTSCity { get; set; }
        public string OTSState { get; set; }
        public string OTSZIP { get; set; }
        public string OTSResaleID { get; set; }
        public string OTSTaxRegionCode { get; set; }
        public string OTSContact { get; set; }
        public string OTSFaxNum { get; set; }
        public string OTSPhoneNum { get; set; }
        public int OTSCountryNum { get; set; }
        public string Plant { get; set; }
        public string WarehouseCode { get; set; }
        public int CallLine { get; set; }
        public int DropShipPackLine { get; set; }
        public string DropShipPackSlip { get; set; }
        public string FinChargeCode { get; set; }
        public string ABTUID { get; set; }
        public decimal InUnitPrice { get; set; }
        public decimal DocInUnitPrice { get; set; }
        public decimal InExtPrice { get; set; }
        public decimal DocInExtPrice { get; set; }
        public decimal InDiscount { get; set; }
        public decimal DocInDiscount { get; set; }
        public decimal InTotalMiscChrg { get; set; }
        public decimal DocInTotalMiscChrg { get; set; }
        public decimal InListPrice { get; set; }
        public decimal DocInListPrice { get; set; }
        public decimal InOrdBasedPrice { get; set; }
        public decimal DocInOrdBasedPrice { get; set; }
        public decimal Rpt1InDiscount { get; set; }
        public decimal Rpt2InDiscount { get; set; }
        public decimal Rpt3InDiscount { get; set; }
        public decimal Rpt1InExtPrice { get; set; }
        public decimal Rpt2InExtPrice { get; set; }
        public decimal Rpt3InExtPrice { get; set; }
        public decimal Rpt1InListPrice { get; set; }
        public decimal Rpt2InListPrice { get; set; }
        public decimal Rpt3InListPrice { get; set; }
        public decimal Rpt1InOrdBasedPrice { get; set; }
        public decimal Rpt2InOrdBasedPrice { get; set; }
        public decimal Rpt3InOrdBasedPrice { get; set; }
        public decimal Rpt1InTotalMiscChrg { get; set; }
        public decimal Rpt2InTotalMiscChrg { get; set; }
        public decimal Rpt3InTotalMiscChrg { get; set; }
        public decimal Rpt1InUnitPrice { get; set; }
        public decimal Rpt2InUnitPrice { get; set; }
        public decimal Rpt3InUnitPrice { get; set; }
        public bool CorrectionDtl { get; set; }
        public string AssetNum { get; set; }
        public int DisposalNum { get; set; }
        public string IncomeTaxCode { get; set; }
        public string PBLineType { get; set; }
        public int InvoiceLineRef { get; set; }
        public int InvoiceRef { get; set; }
        public string LotNum { get; set; }
        public int PBInvoiceLine { get; set; }
        public decimal RAID { get; set; }
        public decimal RADtlID { get; set; }
        public bool DeferredRev { get; set; }
        public string RACode { get; set; }
        public Nullable<System.DateTime> DefRevStart { get; set; }
        public bool ChargeDefRev { get; set; }
        public int RenewalNbr { get; set; }
        public byte[] SysRevID { get; set; }
        public System.Guid SysRowID { get; set; }
        public bool DefRevPosted { get; set; }
        public decimal LinkedInvcUnitPrice { get; set; }
        public decimal DspWithholdAmt { get; set; }
        public decimal DocDspWithholdAmt { get; set; }
        public decimal Rpt1DspWithholdAmt { get; set; }
        public decimal Rpt2DspWithholdAmt { get; set; }
        public decimal Rpt3DspWithholdAmt { get; set; }
        public string LinkedCurrencyCode { get; set; }
        public string PhaseID { get; set; }
        public int PEBOEHeadNum { get; set; }
        public decimal MXSellingShipQty { get; set; }
        public decimal MXUnitPrice { get; set; }
        public decimal DocMXUnitPrice { get; set; }
        public decimal Rpt1MXUnitPrice { get; set; }
        public decimal Rpt2MXUnitPrice { get; set; }
        public decimal Rpt3MXUnitPrice { get; set; }
        public string CustCostCenter { get; set; }
        public bool DEIsServices { get; set; }
        public bool DEIsSecurityFinancialDerivative { get; set; }
        public string DEInternationalSecuritiesID { get; set; }
        public bool DEIsInvestment { get; set; }
        public string DEPayStatCode { get; set; }
        public Nullable<System.DateTime> DefRevEndDate { get; set; }
        public string EntityUseCode { get; set; }
        public bool Reclassified { get; set; }
        public bool PartiallyDefer { get; set; }
        public decimal DeferredPercent { get; set; }
        public bool Reclass { get; set; }
        public bool DeferredOnly { get; set; }
        public string ReclassCodeID { get; set; }
        public string ReclassReasonCode { get; set; }
        public string ReclassComments { get; set; }
        public decimal DeferredRevAmt { get; set; }
        public decimal DocDeferredRevAmt { get; set; }
        public decimal Rpt1DeferredRevAmt { get; set; }
        public decimal Rpt2DeferredRevAmt { get; set; }
        public decimal Rpt3DeferredRevAmt { get; set; }
        public bool ChargeReclass { get; set; }
        public string DEDenomination { get; set; }
        public int DropShipPONum { get; set; }
        public decimal DocInAdvanceBillCredit { get; set; }
        public decimal InAdvanceBillCredit { get; set; }
        public decimal Rpt1InAdvanceBillCredit { get; set; }
        public decimal Rpt2InAdvanceBillCredit { get; set; }
        public decimal Rpt3InAdvanceBillCredit { get; set; }
        public string MYIndustryCode { get; set; }
        public string DockingStation { get; set; }
        public bool ConsolidateLines { get; set; }
        public string MXCustomsDuty { get; set; }
        public string CommodityCode { get; set; }
        public string MXProdServCode { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public bool EpicorFSA { get; set; }
        public string MXCustomsUMFrom { get; set; }
    }
}
