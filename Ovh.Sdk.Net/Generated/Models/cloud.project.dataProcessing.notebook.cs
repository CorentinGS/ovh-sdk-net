//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_project_dataProcessing_notebook {
    
    
    // Id: Capability Namespace: cloud.project.dataProcessing.notebook
    public class Capability {
        
        // Key: availableVersions Type: cloud.project.dataProcessing.EngineVersion[] FullType: cloud.project.dataProcessing.EngineVersion[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("availableVersions")]
        public _cloud_project_dataProcessing.EngineVersion[] AvailableVersions { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: templates Type: cloud.project.dataProcessing.CapabilitiesNotebookTemplate[] FullType: cloud.project.dataProcessing.CapabilitiesNotebookTemplate[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("templates")]
        public _cloud_project_dataProcessing.CapabilitiesNotebookTemplate[] Templates { get; set; }//;
    }
    
    // Id: Notebook Namespace: cloud.project.dataProcessing.notebook
    public class Notebook {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: spec Type: cloud.project.dataProcessing.notebook.NotebookSpec FullType: cloud.project.dataProcessing.notebook.NotebookSpec
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("spec")]
        public _cloud_project_dataProcessing_notebook.NotebookSpec Spec { get; set; }//;
        
        // Key: status Type: cloud.project.dataProcessing.notebook.NotebookStatus FullType: cloud.project.dataProcessing.notebook.NotebookStatus
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_project_dataProcessing_notebook.NotebookStatus Status { get; set; }//;
        
        // Key: updatedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updatedAt")]
        public System.DateTime UpdatedAt { get; set; }//;
    }
    
    // Id: NotebookEnv Namespace: cloud.project.dataProcessing.notebook
    public class NotebookEnv {
        
        // Key: engineName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("engineName")]
        public System.String? EngineName { get; set; }//;
        
        // Key: engineVersion Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("engineVersion")]
        public System.String? EngineVersion { get; set; }//;
    }
    
    // Id: NotebookSpec Namespace: cloud.project.dataProcessing.notebook
    public class NotebookSpec {
        
        // Key: env Type: cloud.project.dataProcessing.notebook.NotebookEnv FullType: cloud.project.dataProcessing.notebook.NotebookEnv
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("env")]
        public _cloud_project_dataProcessing_notebook.NotebookEnv Env { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
    }
    
    // Id: NotebookStateEnum Namespace: cloud.project.dataProcessing.notebook
    public enum NotebookStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETED")]
        DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FAILED")]
        FAILED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RUNNING")]
        RUNNING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("STARTING")]
        STARTING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("STOPPED")]
        STOPPED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("STOPPING")]
        STOPPING,
    }
    
    // Id: NotebookStatus Namespace: cloud.project.dataProcessing.notebook
    public class NotebookStatus {
        
        // Key: duration Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.Int64? Duration { get; set; }//;
        
        // Key: info Type: cloud.project.dataProcessing.Info FullType: cloud.project.dataProcessing.Info
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("info")]
        public _cloud_project_dataProcessing.Info Info { get; set; }//;
        
        // Key: lastStartedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastStartedAt")]
        public System.DateTime? LastStartedAt { get; set; }//;
        
        // Key: lastStoppedAt Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastStoppedAt")]
        public System.DateTime? LastStoppedAt { get; set; }//;
        
        // Key: state Type: cloud.project.dataProcessing.notebook.NotebookStateEnum FullType: cloud.project.dataProcessing.notebook.NotebookStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _cloud_project_dataProcessing_notebook.NotebookStateEnum? State { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public System.String? Url { get; set; }//;
    }
}
