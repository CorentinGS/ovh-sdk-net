//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cdn_domain_add {
    
    
    // Id: option Namespace: cdn.domain.add
    public class option {
        
        // Key: config Type: cdn.domain.option.config FullType: cdn.domain.option.config
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("config")]
        public _cdn_domain_option.config? Config { get; set; }//;
        
        // Key: enabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabled")]
        public bool Enabled { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: pattern Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pattern")]
        public System.String? Pattern { get; set; }//;
        
        // Key: type Type: cdn.OptionTypePostEnum FullType: cdn.OptionTypePostEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _cdn.OptionTypePostEnum Type { get; set; }//;
    }
}
