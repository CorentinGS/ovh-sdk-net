//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _dedicatedCloud_option {
    
    
    // Id: DatacenterOptionState Namespace: dedicatedCloud.option
    public class DatacenterOptionState {
        
        // Key: id Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: state Type: dedicatedCloud.option.StateEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _dedicatedCloud_option.StateEnum State { get; set; }//;
    }
    
    // Id: StateEnum Namespace: dedicatedCloud.option
    public enum StateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disabled")]
        disabled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disabling")]
        disabling,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabled")]
        enabled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabling")]
        enabling,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migrating")]
        migrating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unknown")]
        unknown,
    }
}