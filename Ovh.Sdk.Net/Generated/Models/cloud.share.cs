//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_share {
    
    
    // Id: Capability Namespace: cloud.share
    public class Capability {
        
        // Key: enabled Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabled")]
        public bool Enabled { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: ExportLocationObject Namespace: cloud.share
    public class ExportLocationObject {
        
        // Key: id Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string Id { get; set; }//;
        
        // Key: path Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("path")]
        public string Path { get; set; }//;
    }
    
    // Id: ProtocolEnum Namespace: cloud.share
    public enum ProtocolEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NFS")]
        NFS,
    }
    
    // Id: Share Namespace: cloud.share
    public class Share {
        
        // Key: capabilities Type: cloud.share.Capability[] FullType: cloud.share.Capability[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("capabilities")]
        public _cloud_share.Capability[]? Capabilities { get; set; }//;
        
        // Key: createdAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("createdAt")]
        public System.DateTime CreatedAt { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: exportLocations Type: cloud.share.ExportLocationObject[] FullType: cloud.share.ExportLocationObject[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("exportLocations")]
        public _cloud_share.ExportLocationObject[]? ExportLocations { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: isPublic Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isPublic")]
        public bool IsPublic { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public System.String? Name { get; set; }//;
        
        // Key: protocol Type: cloud.share.ProtocolEnum FullType: cloud.share.ProtocolEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("protocol")]
        public _cloud_share.ProtocolEnum Protocol { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public long Size { get; set; }//;
        
        // Key: status Type: cloud.share.StatusEnum FullType: cloud.share.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_share.StatusEnum Status { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: ShareUpdate Namespace: cloud.share
    public class ShareUpdate {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: newSize Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("newSize")]
        public long NewSize { get; set; }//;
    }
    
    // Id: StatusEnum Namespace: cloud.share
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("available")]
        available,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("awaiting_transfer")]
        awaiting_transfer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backup_creating")]
        backup_creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backup_restoring")]
        backup_restoring,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backup_restoring_error")]
        backup_restoring_error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating")]
        creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating_from_snapshot")]
        creating_from_snapshot,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleted")]
        deleted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleting")]
        deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error_deleting")]
        error_deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("extending")]
        extending,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("extending_error")]
        extending_error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("inactive")]
        inactive,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("manage_error")]
        manage_error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("manage_starting")]
        manage_starting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migrating")]
        migrating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("migrating_to")]
        migrating_to,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("replication_change")]
        replication_change,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reverting")]
        reverting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reverting_error")]
        reverting_error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("shrinking")]
        shrinking,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("shrinking_error")]
        shrinking_error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("shrinking_possible_data_loss_error")]
        shrinking_possible_data_loss_error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unmanage_error")]
        unmanage_error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unmanage_starting")]
        unmanage_starting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unmanaged")]
        unmanaged,
    }
}
