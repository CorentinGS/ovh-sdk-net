//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _telephony_voicemail {
    
    
    // Id: ChangePassword Namespace: telephony.voicemail
    public class ChangePassword {
        
        // Key: password Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public string Password { get; set; }//;
    }
    
    // Id: ChangeRouting Namespace: telephony.voicemail
    public class ChangeRouting {
        
        // Key: routing Type: telephony.VoicefaxRoutingEnum FullType: telephony.VoicefaxRoutingEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("routing")]
        public _telephony.VoicefaxRoutingEnum Routing { get; set; }//;
    }
}
