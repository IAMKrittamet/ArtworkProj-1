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
    
    public partial class ART_WF_ARTWORK_PROCESS_ASSIGN_SO_ITEM
    {
        public int ASSIGN_SO_ITEM_ID { get; set; }
        public int ASSIGN_SO_HEADER_ID { get; set; }
        public int ARTWORK_PROCESS_SO_ID { get; set; }
        public int ARTWORK_REQUEST_ID { get; set; }
        public int ARTWORK_SUB_ID { get; set; }
        public Nullable<decimal> ITEM { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string MATERIAL_DESCRIPTION { get; set; }
        public string NET_WEIGHT { get; set; }
        public Nullable<decimal> ORDER_QTY { get; set; }
        public string ORDER_UNIT { get; set; }
        public Nullable<System.DateTime> ETD_DATE_FROM { get; set; }
        public Nullable<System.DateTime> ETD_DATE_TO { get; set; }
        public string PLANT { get; set; }
        public string OLD_MATERIAL_CODE { get; set; }
        public string PACK_SIZE { get; set; }
        public string VALUME_PER_UNIT { get; set; }
        public string VALUME_UNIT { get; set; }
        public string SIZE_DRAIN_WT { get; set; }
        public string PROD_INSP_MEMO { get; set; }
        public string REJECTION_CODE { get; set; }
        public string REJECTION_DESCRIPTION { get; set; }
        public string PORT { get; set; }
        public string VIA { get; set; }
        public string IN_TRANSIT_TO { get; set; }
        public string BRAND_ID { get; set; }
        public string BRAND_DESCRIPTION { get; set; }
        public string ADDITIONAL_BRAND_ID { get; set; }
        public string ADDITIONAL_BRAND_DESCRIPTION { get; set; }
        public string PRODUCTION_PLANT { get; set; }
        public string ZONE { get; set; }
        public string COUNTRY { get; set; }
        public string PRODUCTION_HIERARCHY { get; set; }
        public string MRP_CONTROLLER { get; set; }
        public string STOCK { get; set; }
        public string ITEM_CUSTOM_1 { get; set; }
        public string ITEM_CUSTOM_2 { get; set; }
        public string ITEM_CUSTOM_3 { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public int CREATE_BY { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_BY { get; set; }
    }
}
