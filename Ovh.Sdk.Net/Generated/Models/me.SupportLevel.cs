//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _me_SupportLevel {
    
    
    // Id: Level Namespace: me.SupportLevel
    public class Level {
        
        // Key: level Type: me.SupportLevel.LevelTypeEnum FullType: me.SupportLevel.LevelTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("level")]
        public _me_SupportLevel.LevelTypeEnum _Level { get; set; }//;
    }
    
    // Id: LevelTypeEnum Namespace: me.SupportLevel
    public enum LevelTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("business")]
        business,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enterprise")]
        enterprise,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("premium")]
        premium,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("premium-accredited")]
        premium_accredited,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("standard")]
        standard,
    }
}
