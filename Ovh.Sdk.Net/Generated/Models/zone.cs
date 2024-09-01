//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _zone {
    
    
    // Id: NamedResolutionFieldTypeEnum Namespace: zone
    public enum NamedResolutionFieldTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("A")]
        A,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("AAAA")]
        AAAA,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CAA")]
        CAA,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CNAME")]
        CNAME,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DKIM")]
        DKIM,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DMARC")]
        DMARC,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DNAME")]
        DNAME,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LOC")]
        LOC,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MX")]
        MX,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NAPTR")]
        NAPTR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NS")]
        NS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PTR")]
        PTR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SPF")]
        SPF,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SRV")]
        SRV,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SSHFP")]
        SSHFP,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TLSA")]
        TLSA,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TXT")]
        TXT,
    }
    
    // Id: Capabilities Namespace: zone
    public class Capabilities {
        
        // Key: dynHost Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dynHost")]
        public bool DynHost { get; set; }//;
    }
    
    // Id: RedirectionTypeEnum Namespace: zone
    public enum RedirectionTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("invisible")]
        invisible,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("visible")]
        visible,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("visiblePermanent")]
        visiblePermanent,
    }
    
    // Id: ResetRecord Namespace: zone
    public class ResetRecord {
        
        // Key: fieldType Type: zone.ResettableNamedResolutionFieldTypeEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fieldType")]
        public _zone.ResettableNamedResolutionFieldTypeEnum FieldType { get; set; }//;
        
        // Key: target Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("target")]
        public string Target { get; set; }//;
    }
    
    // Id: ResettableNamedResolutionFieldTypeEnum Namespace: zone
    public enum ResettableNamedResolutionFieldTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("A")]
        A,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MX")]
        MX,
    }
    
    // Id: Status Namespace: zone
    public class Status {
        
        // Key: errors Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("errors")]
        public string[] Errors { get; set; }//;
        
        // Key: isDeployed Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isDeployed")]
        public bool IsDeployed { get; set; }//;
        
        // Key: warnings Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("warnings")]
        public string[] Warnings { get; set; }//;
    }
}