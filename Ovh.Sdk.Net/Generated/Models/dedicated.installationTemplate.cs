//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _dedicated_installationTemplate {
    
    
    // Id: Templates Namespace: dedicated.installationTemplate
    public class Templates {
        
        // Key: bitFormat Type: dedicated.server.BitFormatEnum FullType: dedicated.server.BitFormatEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bitFormat")]
        public _dedicated_server.BitFormatEnum BitFormat { get; set; }//;
        
        // Key: category Type: dedicated.TemplateOsUsageEnum FullType: dedicated.TemplateOsUsageEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("category")]
        public _dedicated.TemplateOsUsageEnum Category { get; set; }//;
        
        // Key: customization Type: dedicated.TemplateOsProperties FullType: dedicated.TemplateOsProperties
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("customization")]
        public _dedicated.TemplateOsProperties? Customization { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: distribution Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("distribution")]
        public string Distribution { get; set; }//;
        
        // Key: endOfInstall Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endOfInstall")]
        public System.DateOnly EndOfInstall { get; set; }//;
        
        // Key: family Type: dedicated.TemplateOsTypeEnum FullType: dedicated.TemplateOsTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("family")]
        public _dedicated.TemplateOsTypeEnum Family { get; set; }//;
        
        // Key: filesystems Type: dedicated.server.FileSystemEnum[] FullType: dedicated.server.FileSystemEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("filesystems")]
        public _dedicated_server.FileSystemEnum[] Filesystems { get; set; }//;
        
        // Key: hardRaidConfiguration Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hardRaidConfiguration")]
        public System.Boolean? HardRaidConfiguration { get; set; }//;
        
        // Key: inputs Type: dedicated.TemplateOsInput[] FullType: dedicated.TemplateOsInput[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("inputs")]
        public _dedicated.TemplateOsInput[]? Inputs { get; set; }//;
        
        // Key: license Type: dedicated.TemplateOsInfoLicense FullType: dedicated.TemplateOsInfoLicense
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("license")]
        public _dedicated.TemplateOsInfoLicense? License { get; set; }//;
        
        // Key: lvmReady Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lvmReady")]
        public System.Boolean? LvmReady { get; set; }//;
        
        // Key: noPartitioning Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("noPartitioning")]
        public bool NoPartitioning { get; set; }//;
        
        // Key: project Type: dedicated.TemplateOsInfoProject FullType: dedicated.TemplateOsInfoProject
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("project")]
        public _dedicated.TemplateOsInfoProject? Project { get; set; }//;
        
        // Key: softRaidOnlyMirroring Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("softRaidOnlyMirroring")]
        public bool SoftRaidOnlyMirroring { get; set; }//;
        
        // Key: subfamily Type: dedicated.TemplateOsSubfamilyEnum FullType: dedicated.TemplateOsSubfamilyEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subfamily")]
        public _dedicated.TemplateOsSubfamilyEnum Subfamily { get; set; }//;
        
        // Key: templateName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("templateName")]
        public string TemplateName { get; set; }//;
    }
    
    // Id: hardwareRaid Namespace: dedicated.installationTemplate
    public class hardwareRaid {
        
        // Key: disks Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disks")]
        public string[] Disks { get; set; }//;
        
        // Key: mode Type: dedicated.TemplateOsHardwareRaidEnum FullType: dedicated.TemplateOsHardwareRaidEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
        public _dedicated.TemplateOsHardwareRaidEnum Mode { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: step Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("step")]
        public long Step { get; set; }//;
    }
    
    // Id: templatePartitioningSchemes Namespace: dedicated.installationTemplate
    public class templatePartitioningSchemes {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: priority Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("priority")]
        public long Priority { get; set; }//;
    }
    
    // Id: templatePartitions Namespace: dedicated.installationTemplate
    public class templatePartitions {
        
        // Key: filesystem Type: dedicated.server.FileSystemEnum FullType: dedicated.server.FileSystemEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("filesystem")]
        public _dedicated_server.FileSystemEnum Filesystem { get; set; }//;
        
        // Key: mountpoint Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mountpoint")]
        public string Mountpoint { get; set; }//;
        
        // Key: order Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("order")]
        public long Order { get; set; }//;
        
        // Key: raid Type: dedicated.server.PartitionRaidEnum FullType: dedicated.server.PartitionRaidEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("raid")]
        public _dedicated_server.PartitionRaidEnum? Raid { get; set; }//;
        
        // Key: size Type: complexType.UnitAndValue<long> FullType: complexType.UnitAndValue<long>
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public _complexType.UnitAndValue<long> Size { get; set; }//;
        
        // Key: type Type: dedicated.TemplatePartitionTypeEnum FullType: dedicated.TemplatePartitionTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _dedicated.TemplatePartitionTypeEnum Type { get; set; }//;
        
        // Key: volumeName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("volumeName")]
        public System.String? VolumeName { get; set; }//;
    }
}
