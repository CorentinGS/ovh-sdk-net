//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _hosting_PrivateDatabase_Configuration {
    
    
    // Id: Detail Namespace: hosting.PrivateDatabase.Configuration
    public class Detail {
        
        // Key: availableValues Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availableValues")]
        public string[] AvailableValues { get; set; }//;
        
        // Key: defaultValue Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultValue")]
        public string DefaultValue { get; set; }//;
        
        // Key: description Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: key Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("key")]
        public string Key { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime LastUpdate { get; set; }//;
        
        // Key: type Type: hosting.PrivateDatabase.Configuration.DetailType FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _hosting_PrivateDatabase_Configuration.DetailType Type { get; set; }//;
        
        // Key: unit Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unit")]
        public string Unit { get; set; }//;
        
        // Key: value Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public string Value { get; set; }//;
    }
    
    // Id: DetailType Namespace: hosting.PrivateDatabase.Configuration
    public enum DetailType {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("boolean")]
        boolean,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        number,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("string")]
        @string,
    }
    
    // Id: Status Namespace: hosting.PrivateDatabase.Configuration
    public enum Status {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("applied")]
        applied,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updating")]
        updating,
    }
}