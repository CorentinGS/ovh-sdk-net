//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _vps_ip {
    
    
    // Id: GeolocationEnum Namespace: vps.ip
    public enum GeolocationEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("au")]
        au,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("be")]
        be,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ca")]
        ca,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cz")]
        cz,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("de")]
        de,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("es")]
        es,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fi")]
        fi,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fr")]
        fr,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gb")]
        gb,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ie")]
        ie,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("it")]
        it,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lt")]
        lt,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nl")]
        nl,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pl")]
        pl,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pt")]
        pt,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sg")]
        sg,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("uk")]
        uk,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("us")]
        us,
    }
    
    // Id: ServiceStatus Namespace: vps.ip
    public class ServiceStatus {
        
        // Key: dns Type: vps.ip.ServiceStatusService FullType: vps.ip.ServiceStatusService
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dns")]
        public _vps_ip.ServiceStatusService Dns { get; set; }//;
        
        // Key: http Type: vps.ip.ServiceStatusService FullType: vps.ip.ServiceStatusService
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("http")]
        public _vps_ip.ServiceStatusService Http { get; set; }//;
        
        // Key: https Type: vps.ip.ServiceStatusService FullType: vps.ip.ServiceStatusService
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("https")]
        public _vps_ip.ServiceStatusService Https { get; set; }//;
        
        // Key: ping Type: vps.ip.ServiceStatusStateEnum FullType: vps.ip.ServiceStatusStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ping")]
        public _vps_ip.ServiceStatusStateEnum Ping { get; set; }//;
        
        // Key: smtp Type: vps.ip.ServiceStatusService FullType: vps.ip.ServiceStatusService
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("smtp")]
        public _vps_ip.ServiceStatusService Smtp { get; set; }//;
        
        // Key: ssh Type: vps.ip.ServiceStatusService FullType: vps.ip.ServiceStatusService
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ssh")]
        public _vps_ip.ServiceStatusService Ssh { get; set; }//;
        
        // Key: tools Type: vps.ip.ServiceStatusStateEnum FullType: vps.ip.ServiceStatusStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tools")]
        public _vps_ip.ServiceStatusStateEnum? Tools { get; set; }//;
    }
    
    // Id: ServiceStatusService Namespace: vps.ip
    public class ServiceStatusService {
        
        // Key: port Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("port")]
        public long Port { get; set; }//;
        
        // Key: state Type: vps.ip.ServiceStatusStateEnum FullType: vps.ip.ServiceStatusStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _vps_ip.ServiceStatusStateEnum State { get; set; }//;
    }
    
    // Id: ServiceStatusStateEnum Namespace: vps.ip
    public enum ServiceStatusStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("down")]
        down,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("up")]
        up,
    }
    
    // Id: TypeEnum Namespace: vps.ip
    public enum TypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("additional")]
        additional,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("primary")]
        primary,
    }
}
