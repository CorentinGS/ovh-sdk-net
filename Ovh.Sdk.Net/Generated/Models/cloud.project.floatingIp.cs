//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_project_floatingIp {
    
    
    // Id: AssociatedEntity Namespace: cloud.project.floatingIp
    public class AssociatedEntity {
        
        // Key: gatewayId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gatewayId")]
        public System.Guid GatewayId { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public string Ip { get; set; }//;
        
        // Key: type Type: cloud.project.floatingIp.associatedEntity.TypeEnum FullType: cloud.project.floatingIp.associatedEntity.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _cloud_project_floatingIp_associatedEntity.TypeEnum Type { get; set; }//;
    }
    
    // Id: StatusEnum Namespace: cloud.project.floatingIp
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("active")]
        active,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("down")]
        down,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
    }
}
