//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _order_catalog_dedicated_Metadata {
    
    
    // Id: Capacities Namespace: order.catalog.dedicated.Metadata
    public class Capacities {
        
        // Key: max Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("max")]
        public long Max { get; set; }//;
        
        // Key: min Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("min")]
        public long Min { get; set; }//;
    }
    
    // Id: Currency Namespace: order.catalog.dedicated.Metadata
    public class Currency {
        
        // Key: code Type: order.CurrencyCodeEnum FullType: order.CurrencyCodeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public _order.CurrencyCodeEnum Code { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: symbol Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("symbol")]
        public string Symbol { get; set; }//;
    }
    
    // Id: Frequency Namespace: order.catalog.dedicated.Metadata
    public class Frequency {
        
        // Key: max Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("max")]
        public double Max { get; set; }//;
        
        // Key: min Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("min")]
        public double Min { get; set; }//;
    }
    
    // Id: Price Namespace: order.catalog.dedicated.Metadata
    public class Price {
        
        // Key: max Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("max")]
        public double Max { get; set; }//;
        
        // Key: min Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("min")]
        public double Min { get; set; }//;
    }
}
