//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _me_consent {
    
    
    // Id: Campaign Namespace: me.consent
    public class Campaign {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: type Type: me.consent.CampaignTypeEnum FullType: me.consent.CampaignTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _me_consent.CampaignTypeEnum Type { get; set; }//;
    }
    
    // Id: CampaignTypeEnum Namespace: me.consent
    public enum CampaignTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OPTIN")]
        OPTIN,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OPTOUT")]
        OPTOUT,
    }
    
    // Id: Consent Namespace: me.consent
    public class Consent {
        
        // Key: campaign Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("campaign")]
        public string Campaign { get; set; }//;
        
        // Key: history Type: me.consent.Decision[] FullType: me.consent.Decision[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("history")]
        public _me_consent.Decision[] History { get; set; }//;
        
        // Key: type Type: me.consent.CampaignTypeEnum FullType: me.consent.CampaignTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _me_consent.CampaignTypeEnum Type { get; set; }//;
        
        // Key: value Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public bool Value { get; set; }//;
    }
    
    // Id: Decision Namespace: me.consent
    public class Decision {
        
        // Key: timestamp Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("timestamp")]
        public System.DateTime Timestamp { get; set; }//;
        
        // Key: value Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public bool Value { get; set; }//;
    }
}