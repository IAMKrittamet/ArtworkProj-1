//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ART_WF_MOCKUP_PROCESS_PG_SELECT_VENDOR
    {
        public int PG_SELECT_VENDOR_ID { get; set; }
        public int MOCKUP_ID { get; set; }
        public int MOCKUP_SUB_ID { get; set; }
        public int VENDOR_ID { get; set; }
        public int USER_ID { get; set; }
        public Nullable<int> REASON_ID { get; set; }
        public string ACTION_CODE { get; set; }
        public string REMARK { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public int CREATE_BY { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_BY { get; set; }
    }
}
