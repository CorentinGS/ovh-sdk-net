//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_project_loadbalancer {
    
    
    // Id: ActionDispatch Namespace: cloud.project.loadbalancer
    public class ActionDispatch {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: target Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("target")]
        public string Target { get; set; }//;
    }
    
    // Id: ActionRedirect Namespace: cloud.project.loadbalancer
    public class ActionRedirect {
        
        // Key: location Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("location")]
        public string Location { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: statusCode Type: cloud.project.loadbalancer.action.RedirectStatusCodeEnum FullType: cloud.project.loadbalancer.action.RedirectStatusCodeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("statusCode")]
        public _cloud_project_loadbalancer_action.RedirectStatusCodeEnum StatusCode { get; set; }//;
    }
    
    // Id: ActionReject Namespace: cloud.project.loadbalancer
    public class ActionReject {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: statusCode Type: cloud.project.loadbalancer.action.RejectStatusCodeEnum FullType: cloud.project.loadbalancer.action.RejectStatusCodeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("statusCode")]
        public _cloud_project_loadbalancer_action.RejectStatusCodeEnum StatusCode { get; set; }//;
    }
    
    // Id: ActionRewrite Namespace: cloud.project.loadbalancer
    public class ActionRewrite {
        
        // Key: location Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("location")]
        public string Location { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: Actions Namespace: cloud.project.loadbalancer
    public class Actions {
        
        // Key: dispatch Type: cloud.project.loadbalancer.ActionDispatch[] FullType: cloud.project.loadbalancer.ActionDispatch[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dispatch")]
        public _cloud_project_loadbalancer.ActionDispatch[]? Dispatch { get; set; }//;
        
        // Key: redirect Type: cloud.project.loadbalancer.ActionRedirect[] FullType: cloud.project.loadbalancer.ActionRedirect[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("redirect")]
        public _cloud_project_loadbalancer.ActionRedirect[]? Redirect { get; set; }//;
        
        // Key: reject Type: cloud.project.loadbalancer.ActionReject[] FullType: cloud.project.loadbalancer.ActionReject[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reject")]
        public _cloud_project_loadbalancer.ActionReject[]? Reject { get; set; }//;
        
        // Key: rewrite Type: cloud.project.loadbalancer.ActionRewrite[] FullType: cloud.project.loadbalancer.ActionRewrite[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rewrite")]
        public _cloud_project_loadbalancer.ActionRewrite[]? Rewrite { get; set; }//;
    }
    
    // Id: Address Namespace: cloud.project.loadbalancer
    public class Address {
        
        // Key: ipv4 Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv4")]
        public string Ipv4 { get; set; }//;
        
        // Key: ipv6 Type: ipv6 FullType: ipv6
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        public System.String? Ipv6 { get; set; }//;
    }
    
    // Id: Addresses Namespace: cloud.project.loadbalancer
    public class Addresses {
        
        // Key: ipv4 Type: ipv4Block[] FullType: ipv4Block[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv4")]
        public string[] Ipv4 { get; set; }//;
        
        // Key: ipv6 Type: ipv6Block[] FullType: ipv6Block[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        public System.String[]? Ipv6 { get; set; }//;
    }
    
    // Id: ApplicationConfiguration Namespace: cloud.project.loadbalancer
    public class ApplicationConfiguration {
        
        // Key: actions Type: cloud.project.loadbalancer.Actions FullType: cloud.project.loadbalancer.Actions
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("actions")]
        public _cloud_project_loadbalancer.Actions? Actions { get; set; }//;
        
        // Key: certificates Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("certificates")]
        public string[] Certificates { get; set; }//;
        
        // Key: conditions Type: cloud.project.loadbalancer.Condition[] FullType: cloud.project.loadbalancer.Condition[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("conditions")]
        public _cloud_project_loadbalancer.Condition[]? Conditions { get; set; }//;
        
        // Key: entryPoints Type: cloud.project.loadbalancer.EntryPoint[] FullType: cloud.project.loadbalancer.EntryPoint[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("entryPoints")]
        public _cloud_project_loadbalancer.EntryPoint[] EntryPoints { get; set; }//;
        
        // Key: networking Type: cloud.project.loadbalancer.configuration.networking.Networking FullType: cloud.project.loadbalancer.configuration.networking.Networking
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("networking")]
        public _cloud_project_loadbalancer_configuration_networking.Networking Networking { get; set; }//;
        
        // Key: targets Type: cloud.project.loadbalancer.Target[] FullType: cloud.project.loadbalancer.Target[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targets")]
        public _cloud_project_loadbalancer.Target[]? Targets { get; set; }//;
        
        // Key: version Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public long Version { get; set; }//;
    }
    
    // Id: ApplicationConfigurationCreation Namespace: cloud.project.loadbalancer
    public class ApplicationConfigurationCreation {
        
        // Key: actions Type: cloud.project.loadbalancer.Actions FullType: cloud.project.loadbalancer.Actions
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("actions")]
        public _cloud_project_loadbalancer.Actions? Actions { get; set; }//;
        
        // Key: certificates Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("certificates")]
        public string[] Certificates { get; set; }//;
        
        // Key: conditions Type: cloud.project.loadbalancer.Condition[] FullType: cloud.project.loadbalancer.Condition[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("conditions")]
        public _cloud_project_loadbalancer.Condition[]? Conditions { get; set; }//;
        
        // Key: entryPoints Type: cloud.project.loadbalancer.EntryPoint[] FullType: cloud.project.loadbalancer.EntryPoint[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("entryPoints")]
        public _cloud_project_loadbalancer.EntryPoint[] EntryPoints { get; set; }//;
        
        // Key: networking Type: cloud.project.loadbalancer.configuration.networking.Networking FullType: cloud.project.loadbalancer.configuration.networking.Networking
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("networking")]
        public _cloud_project_loadbalancer_configuration_networking.Networking? Networking { get; set; }//;
        
        // Key: targets Type: cloud.project.loadbalancer.Target[] FullType: cloud.project.loadbalancer.Target[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targets")]
        public _cloud_project_loadbalancer.Target[]? Targets { get; set; }//;
        
        // Key: version Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public long Version { get; set; }//;
    }
    
    // Id: ApplicationLoadBalancerSizeCapability Namespace: cloud.project.loadbalancer
    public class ApplicationLoadBalancerSizeCapability {
        
        // Key: bandwidth Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bandwidth")]
        public long Bandwidth { get; set; }//;
        
        // Key: maximumConnection Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maximumConnection")]
        public long MaximumConnection { get; set; }//;
        
        // Key: requestsPerSecond Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("requestsPerSecond")]
        public long RequestsPerSecond { get; set; }//;
        
        // Key: size Type: cloud.project.loadbalancer.SizeEnum FullType: cloud.project.loadbalancer.SizeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public _cloud_project_loadbalancer.SizeEnum Size { get; set; }//;
    }
    
    // Id: Backend Namespace: cloud.project.loadbalancer
    public class Backend {
        
        // Key: balancer Type: cloud.project.loadbalancer.backend.BalancerAlgorithmEnum FullType: cloud.project.loadbalancer.backend.BalancerAlgorithmEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("balancer")]
        public _cloud_project_loadbalancer_backend.BalancerAlgorithmEnum? Balancer { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: proxyProtocol Type: cloud.project.loadbalancer.backend.ProxyProtocolEnum FullType: cloud.project.loadbalancer.backend.ProxyProtocolEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("proxyProtocol")]
        public _cloud_project_loadbalancer_backend.ProxyProtocolEnum? ProxyProtocol { get; set; }//;
        
        // Key: servers Type: cloud.project.loadbalancer.Server[] FullType: cloud.project.loadbalancer.Server[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("servers")]
        public _cloud_project_loadbalancer.Server[] Servers { get; set; }//;
        
        // Key: sticky Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sticky")]
        public System.Boolean? Sticky { get; set; }//;
    }
    
    // Id: BackendSelector Namespace: cloud.project.loadbalancer
    public class BackendSelector {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: Condition Namespace: cloud.project.loadbalancer
    public class Condition {
        
        // Key: key Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("key")]
        public System.String? Key { get; set; }//;
        
        // Key: match Type: cloud.project.loadbalancer.condition.MatchEnum FullType: cloud.project.loadbalancer.condition.MatchEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("match")]
        public _cloud_project_loadbalancer_condition.MatchEnum Match { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: negate Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("negate")]
        public System.Boolean? Negate { get; set; }//;
        
        // Key: type Type: cloud.project.loadbalancer.condition.TypeEnum FullType: cloud.project.loadbalancer.condition.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _cloud_project_loadbalancer_condition.TypeEnum Type { get; set; }//;
        
        // Key: values Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("values")]
        public string[] Values { get; set; }//;
    }
    
    // Id: Configuration Namespace: cloud.project.loadbalancer
    public class Configuration {
        
        // Key: backends Type: cloud.project.loadbalancer.Backend[] FullType: cloud.project.loadbalancer.Backend[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backends")]
        public _cloud_project_loadbalancer.Backend[] Backends { get; set; }//;
        
        // Key: certificates Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("certificates")]
        public string[] Certificates { get; set; }//;
        
        // Key: frontends Type: cloud.project.loadbalancer.Frontend[] FullType: cloud.project.loadbalancer.Frontend[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("frontends")]
        public _cloud_project_loadbalancer.Frontend[] Frontends { get; set; }//;
        
        // Key: networking Type: cloud.project.loadbalancer.configuration.networking.Networking FullType: cloud.project.loadbalancer.configuration.networking.Networking
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("networking")]
        public _cloud_project_loadbalancer_configuration_networking.Networking Networking { get; set; }//;
        
        // Key: version Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public long Version { get; set; }//;
    }
    
    // Id: ConfigurationCreation Namespace: cloud.project.loadbalancer
    public class ConfigurationCreation {
        
        // Key: backends Type: cloud.project.loadbalancer.Backend[] FullType: cloud.project.loadbalancer.Backend[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backends")]
        public _cloud_project_loadbalancer.Backend[] Backends { get; set; }//;
        
        // Key: certificates Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("certificates")]
        public string[] Certificates { get; set; }//;
        
        // Key: frontends Type: cloud.project.loadbalancer.Frontend[] FullType: cloud.project.loadbalancer.Frontend[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("frontends")]
        public _cloud_project_loadbalancer.Frontend[] Frontends { get; set; }//;
        
        // Key: networking Type: cloud.project.loadbalancer.configuration.networking.Networking FullType: cloud.project.loadbalancer.configuration.networking.Networking
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("networking")]
        public _cloud_project_loadbalancer_configuration_networking.Networking? Networking { get; set; }//;
        
        // Key: version Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public long Version { get; set; }//;
    }
    
    // Id: ConfigurationVersion Namespace: cloud.project.loadbalancer
    public class ConfigurationVersion {
        
        // Key: applied Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("applied")]
        public long Applied { get; set; }//;
        
        // Key: latest Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("latest")]
        public long Latest { get; set; }//;
    }
    
    // Id: EntryPoint Namespace: cloud.project.loadbalancer
    public class EntryPoint {
        
        // Key: defaultTarget Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("defaultTarget")]
        public System.String? DefaultTarget { get; set; }//;
        
        // Key: disableH2 Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disableH2")]
        public System.Boolean? DisableH2 { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: portRanges Type: cloud.project.loadbalancer.PortRange[] FullType: cloud.project.loadbalancer.PortRange[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("portRanges")]
        public _cloud_project_loadbalancer.PortRange[]? PortRanges { get; set; }//;
        
        // Key: ports Type: long[] FullType: long[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ports")]
        public System.Int64[]? Ports { get; set; }//;
        
        // Key: rules Type: cloud.project.loadbalancer.Rule[] FullType: cloud.project.loadbalancer.Rule[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rules")]
        public _cloud_project_loadbalancer.Rule[] Rules { get; set; }//;
        
        // Key: tls Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tls")]
        public bool Tls { get; set; }//;
    }
    
    // Id: Frontend Namespace: cloud.project.loadbalancer
    public class Frontend {
        
        // Key: backends Type: cloud.project.loadbalancer.BackendSelector[] FullType: cloud.project.loadbalancer.BackendSelector[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("backends")]
        public _cloud_project_loadbalancer.BackendSelector[] Backends { get; set; }//;
        
        // Key: mode Type: cloud.project.loadbalancer.frontend.ModeEnum FullType: cloud.project.loadbalancer.frontend.ModeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
        public _cloud_project_loadbalancer_frontend.ModeEnum? Mode { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: port Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public System.Int64? Port { get; set; }//;
        
        // Key: portRanges Type: cloud.project.loadbalancer.PortRange[] FullType: cloud.project.loadbalancer.PortRange[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("portRanges")]
        public _cloud_project_loadbalancer.PortRange[]? PortRanges { get; set; }//;
        
        // Key: ports Type: long[] FullType: long[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ports")]
        public System.Int64[]? Ports { get; set; }//;
        
        // Key: tls Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tls")]
        public bool Tls { get; set; }//;
        
        // Key: whitelist Type: ipBlock[] FullType: ipBlock[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("whitelist")]
        public string[] Whitelist { get; set; }//;
    }
    
    // Id: LoadBalancerSizeCapability Namespace: cloud.project.loadbalancer
    public class LoadBalancerSizeCapability {
        
        // Key: bandwidth Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bandwidth")]
        public long Bandwidth { get; set; }//;
        
        // Key: maximumConnection Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maximumConnection")]
        public long MaximumConnection { get; set; }//;
        
        // Key: newConnectionPerSecond Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("newConnectionPerSecond")]
        public long NewConnectionPerSecond { get; set; }//;
        
        // Key: size Type: cloud.project.loadbalancer.SizeEnum FullType: cloud.project.loadbalancer.SizeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public _cloud_project_loadbalancer.SizeEnum Size { get; set; }//;
    }
    
    // Id: PortRange Namespace: cloud.project.loadbalancer
    public class PortRange {
        
        // Key: end Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("end")]
        public long End { get; set; }//;
        
        // Key: start Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("start")]
        public long Start { get; set; }//;
    }
    
    // Id: Region Namespace: cloud.project.loadbalancer
    public class Region {
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string _Region { get; set; }//;
    }
    
    // Id: Rule Namespace: cloud.project.loadbalancer
    public class Rule {
        
        // Key: action Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("action")]
        public string Action { get; set; }//;
        
        // Key: conditions Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("conditions")]
        public System.String[]? Conditions { get; set; }//;
    }
    
    // Id: Server Namespace: cloud.project.loadbalancer
    public class Server {
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public string Ip { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: noCheck Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("noCheck")]
        public System.Boolean? NoCheck { get; set; }//;
        
        // Key: port Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public long Port { get; set; }//;
        
        // Key: weight Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("weight")]
        public System.Int64? Weight { get; set; }//;
    }
    
    // Id: SizeEnum Namespace: cloud.project.loadbalancer
    public enum SizeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("L")]
        L,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("M")]
        M,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("S")]
        S,
    }
    
    // Id: Stats Namespace: cloud.project.loadbalancer
    public class Stats {
        
        // Key: concurrentFlows Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("concurrentFlows")]
        public double ConcurrentFlows { get; set; }//;
        
        // Key: httpRequestsPerSecond Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("httpRequestsPerSecond")]
        public System.Double? HttpRequestsPerSecond { get; set; }//;
        
        // Key: status Type: cloud.project.loadbalancer.stats.StatusEnum FullType: cloud.project.loadbalancer.stats.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cloud_project_loadbalancer_stats.StatusEnum Status { get; set; }//;
        
        // Key: targets Type: cloud.project.loadbalancer.stats.Target[] FullType: cloud.project.loadbalancer.stats.Target[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("targets")]
        public _cloud_project_loadbalancer_stats.Target[] Targets { get; set; }//;
        
        // Key: tcpConnectionsPerSecond Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tcpConnectionsPerSecond")]
        public double TcpConnectionsPerSecond { get; set; }//;
        
        // Key: throughput Type: cloud.project.loadbalancer.stats.Throughput FullType: cloud.project.loadbalancer.stats.Throughput
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("throughput")]
        public _cloud_project_loadbalancer_stats.Throughput Throughput { get; set; }//;
    }
    
    // Id: StatusEnum Namespace: cloud.project.loadbalancer
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("APPLYING")]
        APPLYING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CREATED")]
        CREATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETING")]
        DELETING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FROZEN")]
        FROZEN,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("RUNNING")]
        RUNNING,
    }
    
    // Id: Target Namespace: cloud.project.loadbalancer
    public class Target {
        
        // Key: balancer Type: cloud.project.loadbalancer.target.BalancerAlgorithmEnum FullType: cloud.project.loadbalancer.target.BalancerAlgorithmEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("balancer")]
        public _cloud_project_loadbalancer_target.BalancerAlgorithmEnum? Balancer { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: proxyProtocol Type: cloud.project.loadbalancer.target.ProxyProtocolEnum FullType: cloud.project.loadbalancer.target.ProxyProtocolEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("proxyProtocol")]
        public _cloud_project_loadbalancer_target.ProxyProtocolEnum? ProxyProtocol { get; set; }//;
        
        // Key: servers Type: cloud.project.loadbalancer.Server[] FullType: cloud.project.loadbalancer.Server[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("servers")]
        public _cloud_project_loadbalancer.Server[] Servers { get; set; }//;
        
        // Key: sticky Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sticky")]
        public System.Boolean? Sticky { get; set; }//;
    }
}
