//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _license_virtuozzo {
    
    
    // Id: Virtuozzo Namespace: license.virtuozzo
    public class Virtuozzo {
        
        // Key: containerNumber Type: license.VirtuozzoContainerNumberEnum FullType: license.VirtuozzoContainerNumberEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("containerNumber")]
        public _license.VirtuozzoContainerNumberEnum ContainerNumber { get; set; }//;
        
        // Key: creation Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creation")]
        public System.DateTime Creation { get; set; }//;
        
        // Key: deleteAtExpiration Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteAtExpiration")]
        public bool DeleteAtExpiration { get; set; }//;
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
        
        // Key: informationKey Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("informationKey")]
        public string InformationKey { get; set; }//;
        
        // Key: ip Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.Net.IPAddress Ip { get; set; }//;
        
        // Key: licenseId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("licenseId")]
        public string LicenseId { get; set; }//;
        
        // Key: productKey Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productKey")]
        public string ProductKey { get; set; }//;
        
        // Key: status Type: license.StateEnum FullType: license.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _license.StateEnum Status { get; set; }//;
        
        // Key: version Type: license.VirtuozzoVersionEnum FullType: license.VirtuozzoVersionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public _license.VirtuozzoVersionEnum Version { get; set; }//;
    }
    
    // Id: Virtuozzo Namespace: license.virtuozzo
    public class VirtuozzoWithIAM {
        
        // Key: containerNumber Type: license.VirtuozzoContainerNumberEnum FullType: license.VirtuozzoContainerNumberEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("containerNumber")]
        public _license.VirtuozzoContainerNumberEnum ContainerNumber { get; set; }//;
        
        // Key: creation Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creation")]
        public System.DateTime Creation { get; set; }//;
        
        // Key: deleteAtExpiration Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteAtExpiration")]
        public bool DeleteAtExpiration { get; set; }//;
        
        // Key: domain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("domain")]
        public string Domain { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata Iam { get; set; }//;
        
        // Key: informationKey Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("informationKey")]
        public string InformationKey { get; set; }//;
        
        // Key: ip Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public System.Net.IPAddress Ip { get; set; }//;
        
        // Key: licenseId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("licenseId")]
        public string LicenseId { get; set; }//;
        
        // Key: productKey Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("productKey")]
        public string ProductKey { get; set; }//;
        
        // Key: status Type: license.StateEnum FullType: license.StateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _license.StateEnum Status { get; set; }//;
        
        // Key: version Type: license.VirtuozzoVersionEnum FullType: license.VirtuozzoVersionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public _license.VirtuozzoVersionEnum Version { get; set; }//;
    }
}