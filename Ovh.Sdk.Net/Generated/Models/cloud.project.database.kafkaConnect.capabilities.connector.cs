//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_project_database_kafkaConnect_capabilities_connector {
    
    
    // Id: Transform Namespace: cloud.project.database.kafkaConnect.capabilities.connector
    public class Transform {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public string DisplayName { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: required Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("required")]
        public bool Required { get; set; }//;
        
        // Key: transformType Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("transformType")]
        public string TransformType { get; set; }//;
        
        // Key: type Type: cloud.project.database.kafkaConnect.connector.property.TypeEnum FullType: cloud.project.database.kafkaConnect.connector.property.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _cloud_project_database_kafkaConnect_connector_property.TypeEnum Type { get; set; }//;
        
        // Key: values Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("values")]
        public System.String[]? Values { get; set; }//;
    }
    
    // Id: TypeEnum Namespace: cloud.project.database.kafkaConnect.capabilities.connector
    public enum TypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sink")]
        sink,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("source")]
        source,
    }
}
