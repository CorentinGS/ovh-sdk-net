//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _connectivity_maintenance {
    
    
    // Id: InterventionTypeEnum Namespace: connectivity.maintenance
    public enum InterventionTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BACKBONE_MAINTENANCE")]
        BACKBONE_MAINTENANCE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CARD_SWAP_WITH_IMPACT")]
        CARD_SWAP_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CLUSTER_AN_ROUTER_MIGRATION")]
        CLUSTER_AN_ROUTER_MIGRATION,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CORRECTIVE_MAINTENANCE")]
        CORRECTIVE_MAINTENANCE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DSLAM_LINK_UPGRADE_WITHOUT_CARD_SWAP")]
        DSLAM_LINK_UPGRADE_WITHOUT_CARD_SWAP,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DSLAM_UPGRADE_WITH_IMPACT")]
        DSLAM_UPGRADE_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FIBER_CABLE_LINK_SWAP")]
        FIBER_CABLE_LINK_SWAP,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FIBER_CONNECTION_WITH_IMPACT")]
        FIBER_CONNECTION_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FIBER_MAINTENANCE")]
        FIBER_MAINTENANCE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("FIBER_THIRD_PARTY_WORK_WITH_IMPACT")]
        FIBER_THIRD_PARTY_WORK_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("IP_BACKBONE_LINK_MIGRATION_WITH_IMPACT")]
        IP_BACKBONE_LINK_MIGRATION_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("IP_BACKBONE_SWITCH_UPGRADE_WITH_IMPACT")]
        IP_BACKBONE_SWITCH_UPGRADE_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("IP_MAINTENANCE")]
        IP_MAINTENANCE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LEVEL2_DSLAM_MIGRATION")]
        LEVEL2_DSLAM_MIGRATION,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LINK_MIGRATION_WITH_DSL_IMPACT")]
        LINK_MIGRATION_WITH_DSL_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LL_THIRD_PARTY_MAINTENANCE_WITH_IMPACT")]
        LL_THIRD_PARTY_MAINTENANCE_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LOOP_AN_ROUTER_MIGRATION")]
        LOOP_AN_ROUTER_MIGRATION,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LOOP_AN_ROUTER_UPGRADE")]
        LOOP_AN_ROUTER_UPGRADE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MAINTENANCE")]
        MAINTENANCE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("OPTIC_FIBER_WORK_WITH_OUTAGE_DURING_NON_WORKING_HOURS")]
        OPTIC_FIBER_WORK_WITH_OUTAGE_DURING_NON_WORKING_HOURS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PLANNED_CORRECTIVE_MAINTENANCE")]
        PLANNED_CORRECTIVE_MAINTENANCE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SENSITIVE_LOOP_LINK_UPGRADE")]
        SENSITIVE_LOOP_LINK_UPGRADE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TRANSMISSION_CORRECTIVE_MAINTENANCE")]
        TRANSMISSION_CORRECTIVE_MAINTENANCE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TRANSMISSION_CUSTOMER_TRANSFERT_MIGRATION_WITH_IMPACT")]
        TRANSMISSION_CUSTOMER_TRANSFERT_MIGRATION_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TRANSMISSION_FIBRE_MAINTENANCE")]
        TRANSMISSION_FIBRE_MAINTENANCE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TRANSMISSION_LINK_COMMISSIONING_PRODUCTION_DECOMMISSIONING_WORK_WITH_IMPACT")]
        TRANSMISSION_LINK_COMMISSIONING_PRODUCTION_DECOMMISSIONING_WORK_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TRANSMISSION_LINK_TRANSFERT_MIGRATION_WITH_IMPACT")]
        TRANSMISSION_LINK_TRANSFERT_MIGRATION_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TRANSMISSION_MAINTENANCE")]
        TRANSMISSION_MAINTENANCE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TRANSMISSION_MOVING_WITH_IMPACT")]
        TRANSMISSION_MOVING_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TRANSMISSION_SWITCH_UPGRADE_WITH_IMPACT")]
        TRANSMISSION_SWITCH_UPGRADE_WITH_IMPACT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("WITH_IMPACT")]
        WITH_IMPACT,
    }
    
    // Id: WorkPlanned Namespace: connectivity.maintenance
    public class WorkPlanned {
        
        // Key: dateBegin Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dateBegin")]
        public string DateBegin { get; set; }//;
        
        // Key: dateEnd Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dateEnd")]
        public string DateEnd { get; set; }//;
        
        // Key: departments Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("departments")]
        public string[] Departments { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: duration Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public System.TimeSpan Duration { get; set; }//;
        
        // Key: fallback Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fallback")]
        public bool Fallback { get; set; }//;
        
        // Key: fallbackDateBegin Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fallbackDateBegin")]
        public System.DateTime FallbackDateBegin { get; set; }//;
        
        // Key: fallbackDateEnd Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fallbackDateEnd")]
        public System.DateTime FallbackDateEnd { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: impact Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("impact")]
        public string Impact { get; set; }//;
        
        // Key: interventionType Type: connectivity.maintenance.InterventionTypeEnum FullType: connectivity.maintenance.InterventionTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("interventionType")]
        public _connectivity_maintenance.InterventionTypeEnum InterventionType { get; set; }//;
        
        // Key: nras Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nras")]
        public string[] Nras { get; set; }//;
        
        // Key: operator Type: connectivity.OperatorEnum FullType: connectivity.OperatorEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operator")]
        public _connectivity.OperatorEnum @operator { get; set; }//;
        
        // Key: technology Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("technology")]
        public string Technology { get; set; }//;
        
        // Key: zone Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zone")]
        public string Zone { get; set; }//;
    }
}