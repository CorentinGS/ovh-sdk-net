//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_containerRegistry {
    
    
    // Id: Capability Namespace: cloud.containerRegistry
    public class Capability {
        
        // Key: plans Type: cloud.containerRegistry.Plan[] FullType: cloud.containerRegistry.Plan[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plans")]
        public _cloud_containerRegistry.Plan[] Plans { get; set; }//;
        
        // Key: regionName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("regionName")]
        public string RegionName { get; set; }//;
    }
    
    // Id: Features Namespace: cloud.containerRegistry
    public class Features {
        
        // Key: vulnerability Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vulnerability")]
        public bool Vulnerability { get; set; }//;
    }
    
    // Id: IPRestrictions Namespace: cloud.containerRegistry
    public class IPRestrictions {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: ipBlock Type: ipBlock FullType: ipBlock
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipBlock")]
        public string IpBlock { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: Limits Namespace: cloud.containerRegistry
    public class Limits {
        
        // Key: imageStorage Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("imageStorage")]
        public long ImageStorage { get; set; }//;
        
        // Key: parallelRequest Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("parallelRequest")]
        public long ParallelRequest { get; set; }//;
    }
    
    // Id: OIDCConfiguration Namespace: cloud.containerRegistry
    public class OIDCConfiguration {
        
        // Key: adminGroup Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("adminGroup")]
        public System.String? AdminGroup { get; set; }//;
        
        // Key: autoOnboard Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autoOnboard")]
        public System.Boolean? AutoOnboard { get; set; }//;
        
        // Key: clientId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clientId")]
        public string ClientId { get; set; }//;
        
        // Key: clientSecret Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clientSecret")]
        public System.String? ClientSecret { get; set; }//;
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: endpoint Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endpoint")]
        public string Endpoint { get; set; }//;
        
        // Key: groupsClaim Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("groupsClaim")]
        public System.String? GroupsClaim { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: scope Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("scope")]
        public string Scope { get; set; }//;
        
        // Key: status Type: cloud.containerRegistry.OIDCStatusEnum FullType: cloud.containerRegistry.OIDCStatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_containerRegistry.OIDCStatusEnum Status { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public System.DateTime? UpdatedAt { get; set; }//;
        
        // Key: userClaim Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userClaim")]
        public System.String? UserClaim { get; set; }//;
        
        // Key: verifyCert Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("verifyCert")]
        public System.Boolean? VerifyCert { get; set; }//;
    }
    
    // Id: OIDCPost Namespace: cloud.containerRegistry
    public class OIDCPost {
        
        // Key: deleteUsers Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteUsers")]
        public System.Boolean? DeleteUsers { get; set; }//;
        
        // Key: provider Type: cloud.containerRegistry.OIDCConfiguration FullType: cloud.containerRegistry.OIDCConfiguration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("provider")]
        public _cloud_containerRegistry.OIDCConfiguration Provider { get; set; }//;
    }
    
    // Id: OIDCPut Namespace: cloud.containerRegistry
    public class OIDCPut {
        
        // Key: adminGroup Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("adminGroup")]
        public System.String? AdminGroup { get; set; }//;
        
        // Key: autoOnboard Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("autoOnboard")]
        public System.Boolean? AutoOnboard { get; set; }//;
        
        // Key: clientId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clientId")]
        public System.String? ClientId { get; set; }//;
        
        // Key: clientSecret Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clientSecret")]
        public System.String? ClientSecret { get; set; }//;
        
        // Key: endpoint Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endpoint")]
        public System.String? Endpoint { get; set; }//;
        
        // Key: groupsClaim Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("groupsClaim")]
        public System.String? GroupsClaim { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public System.String? Name { get; set; }//;
        
        // Key: scope Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("scope")]
        public System.String? Scope { get; set; }//;
        
        // Key: userClaim Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userClaim")]
        public System.String? UserClaim { get; set; }//;
        
        // Key: verifyCert Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("verifyCert")]
        public System.Boolean? VerifyCert { get; set; }//;
    }
    
    // Id: OIDCStatusEnum Namespace: cloud.containerRegistry
    public enum OIDCStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETING")]
        DELETING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("INSTALLING")]
        INSTALLING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PATCHING")]
        PATCHING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("READY")]
        READY,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UPDATING")]
        UPDATING,
    }
    
    // Id: Plan Namespace: cloud.containerRegistry
    public class Plan {
        
        // Key: code Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public string Code { get; set; }//;
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: features Type: cloud.containerRegistry.Features FullType: cloud.containerRegistry.Features
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("features")]
        public _cloud_containerRegistry.Features Features { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: registryLimits Type: cloud.containerRegistry.Limits FullType: cloud.containerRegistry.Limits
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("registryLimits")]
        public _cloud_containerRegistry.Limits RegistryLimits { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: PlanUpdate Namespace: cloud.containerRegistry
    public class PlanUpdate {
        
        // Key: planID Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planID")]
        public string PlanID { get; set; }//;
    }
    
    // Id: Registry Namespace: cloud.containerRegistry
    public class Registry {
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: projectID Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("projectID")]
        public string ProjectID { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public long Size { get; set; }//;
        
        // Key: status Type: cloud.containerRegistry.StatusEnum FullType: cloud.containerRegistry.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_containerRegistry.StatusEnum Status { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public System.DateTime UpdatedAt { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public string Url { get; set; }//;
        
        // Key: version Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public string Version { get; set; }//;
    }
    
    // Id: StatusEnum Namespace: cloud.containerRegistry
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETED")]
        DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETING")]
        DELETING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("INSTALLING")]
        INSTALLING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("READY")]
        READY,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RESTORING")]
        RESTORING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SUSPENDED")]
        SUSPENDED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SUSPENDING")]
        SUSPENDING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UPDATING")]
        UPDATING,
    }
    
    // Id: User Namespace: cloud.containerRegistry
    public class User {
        
        // Key: email Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("email")]
        public string Email { get; set; }//;
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: password Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public System.String? Password { get; set; }//;
        
        // Key: user Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("user")]
        public string _User { get; set; }//;
    }
}
