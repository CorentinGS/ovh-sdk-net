//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_project_ai_registry {
    
    
    // Id: Registry Namespace: cloud.project.ai.registry
    public class Registry {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: password Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public string Password { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public System.DateTime UpdatedAt { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public string Url { get; set; }//;
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public string User { get; set; }//;
        
        // Key: username Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("username")]
        public string Username { get; set; }//;
    }
    
    // Id: RegistryUpdateInput Namespace: cloud.project.ai.registry
    public class RegistryUpdateInput {
        
        // Key: password Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public string Password { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public string Url { get; set; }//;
        
        // Key: username Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("username")]
        public string Username { get; set; }//;
    }
}