//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _dedicated_server_backup {
    
    
    // Id: BackupContainer Namespace: dedicated.server.backup
    public class BackupContainer {
        
        // Key: cloudProject Type: dedicated.server.backup.BackupProject FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cloudProject")]
        public _dedicated_server_backup.BackupProject CloudProject { get; set; }//;
        
        // Key: id Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: quota Type: dedicated.server.backup.BackupQuota FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quota")]
        public _dedicated_server_backup.BackupQuota Quota { get; set; }//;
        
        // Key: region Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: sftp Type: dedicated.server.backup.BackupSftp FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sftp")]
        public _dedicated_server_backup.BackupSftp Sftp { get; set; }//;
        
        // Key: swift Type: dedicated.server.backup.BackupSwift FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("swift")]
        public _dedicated_server_backup.BackupSwift Swift { get; set; }//;
    }
    
    // Id: BackupOffer Namespace: dedicated.server.backup
    public class BackupOffer {
        
        // Key: maxArchive Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxArchive")]
        public _complexType.UnitAndValue<long> MaxArchive { get; set; }//;
        
        // Key: maxBandwidthArchive Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxBandwidthArchive")]
        public _complexType.UnitAndValue<long> MaxBandwidthArchive { get; set; }//;
        
        // Key: maxBandwidthStorage Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxBandwidthStorage")]
        public _complexType.UnitAndValue<long> MaxBandwidthStorage { get; set; }//;
        
        // Key: maxStorage Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxStorage")]
        public _complexType.UnitAndValue<long> MaxStorage { get; set; }//;
    }
    
    // Id: BackupPassword Namespace: dedicated.server.backup
    public class BackupPassword {
        
        // Key: sftpArchive Type: password FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sftpArchive")]
        public string SftpArchive { get; set; }//;
        
        // Key: sftpStorage Type: password FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sftpStorage")]
        public string SftpStorage { get; set; }//;
        
        // Key: swiftArchive Type: password FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("swiftArchive")]
        public string SwiftArchive { get; set; }//;
        
        // Key: swiftStorage Type: password FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("swiftStorage")]
        public string SwiftStorage { get; set; }//;
    }
    
    // Id: BackupProject Namespace: dedicated.server.backup
    public class BackupProject {
        
        // Key: description Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: projectId Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("projectId")]
        public string ProjectId { get; set; }//;
    }
    
    // Id: BackupQuota Namespace: dedicated.server.backup
    public class BackupQuota {
        
        // Key: maxBandwidth Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxBandwidth")]
        public _complexType.UnitAndValue<long> MaxBandwidth { get; set; }//;
        
        // Key: maxStorage Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxStorage")]
        public _complexType.UnitAndValue<long> MaxStorage { get; set; }//;
        
        // Key: storageUsed Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storageUsed")]
        public _complexType.UnitAndValue<long> StorageUsed { get; set; }//;
        
        // Key: usagePercent Type: double FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("usagePercent")]
        public double UsagePercent { get; set; }//;
    }
    
    // Id: BackupSftp Namespace: dedicated.server.backup
    public class BackupSftp {
        
        // Key: password Type: password FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public string Password { get; set; }//;
        
        // Key: url Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public string Url { get; set; }//;
        
        // Key: username Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("username")]
        public string Username { get; set; }//;
    }
    
    // Id: BackupStatus Namespace: dedicated.server.backup
    public class BackupStatus {
        
        // Key: code Type: dedicated.server.backup.BackupStatusCodeEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("code")]
        public _dedicated_server_backup.BackupStatusCodeEnum Code { get; set; }//;
        
        // Key: reason Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reason")]
        public string Reason { get; set; }//;
    }
    
    // Id: BackupStatusCodeEnum Namespace: dedicated.server.backup
    public enum BackupStatusCodeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETING")]
        DELETING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OK")]
        OK,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SUSPENDED")]
        SUSPENDED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SUSPENDING")]
        SUSPENDING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("UNKNOWN")]
        UNKNOWN,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("WAITING_AGREEMENTS_VALIDATION")]
        WAITING_AGREEMENTS_VALIDATION,
    }
    
    // Id: BackupSwift Namespace: dedicated.server.backup
    public class BackupSwift {
        
        // Key: authUrl Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("authUrl")]
        public string AuthUrl { get; set; }//;
        
        // Key: password Type: password FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public string Password { get; set; }//;
        
        // Key: username Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("username")]
        public string Username { get; set; }//;
    }
}