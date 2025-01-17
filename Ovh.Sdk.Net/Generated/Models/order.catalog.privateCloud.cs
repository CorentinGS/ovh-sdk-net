//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _order_catalog_privateCloud {
    
    
    // Id: Capabilities Namespace: order.catalog.privateCloud
    public class Capabilities {
        
        // Key: hds Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hds")]
        public bool Hds { get; set; }//;
        
        // Key: hipaa Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hipaa")]
        public bool Hipaa { get; set; }//;
        
        // Key: nsx Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nsx")]
        public bool Nsx { get; set; }//;
        
        // Key: pcidss Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pcidss")]
        public bool Pcidss { get; set; }//;
        
        // Key: vrops Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrops")]
        public bool Vrops { get; set; }//;
    }
    
    // Id: CapabilitiesListing Namespace: order.catalog.privateCloud
    public class CapabilitiesListing {
        
        // Key: 2016v1 Type: order.catalog.privateCloud.Capabilities FullType: order.catalog.privateCloud.Capabilities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2016v1")]
        public _order_catalog_privateCloud.Capabilities _2016v1 { get; set; }//;
        
        // Key: 2016v2 Type: order.catalog.privateCloud.Capabilities FullType: order.catalog.privateCloud.Capabilities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2016v2")]
        public _order_catalog_privateCloud.Capabilities _2016v2 { get; set; }//;
        
        // Key: 2016v3 Type: order.catalog.privateCloud.Capabilities FullType: order.catalog.privateCloud.Capabilities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2016v3")]
        public _order_catalog_privateCloud.Capabilities _2016v3 { get; set; }//;
        
        // Key: 2016v4 Type: order.catalog.privateCloud.Capabilities FullType: order.catalog.privateCloud.Capabilities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2016v4")]
        public _order_catalog_privateCloud.Capabilities _2016v4 { get; set; }//;
        
        // Key: 2016v5 Type: order.catalog.privateCloud.Capabilities FullType: order.catalog.privateCloud.Capabilities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2016v5")]
        public _order_catalog_privateCloud.Capabilities _2016v5 { get; set; }//;
        
        // Key: 2016v6 Type: order.catalog.privateCloud.Capabilities FullType: order.catalog.privateCloud.Capabilities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2016v6")]
        public _order_catalog_privateCloud.Capabilities _2016v6 { get; set; }//;
        
        // Key: 2016v7 Type: order.catalog.privateCloud.Capabilities FullType: order.catalog.privateCloud.Capabilities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("2016v7")]
        public _order_catalog_privateCloud.Capabilities _2016v7 { get; set; }//;
        
        // Key: default Type: order.catalog.privateCloud.Capabilities FullType: order.catalog.privateCloud.Capabilities
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("default")]
        public _order_catalog_privateCloud.Capabilities @default { get; set; }//;
    }
    
    // Id: Catalog Namespace: order.catalog.privateCloud
    public class Catalog {
        
        // Key: catalogId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("catalogId")]
        public long CatalogId { get; set; }//;
        
        // Key: catalogName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("catalogName")]
        public string CatalogName { get; set; }//;
        
        // Key: defaultHypervisor Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultHypervisor")]
        public string DefaultHypervisor { get; set; }//;
        
        // Key: defaultZone Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultZone")]
        public string DefaultZone { get; set; }//;
        
        // Key: merchantCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("merchantCode")]
        public string MerchantCode { get; set; }//;
        
        // Key: options Type: order.catalog.privateCloud.CapabilitiesListing FullType: order.catalog.privateCloud.CapabilitiesListing
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("options")]
        public _order_catalog_privateCloud.CapabilitiesListing Options { get; set; }//;
        
        // Key: zones Type: order.catalog.privateCloud.ZonesListing FullType: order.catalog.privateCloud.ZonesListing
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zones")]
        public _order_catalog_privateCloud.ZonesListing Zones { get; set; }//;
    }
    
    // Id: Zone Namespace: order.catalog.privateCloud
    public class Zone {
        
        // Key: cityName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cityName")]
        public string CityName { get; set; }//;
        
        // Key: country Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("country")]
        public string Country { get; set; }//;
        
        // Key: defaultHypervisor Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultHypervisor")]
        public string DefaultHypervisor { get; set; }//;
        
        // Key: defaultVersion Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultVersion")]
        public string DefaultVersion { get; set; }//;
        
        // Key: internalName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internalName")]
        public string InternalName { get; set; }//;
        
        // Key: plans Type: order.catalog.ProductPlan[] FullType: order.catalog.ProductPlan[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plans")]
        public _order_catalog.ProductPlan[] Plans { get; set; }//;
    }
    
    // Id: ZonesListing Namespace: order.catalog.privateCloud
    public class ZonesListing {
        
        // Key: bhs Type: order.catalog.privateCloud.Zone FullType: order.catalog.privateCloud.Zone
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bhs")]
        public _order_catalog_privateCloud.Zone Bhs { get; set; }//;
        
        // Key: eri Type: order.catalog.privateCloud.Zone FullType: order.catalog.privateCloud.Zone
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("eri")]
        public _order_catalog_privateCloud.Zone Eri { get; set; }//;
        
        // Key: lim Type: order.catalog.privateCloud.Zone FullType: order.catalog.privateCloud.Zone
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lim")]
        public _order_catalog_privateCloud.Zone Lim { get; set; }//;
        
        // Key: rbx Type: order.catalog.privateCloud.Zone FullType: order.catalog.privateCloud.Zone
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rbx")]
        public _order_catalog_privateCloud.Zone Rbx { get; set; }//;
        
        // Key: sbg Type: order.catalog.privateCloud.Zone FullType: order.catalog.privateCloud.Zone
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sbg")]
        public _order_catalog_privateCloud.Zone Sbg { get; set; }//;
        
        // Key: waw Type: order.catalog.privateCloud.Zone FullType: order.catalog.privateCloud.Zone
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("waw")]
        public _order_catalog_privateCloud.Zone Waw { get; set; }//;
    }
}
