//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_project_loadbalancer_stats {
    
    
    // Id: StatusEnum Namespace: cloud.project.loadbalancer.stats
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("HEALTHY")]
        HEALTHY,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NOT_AVAILABLE")]
        NOT_AVAILABLE,
    }
    
    // Id: Target Namespace: cloud.project.loadbalancer.stats
    public class Target {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: servers Type: cloud.project.loadbalancer.stats.target.Server[] FullType: cloud.project.loadbalancer.stats.target.Server[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("servers")]
        public _cloud_project_loadbalancer_stats_target.Server[] Servers { get; set; }//;
    }
    
    // Id: Throughput Namespace: cloud.project.loadbalancer.stats
    public class Throughput {
        
        // Key: in Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("in")]
        public double @in { get; set; }//;
        
        // Key: out Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("out")]
        public double @out { get; set; }//;
    }
}