//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_project_database_service_creation {
    
    
    // Id: BackupFork Namespace: cloud.project.database.service.creation
    public class BackupFork {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: pointInTime Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pointInTime")]
        public System.DateTime PointInTime { get; set; }//;
        
        // Key: serviceId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceId")]
        public System.Guid ServiceId { get; set; }//;
    }
    
    // Id: ForkFrom Namespace: cloud.project.database.service.creation
    public class ForkFrom {
        
        // Key: backupId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backupId")]
        public System.Guid BackupId { get; set; }//;
        
        // Key: pointInTime Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pointInTime")]
        public System.DateTime PointInTime { get; set; }//;
        
        // Key: serviceId Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceId")]
        public System.Guid ServiceId { get; set; }//;
    }
}