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
    
    public partial class tblCityStatesCounty
    {
        public int CityID { get; set; }
        public int StateID { get; set; }
        public int COUNTRYID { get; set; }
        public string CityEnglish { get; set; }
        public string CityArabic { get; set; }
        public string CityOther { get; set; }
        public string LandLine { get; set; }
        public string ACTIVE1 { get; set; }
        public string ACTIVE2 { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
        public string AssignedRoute { get; set; }
        public string SHORTCODE { get; set; }
        public string ZONE { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Uploadby { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public string Syncby { get; set; }
        public Nullable<int> SynID { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}
