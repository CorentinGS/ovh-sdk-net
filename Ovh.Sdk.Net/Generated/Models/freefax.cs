//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _freefax {
    
    
    // Id: BalanceInformations Namespace: freefax
    public class BalanceInformations {
        
        // Key: faxs Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("faxs")]
        public long Faxs { get; set; }//;
        
        // Key: points Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("points")]
        public long Points { get; set; }//;
    }
    
    // Id: FreefaxProperties Namespace: freefax
    public class FreefaxProperties {
        
        // Key: faxMaxCall Type: telephony.FaxSendingTriesEnum FullType: telephony.FaxSendingTriesEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("faxMaxCall")]
        public _telephony.FaxSendingTriesEnum FaxMaxCall { get; set; }//;
        
        // Key: faxQuality Type: telephony.FaxQualityEnum FullType: telephony.FaxQualityEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("faxQuality")]
        public _telephony.FaxQualityEnum FaxQuality { get; set; }//;
        
        // Key: faxTagLine Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("faxTagLine")]
        public string FaxTagLine { get; set; }//;
        
        // Key: fromEmail Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fromEmail")]
        public string FromEmail { get; set; }//;
        
        // Key: fromName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fromName")]
        public string FromName { get; set; }//;
        
        // Key: number Type: phoneNumber FullType: phoneNumber
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        public string Number { get; set; }//;
        
        // Key: redirectionEmail Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("redirectionEmail")]
        public string[] RedirectionEmail { get; set; }//;
    }
    
    // Id: FreefaxProperties Namespace: freefax
    public class FreefaxPropertiesWithIAM {
        
        // Key: faxMaxCall Type: telephony.FaxSendingTriesEnum FullType: telephony.FaxSendingTriesEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("faxMaxCall")]
        public _telephony.FaxSendingTriesEnum FaxMaxCall { get; set; }//;
        
        // Key: faxQuality Type: telephony.FaxQualityEnum FullType: telephony.FaxQualityEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("faxQuality")]
        public _telephony.FaxQualityEnum FaxQuality { get; set; }//;
        
        // Key: faxTagLine Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("faxTagLine")]
        public string FaxTagLine { get; set; }//;
        
        // Key: fromEmail Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fromEmail")]
        public string FromEmail { get; set; }//;
        
        // Key: fromName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fromName")]
        public string FromName { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: number Type: phoneNumber FullType: phoneNumber
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        public string Number { get; set; }//;
        
        // Key: redirectionEmail Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("redirectionEmail")]
        public string[] RedirectionEmail { get; set; }//;
    }
    
    // Id: QuantityEnum Namespace: freefax
    public enum QuantityEnum {
        
        _10 = 10,
        
        _50 = 50,
        
        _100 = 100,
        
        _200 = 200,
        
        _500 = 500,
        
        _1000 = 1000,
        
        _2000 = 2000,
        
        _5000 = 5000,
        
        _10000 = 10000,
        
        _100000 = 100000,
    }
}
