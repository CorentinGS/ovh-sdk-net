//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _order_catalog_dedicated_TechDetails {
    
    
    // Id: Plan Namespace: order.catalog.dedicated.TechDetails
    public class Plan {
        
        // Key: code Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public string Code { get; set; }//;
        
        // Key: specificities Type: order.catalog.dedicated.TechDetails.Plan.Specificity[] FullType: order.catalog.dedicated.TechDetails.Plan.Specificity[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("specificities")]
        public _order_catalog_dedicated_TechDetails_Plan.Specificity[] Specificities { get; set; }//;
    }
}
