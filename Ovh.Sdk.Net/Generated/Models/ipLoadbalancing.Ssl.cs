//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _ipLoadbalancing_Ssl {
    
    
    // Id: Ssl Namespace: ipLoadbalancing.Ssl
    public class Ssl {
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public System.String? DisplayName { get; set; }//;
        
        // Key: expireDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expireDate")]
        public System.DateTime ExpireDate { get; set; }//;
        
        // Key: fingerprint Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fingerprint")]
        public string Fingerprint { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: san Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("san")]
        public string[] San { get; set; }//;
        
        // Key: serial Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serial")]
        public string Serial { get; set; }//;
        
        // Key: subject Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subject")]
        public string Subject { get; set; }//;
        
        // Key: type Type: ipLoadbalancing.SslTypeEnum FullType: ipLoadbalancing.SslTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _ipLoadbalancing.SslTypeEnum? Type { get; set; }//;
    }
}
