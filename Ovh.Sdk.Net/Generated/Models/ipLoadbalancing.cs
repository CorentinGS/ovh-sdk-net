//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _ipLoadbalancing {
    
    
    // Id: BackendCustomerServerStatusEnum Namespace: ipLoadbalancing
    public enum BackendCustomerServerStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("active")]
        active,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("inactive")]
        inactive,
    }
    
    // Id: BackendProbe Namespace: ipLoadbalancing
    public class BackendProbe {
        
        // Key: forceSsl Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("forceSsl")]
        public System.Boolean? ForceSsl { get; set; }//;
        
        // Key: interval Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interval")]
        public System.Int64? Interval { get; set; }//;
        
        // Key: match Type: ipLoadbalancing.ProbeExpectMatchEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("match")]
        public _ipLoadbalancing.ProbeExpectMatchEnum? Match { get; set; }//;
        
        // Key: method Type: ipLoadbalancing.ProbeMethodEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("method")]
        public _ipLoadbalancing.ProbeMethodEnum? Method { get; set; }//;
        
        // Key: negate Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("negate")]
        public System.Boolean? Negate { get; set; }//;
        
        // Key: pattern Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pattern")]
        public System.String? Pattern { get; set; }//;
        
        // Key: port Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public System.Int64? Port { get; set; }//;
        
        // Key: type Type: ipLoadbalancing.ProbeTypeEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _ipLoadbalancing.ProbeTypeEnum? Type { get; set; }//;
        
        // Key: url Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public System.String? Url { get; set; }//;
    }
    
    // Id: BalanceHTTPEnum Namespace: ipLoadbalancing
    public enum BalanceHTTPEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("first")]
        first,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("leastconn")]
        leastconn,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("roundrobin")]
        roundrobin,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("source")]
        source,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uri")]
        uri,
    }
    
    // Id: BalanceTCPEnum Namespace: ipLoadbalancing
    public enum BalanceTCPEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("first")]
        first,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("leastconn")]
        leastconn,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("roundrobin")]
        roundrobin,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("source")]
        source,
    }
    
    // Id: DefinedFarm Namespace: ipLoadbalancing
    public class DefinedFarm {
        
        // Key: id Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: type Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: DefinedFrontend Namespace: ipLoadbalancing
    public class DefinedFrontend {
        
        // Key: id Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: type Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: DefinedRoute Namespace: ipLoadbalancing
    public class DefinedRoute {
        
        // Key: displayName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public System.String? DisplayName { get; set; }//;
        
        // Key: routeId Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("routeId")]
        public long RouteId { get; set; }//;
        
        // Key: type Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: FarmAvailableProbe Namespace: ipLoadbalancing
    public class FarmAvailableProbe {
        
        // Key: matches Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("matches")]
        public string[] Matches { get; set; }//;
        
        // Key: method Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("method")]
        public System.String[]? Method { get; set; }//;
        
        // Key: negatableMatches Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("negatableMatches")]
        public string[] NegatableMatches { get; set; }//;
        
        // Key: port Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public bool Port { get; set; }//;
        
        // Key: type Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
        
        // Key: url Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public bool Url { get; set; }//;
    }
    
    // Id: InstancesState Namespace: ipLoadbalancing
    public class InstancesState {
        
        // Key: internalId Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internalId")]
        public long InternalId { get; set; }//;
        
        // Key: lastUpdateDate Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdateDate")]
        public System.DateTime LastUpdateDate { get; set; }//;
        
        // Key: state Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public string State { get; set; }//;
        
        // Key: zone Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zone")]
        public string Zone { get; set; }//;
    }
    
    // Id: Ip Namespace: ipLoadbalancing
    public class Ip {
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public System.String? DisplayName { get; set; }//;
        
        // Key: ipLoadbalancing Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipLoadbalancing")]
        public string IpLoadbalancing { get; set; }//;
        
        // Key: ipv4 Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv4")]
        public System.String? Ipv4 { get; set; }//;
        
        // Key: ipv6 Type: ipv6 FullType: ipv6
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        public System.String? Ipv6 { get; set; }//;
        
        // Key: metricsToken Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("metricsToken")]
        public System.String? MetricsToken { get; set; }//;
        
        // Key: offer Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public string Offer { get; set; }//;
        
        // Key: orderableZone Type: ipLoadbalancing.OrderableZone[] FullType: ipLoadbalancing.OrderableZone[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderableZone")]
        public _ipLoadbalancing.OrderableZone[] OrderableZone { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public string ServiceName { get; set; }//;
        
        // Key: sslConfiguration Type: ipLoadbalancing.SslConfigurationEnum FullType: ipLoadbalancing.SslConfigurationEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sslConfiguration")]
        public _ipLoadbalancing.SslConfigurationEnum? SslConfiguration { get; set; }//;
        
        // Key: state Type: ipLoadbalancing.IpStateEnum FullType: ipLoadbalancing.IpStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _ipLoadbalancing.IpStateEnum State { get; set; }//;
        
        // Key: vrackEligibility Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackEligibility")]
        public bool VrackEligibility { get; set; }//;
        
        // Key: vrackName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackName")]
        public System.String? VrackName { get; set; }//;
        
        // Key: zone Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zone")]
        public string[] Zone { get; set; }//;
    }
    
    // Id: IpStateEnum Namespace: ipLoadbalancing
    public enum IpStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("blacklisted")]
        blacklisted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleted")]
        deleted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("free")]
        free,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ok")]
        ok,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quarantined")]
        quarantined,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("suspended")]
        suspended,
    }
    
    // Id: Ip Namespace: ipLoadbalancing
    public class IpWithIAM {
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public System.String? DisplayName { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: ipLoadbalancing Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipLoadbalancing")]
        public string IpLoadbalancing { get; set; }//;
        
        // Key: ipv4 Type: ipv4 FullType: ipv4
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv4")]
        public System.String? Ipv4 { get; set; }//;
        
        // Key: ipv6 Type: ipv6 FullType: ipv6
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ipv6")]
        public System.String? Ipv6 { get; set; }//;
        
        // Key: metricsToken Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("metricsToken")]
        public System.String? MetricsToken { get; set; }//;
        
        // Key: offer Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offer")]
        public string Offer { get; set; }//;
        
        // Key: orderableZone Type: ipLoadbalancing.OrderableZone[] FullType: ipLoadbalancing.OrderableZone[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderableZone")]
        public _ipLoadbalancing.OrderableZone[] OrderableZone { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public string ServiceName { get; set; }//;
        
        // Key: sslConfiguration Type: ipLoadbalancing.SslConfigurationEnum FullType: ipLoadbalancing.SslConfigurationEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sslConfiguration")]
        public _ipLoadbalancing.SslConfigurationEnum? SslConfiguration { get; set; }//;
        
        // Key: state Type: ipLoadbalancing.IpStateEnum FullType: ipLoadbalancing.IpStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _ipLoadbalancing.IpStateEnum State { get; set; }//;
        
        // Key: vrackEligibility Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackEligibility")]
        public bool VrackEligibility { get; set; }//;
        
        // Key: vrackName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackName")]
        public System.String? VrackName { get; set; }//;
        
        // Key: zone Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zone")]
        public string[] Zone { get; set; }//;
    }
    
    // Id: MetricsToken Namespace: ipLoadbalancing
    public class MetricsToken {
        
        // Key: endpoint Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endpoint")]
        public string Endpoint { get; set; }//;
        
        // Key: token Type: password FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("token")]
        public string Token { get; set; }//;
    }
    
    // Id: NatIps Namespace: ipLoadbalancing
    public class NatIps {
        
        // Key: ip Type: ipBlock[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public string[] Ip { get; set; }//;
        
        // Key: zone Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zone")]
        public string Zone { get; set; }//;
    }
    
    // Id: OnMarkedDownEnum Namespace: ipLoadbalancing
    public enum OnMarkedDownEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("shutdown-sessions")]
        shutdown_sessions,
    }
    
    // Id: OrderableZone Namespace: ipLoadbalancing
    public class OrderableZone {
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: planCode Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("planCode")]
        public string PlanCode { get; set; }//;
    }
    
    // Id: PendingChanges Namespace: ipLoadbalancing
    public class PendingChanges {
        
        // Key: number Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number")]
        public long Number { get; set; }//;
        
        // Key: zone Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zone")]
        public string Zone { get; set; }//;
    }
    
    // Id: ProbeExpectMatchEnum Namespace: ipLoadbalancing
    public enum ProbeExpectMatchEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contains")]
        contains,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("default")]
        @default,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        @internal,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("matches")]
        matches,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        status,
    }
    
    // Id: ProbeMethodEnum Namespace: ipLoadbalancing
    public enum ProbeMethodEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GET")]
        GET,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("HEAD")]
        HEAD,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OPTIONS")]
        OPTIONS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        @internal,
    }
    
    // Id: ProbeTypeEnum Namespace: ipLoadbalancing
    public enum ProbeTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("http")]
        http,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        @internal,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mysql")]
        mysql,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("oco")]
        oco,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pgsql")]
        pgsql,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("smtp")]
        smtp,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tcp")]
        tcp,
    }
    
    // Id: ProxyProtocolVersionEnum Namespace: ipLoadbalancing
    public enum ProxyProtocolVersionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("v1")]
        v1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("v2")]
        v2,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("v2-ssl")]
        v2_ssl,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("v2-ssl-cn")]
        v2_ssl_cn,
    }
    
    // Id: ProxyTypeEnum Namespace: ipLoadbalancing
    public enum ProxyTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("http")]
        http,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tcp")]
        tcp,
    }
    
    // Id: RouteAvailableAction Namespace: ipLoadbalancing
    public class RouteAvailableAction {
        
        // Key: destination Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("destination")]
        public System.String? Destination { get; set; }//;
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: status Type: long[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public System.Int64[]? Status { get; set; }//;
        
        // Key: type Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: RouteAvailableRule Namespace: ipLoadbalancing
    public class RouteAvailableRule {
        
        // Key: enum Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enum")]
        public System.String[]? @enum { get; set; }//;
        
        // Key: hasSubField Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hasSubField")]
        public bool HasSubField { get; set; }//;
        
        // Key: matches Type: string[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("matches")]
        public string[] Matches { get; set; }//;
        
        // Key: name Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: pattern Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pattern")]
        public string Pattern { get; set; }//;
        
        // Key: type Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: RouteHttpAction Namespace: ipLoadbalancing
    public class RouteHttpAction {
        
        // Key: status Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public System.Int64? Status { get; set; }//;
        
        // Key: target Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("target")]
        public System.String? Target { get; set; }//;
        
        // Key: type Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: RouteRule Namespace: ipLoadbalancing
    public class RouteRule {
        
        // Key: field Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("field")]
        public string Field { get; set; }//;
        
        // Key: match Type: ipLoadbalancing.RouteRuleMatchesEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("match")]
        public _ipLoadbalancing.RouteRuleMatchesEnum Match { get; set; }//;
        
        // Key: negate Type: boolean FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("negate")]
        public bool Negate { get; set; }//;
        
        // Key: pattern Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pattern")]
        public System.String? Pattern { get; set; }//;
        
        // Key: ruleId Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ruleId")]
        public long RuleId { get; set; }//;
        
        // Key: subField Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subField")]
        public System.String? SubField { get; set; }//;
    }
    
    // Id: RouteRuleMatchesEnum Namespace: ipLoadbalancing
    public enum RouteRuleMatchesEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contains")]
        contains,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endswith")]
        endswith,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("exists")]
        exists,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("in")]
        @in,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        @internal,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("is")]
        @is,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("matches")]
        matches,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startswith")]
        startswith,
    }
    
    // Id: RouteStatusEnum Namespace: ipLoadbalancing
    public enum RouteStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating")]
        creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleting")]
        deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("internal")]
        @internal,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ok")]
        ok,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("updating")]
        updating,
    }
    
    // Id: RouteTcpAction Namespace: ipLoadbalancing
    public class RouteTcpAction {
        
        // Key: target Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("target")]
        public System.String? Target { get; set; }//;
        
        // Key: type Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: ServerState Namespace: ipLoadbalancing
    public class ServerState {
        
        // Key: checkCode Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkCode")]
        public System.String? CheckCode { get; set; }//;
        
        // Key: checkStatus Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkStatus")]
        public System.String? CheckStatus { get; set; }//;
        
        // Key: checkTime Type: datetime FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("checkTime")]
        public System.DateTime? CheckTime { get; set; }//;
        
        // Key: instanceId Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instanceId")]
        public long InstanceId { get; set; }//;
        
        // Key: lastCheckContent Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastCheckContent")]
        public System.String? LastCheckContent { get; set; }//;
        
        // Key: status Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public System.String? Status { get; set; }//;
    }
    
    // Id: SslConfigurationEnum Namespace: ipLoadbalancing
    public enum SslConfigurationEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("intermediate")]
        intermediate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("modern")]
        modern,
    }
    
    // Id: SslTypeEnum Namespace: ipLoadbalancing
    public enum SslTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("built")]
        built,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("built_not_routed")]
        built_not_routed,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("custom")]
        custom,
    }
    
    // Id: Status Namespace: ipLoadbalancing
    public class Status {
        
        // Key: farms Type: ipLoadbalancing.status.Component FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("farms")]
        public _ipLoadbalancing_status.Component Farms { get; set; }//;
        
        // Key: frontends Type: ipLoadbalancing.status.Component FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("frontends")]
        public _ipLoadbalancing_status.Component Frontends { get; set; }//;
        
        // Key: servers Type: ipLoadbalancing.status.Component FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("servers")]
        public _ipLoadbalancing_status.Component Servers { get; set; }//;
        
        // Key: service Type: ipLoadbalancing.status.Service FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("service")]
        public _ipLoadbalancing_status.Service Service { get; set; }//;
    }
    
    // Id: StickinessHTTPEnum Namespace: ipLoadbalancing
    public enum StickinessHTTPEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cookie")]
        cookie,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sourceIp")]
        sourceIp,
    }
    
    // Id: StickinessTCPEnum Namespace: ipLoadbalancing
    public enum StickinessTCPEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sourceIp")]
        sourceIp,
    }
    
    // Id: TaskActionEnum Namespace: ipLoadbalancing
    public enum TaskActionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteIplb")]
        deleteIplb,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deployIplb")]
        deployIplb,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("install")]
        install,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("installIplb")]
        installIplb,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("installZone")]
        installZone,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderFreeCertificate")]
        orderFreeCertificate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderPaidCertificate")]
        orderPaidCertificate,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderSsl")]
        orderSsl,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("refreshIplb")]
        refreshIplb,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("releaseIplb")]
        releaseIplb,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("releaseIplbZone")]
        releaseIplbZone,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reopenIplb")]
        reopenIplb,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("suspendIplb")]
        suspendIplb,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("suspendZone")]
        suspendZone,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("switchToIplbNextGenerationApi")]
        switchToIplbNextGenerationApi,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackAttach")]
        vrackAttach,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackDetach")]
        vrackDetach,
    }
    
    // Id: TaskStatusEnum Namespace: ipLoadbalancing
    public enum TaskStatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("blocked")]
        blocked,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cancelled")]
        cancelled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("doing")]
        doing,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("done")]
        done,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("error")]
        error,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todo")]
        todo,
    }
    
    // Id: VrackInformation Namespace: ipLoadbalancing
    public class VrackInformation {
        
        // Key: state Type: ipLoadbalancing.VrackStateEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _ipLoadbalancing.VrackStateEnum State { get; set; }//;
        
        // Key: task Type: long[] FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("task")]
        public long[] Task { get; set; }//;
        
        // Key: vrackName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackName")]
        public System.String? VrackName { get; set; }//;
    }
    
    // Id: VrackNetworkCreationRules Namespace: ipLoadbalancing
    public class VrackNetworkCreationRules {
        
        // Key: minNatIps Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minNatIps")]
        public long MinNatIps { get; set; }//;
        
        // Key: remainingNetworks Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("remainingNetworks")]
        public long RemainingNetworks { get; set; }//;
        
        // Key: vrackName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vrackName")]
        public string VrackName { get; set; }//;
    }
    
    // Id: VrackStateEnum Namespace: ipLoadbalancing
    public enum VrackStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activating")]
        activating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("active")]
        active,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deactivating")]
        deactivating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("inactive")]
        inactive,
    }
    
    // Id: VrackTransparentGateways Namespace: ipLoadbalancing
    public class VrackTransparentGateways {
        
        // Key: address Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("address")]
        public string Address { get; set; }//;
        
        // Key: gateway Type: ip FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gateway")]
        public string Gateway { get; set; }//;
        
        // Key: vlan Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vlan")]
        public long Vlan { get; set; }//;
    }
}
