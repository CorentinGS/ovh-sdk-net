//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_authentication {
    
    
    // Id: Catalog Namespace: cloud.authentication
    public class Catalog {
        
        // Key: endpoints Type: cloud.authentication.Endpoint[] FullType: cloud.authentication.Endpoint[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endpoints")]
        public _cloud_authentication.Endpoint[] Endpoints { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: Domain Namespace: cloud.authentication
    public class Domain {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: Endpoint Namespace: cloud.authentication
    public class Endpoint {
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: interface Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interface")]
        public string @interface { get; set; }//;
        
        // Key: legacy_endpoint_id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("legacy_endpoint_id")]
        public string Legacy_endpoint_id { get; set; }//;
        
        // Key: region_id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region_id")]
        public string Region_id { get; set; }//;
        
        // Key: service_id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("service_id")]
        public string Service_id { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public string Url { get; set; }//;
    }
    
    // Id: OpenstackToken Namespace: cloud.authentication
    public class OpenstackToken {
        
        // Key: catalog Type: cloud.authentication.Catalog[] FullType: cloud.authentication.Catalog[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("catalog")]
        public _cloud_authentication.Catalog[] Catalog { get; set; }//;
        
        // Key: expires_at Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expires_at")]
        public System.DateTime Expires_at { get; set; }//;
        
        // Key: issued_at Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("issued_at")]
        public System.DateTime Issued_at { get; set; }//;
        
        // Key: methods Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("methods")]
        public string[] Methods { get; set; }//;
        
        // Key: project Type: cloud.authentication.TokenProject FullType: cloud.authentication.TokenProject
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("project")]
        public _cloud_authentication.TokenProject Project { get; set; }//;
        
        // Key: roles Type: cloud.authentication.Role[] FullType: cloud.authentication.Role[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("roles")]
        public _cloud_authentication.Role[] Roles { get; set; }//;
        
        // Key: user Type: cloud.authentication.UserToken FullType: cloud.authentication.UserToken
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public _cloud_authentication.UserToken User { get; set; }//;
    }
    
    // Id: Role Namespace: cloud.authentication
    public class Role {
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: Token Namespace: cloud.authentication
    public class Token {
        
        // Key: X-Auth-Token Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("X-Auth-Token")]
        public string X_Auth_Token { get; set; }//;
        
        // Key: token Type: cloud.authentication.OpenstackToken FullType: cloud.authentication.OpenstackToken
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("token")]
        public _cloud_authentication.OpenstackToken _Token { get; set; }//;
    }
    
    // Id: TokenProject Namespace: cloud.authentication
    public class TokenProject {
        
        // Key: domain Type: cloud.authentication.Domain FullType: cloud.authentication.Domain
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public _cloud_authentication.Domain Domain { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: UserToken Namespace: cloud.authentication
    public class UserToken {
        
        // Key: domain Type: cloud.authentication.Domain FullType: cloud.authentication.Domain
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public _cloud_authentication.Domain Domain { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
}