//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_instancegroup {
    
    
    // Id: InstanceGroup Namespace: cloud.instancegroup
    public class InstanceGroup {
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: instance_ids Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instance_ids")]
        public string[] Instance_ids { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: type Type: cloud.instancegroup.InstanceGroupTypeEnum FullType: cloud.instancegroup.InstanceGroupTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _cloud_instancegroup.InstanceGroupTypeEnum Type { get; set; }//;
    }
    
    // Id: InstanceGroupTypeEnum Namespace: cloud.instancegroup
    public enum InstanceGroupTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("affinity")]
        affinity,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("anti-affinity")]
        anti_affinity,
    }
}
