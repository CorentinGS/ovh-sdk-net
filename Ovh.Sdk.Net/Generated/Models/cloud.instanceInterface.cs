//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_instanceInterface {
    
    
    // Id: FixedIp Namespace: cloud.instanceInterface
    public class FixedIp {
        
        // Key: ip Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public string Ip { get; set; }//;
        
        // Key: subnetId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subnetId")]
        public string SubnetId { get; set; }//;
    }
    
    // Id: Interface Namespace: cloud.instanceInterface
    public class Interface {
        
        // Key: fixedIps Type: cloud.instanceInterface.FixedIp[] FullType: cloud.instanceInterface.FixedIp[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fixedIps")]
        public _cloud_instanceInterface.FixedIp[] FixedIps { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: macAddress Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("macAddress")]
        public string MacAddress { get; set; }//;
        
        // Key: networkId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("networkId")]
        public string NetworkId { get; set; }//;
        
        // Key: state Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public string State { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
}