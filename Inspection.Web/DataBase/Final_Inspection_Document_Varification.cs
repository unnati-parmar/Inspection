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
    
    public partial class Final_Inspection_Document_Varification
    {
        public int ID { get; set; }
        public int IID { get; set; }
        public int DocumentID { get; set; }
        public string Comments { get; set; }
        public string Passfail { get; set; }
        public string AfterCorrectionpassfail { get; set; }
        public Nullable<System.DateTime> CurrentDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Delete { get; set; }
    }
}
