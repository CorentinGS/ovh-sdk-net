//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _domain_glueRecord {
    
    
    // Id: CreatePayload Namespace: domain.glueRecord
    public class CreatePayload {
        
        // Key: host Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("host")]
        public string Host { get; set; }//;
        
        // Key: ips Type: ip[] FullType: ip[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ips")]
        public string[] Ips { get; set; }//;
    }
    
    // Id: GlueRecord Namespace: domain.glueRecord
    public class GlueRecord {
        
        // Key: host Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("host")]
        public string Host { get; set; }//;
        
        // Key: ips Type: ip[] FullType: ip[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ips")]
        public string[] Ips { get; set; }//;
    }
}
