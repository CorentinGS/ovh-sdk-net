//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _ipLoadbalancing_Frontend {
    
    
    // Id: Frontend Namespace: ipLoadbalancing.Frontend
    public class Frontend {
        
        // Key: allowedSource Type: ipBlock[] FullType: ipBlock[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("allowedSource")]
        public System.String[]? AllowedSource { get; set; }//;
        
        // Key: dedicatedIpfo Type: ipBlock[] FullType: ipBlock[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedIpfo")]
        public System.String[]? DedicatedIpfo { get; set; }//;
        
        // Key: defaultBackendId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultBackendId")]
        public System.Int64? DefaultBackendId { get; set; }//;
        
        // Key: defaultSslId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultSslId")]
        public System.Int64? DefaultSslId { get; set; }//;
        
        // Key: deniedSource Type: ipBlock[] FullType: ipBlock[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deniedSource")]
        public System.String[]? DeniedSource { get; set; }//;
        
        // Key: disabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disabled")]
        public bool Disabled { get; set; }//;
        
        // Key: hsts Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hsts")]
        public bool Hsts { get; set; }//;
        
        // Key: httpHeader Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("httpHeader")]
        public System.String[]? HttpHeader { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: port Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public string Port { get; set; }//;
        
        // Key: redirectLocation Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("redirectLocation")]
        public System.String? RedirectLocation { get; set; }//;
        
        // Key: ssl Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssl")]
        public bool Ssl { get; set; }//;
        
        // Key: type Type: ipLoadbalancing.ProxyTypeEnum FullType: ipLoadbalancing.ProxyTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _ipLoadbalancing.ProxyTypeEnum Type { get; set; }//;
        
        // Key: zone Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zone")]
        public string Zone { get; set; }//;
    }
}
