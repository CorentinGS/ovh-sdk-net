//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _ipLoadbalancing_frontendHttp {
    
    
    // Id: FrontendHttp Namespace: ipLoadbalancing.frontendHttp
    public class FrontendHttp {
        
        // Key: allowedSource Type: ipBlock[] FullType: ipBlock[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("allowedSource")]
        public System.String[]? AllowedSource { get; set; }//;
        
        // Key: dedicatedIpfo Type: ipBlock[] FullType: ipBlock[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dedicatedIpfo")]
        public System.String[]? DedicatedIpfo { get; set; }//;
        
        // Key: defaultFarmId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultFarmId")]
        public System.Int64? DefaultFarmId { get; set; }//;
        
        // Key: defaultSslId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultSslId")]
        public System.Int64? DefaultSslId { get; set; }//;
        
        // Key: deniedSource Type: ipBlock[] FullType: ipBlock[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deniedSource")]
        public System.String[]? DeniedSource { get; set; }//;
        
        // Key: disabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disabled")]
        public bool Disabled { get; set; }//;
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public System.String? DisplayName { get; set; }//;
        
        // Key: frontendId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("frontendId")]
        public long FrontendId { get; set; }//;
        
        // Key: hsts Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hsts")]
        public bool Hsts { get; set; }//;
        
        // Key: httpHeader Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("httpHeader")]
        public System.String[]? HttpHeader { get; set; }//;
        
        // Key: port Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public string Port { get; set; }//;
        
        // Key: redirectLocation Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("redirectLocation")]
        public System.String? RedirectLocation { get; set; }//;
        
        // Key: ssl Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssl")]
        public bool Ssl { get; set; }//;
        
        // Key: vrackNetworkId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackNetworkId")]
        public System.Int64? VrackNetworkId { get; set; }//;
        
        // Key: vrackVrouterId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackVrouterId")]
        public System.Int64? VrackVrouterId { get; set; }//;
        
        // Key: zone Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zone")]
        public string Zone { get; set; }//;
    }
}
