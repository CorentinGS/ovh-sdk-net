//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _services_expanded_Renew {
    
    
    // Id: Capacities Namespace: services.expanded.Renew
    public class Capacities {
        
        // Key: mode Type: services.expanded.Renew.ModeEnum[] FullType: services.expanded.Renew.ModeEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
        public _services_expanded_Renew.ModeEnum[] Mode { get; set; }//;
    }
    
    // Id: Current Namespace: services.expanded.Renew
    public class Current {
        
        // Key: mode Type: services.expanded.Renew.ModeEnum FullType: services.expanded.Renew.ModeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
        public _services_expanded_Renew.ModeEnum? Mode { get; set; }//;
        
        // Key: nextDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nextDate")]
        public System.DateTime? NextDate { get; set; }//;
        
        // Key: period Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("period")]
        public System.TimeSpan? Period { get; set; }//;
    }
    
    // Id: ModeEnum Namespace: services.expanded.Renew
    public enum ModeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("automatic")]
        automatic,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("manual")]
        manual,
    }
}
