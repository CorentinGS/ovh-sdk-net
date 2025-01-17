//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_ip {
    
    
    // Id: CloudIp Namespace: cloud.ip
    public class CloudIp {
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: ip Type: ipBlock FullType: ipBlock
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.String? Ip { get; set; }//;
        
        // Key: status Type: cloud.ip.IpStatusEnum FullType: cloud.ip.IpStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_ip.IpStatusEnum Status { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: FailoverIp Namespace: cloud.ip
    public class FailoverIp {
        
        // Key: block Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("block")]
        public System.String? Block { get; set; }//;
        
        // Key: continentCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("continentCode")]
        public System.String? ContinentCode { get; set; }//;
        
        // Key: geoloc Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("geoloc")]
        public System.String? Geoloc { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.String? Ip { get; set; }//;
        
        // Key: progress Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("progress")]
        public long Progress { get; set; }//;
        
        // Key: routedTo Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("routedTo")]
        public string RoutedTo { get; set; }//;
        
        // Key: status Type: cloud.ip.IpStatusEnum FullType: cloud.ip.IpStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_ip.IpStatusEnum Status { get; set; }//;
        
        // Key: subType Type: cloud.ip.IpSubTypeEnum FullType: cloud.ip.IpSubTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subType")]
        public _cloud_ip.IpSubTypeEnum SubType { get; set; }//;
    }
    
    // Id: IpStatusEnum Namespace: cloud.ip
    public enum IpStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ok")]
        ok,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operationPending")]
        operationPending,
    }
    
    // Id: IpSubTypeEnum Namespace: cloud.ip
    public enum IpSubTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cloud")]
        cloud,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ovh")]
        ovh,
    }
}
