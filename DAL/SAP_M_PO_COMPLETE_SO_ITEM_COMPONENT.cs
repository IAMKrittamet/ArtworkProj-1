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
    
    public partial class SAP_M_PO_COMPLETE_SO_ITEM_COMPONENT
    {
        public int PO_COMPLETE_SO_ITEM_COMPONENT_ID { get; set; }
        public int PO_COMPLETE_SO_ITEM_ID { get; set; }
        public string COMPONENT_ITEM { get; set; }
        public string COMPONENT_MATERIAL { get; set; }
        public string DECRIPTION { get; set; }
        public Nullable<decimal> QUANTITY { get; set; }
        public string UNIT { get; set; }
        public string STOCK { get; set; }
        public string BOM_ITEM_CUSTOM_1 { get; set; }
        public string BOM_ITEM_CUSTOM_2 { get; set; }
        public string BOM_ITEM_CUSTOM_3 { get; set; }
        public string IS_ACTIVE { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public int CREATE_BY { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_BY { get; set; }
        public string IS_ASSIGN { get; set; }
    }
}