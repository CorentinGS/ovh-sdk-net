//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cluster_hadoop {
    
    
    // Id: BillingNameEnum Namespace: cluster.hadoop
    public enum BillingNameEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("100-small")]
        _100_small,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("200-cpu-1")]
        _200_cpu_1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("220-cpu-3")]
        _220_cpu_3,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("300-disk-1")]
        _300_disk_1,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("310-disk-3")]
        _310_disk_3,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("900-vm-1")]
        _900_vm_1,
    }
    
    // Id: ClusterConsumption Namespace: cluster.hadoop
    public class ClusterConsumption {
        
        // Key: quantity Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _complexType.UnitAndValue<long> Quantity { get; set; }//;
    }
    
    // Id: ClusterServiceNameEnum Namespace: cluster.hadoop
    public enum ClusterServiceNameEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("HBase")]
        HBase,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("HDFS")]
        HDFS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("HUE")]
        HUE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Hive")]
        Hive,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Oozie")]
        Oozie,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Solr")]
        Solr,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Spark")]
        Spark,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Sqoop")]
        Sqoop,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("YARN")]
        YARN,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ZooKeeper")]
        ZooKeeper,
    }
    
    // Id: ClusterStateEnum Namespace: cluster.hadoop
    public enum ClusterStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("created")]
        created,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creating")]
        creating,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleted")]
        deleted,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleting")]
        deleting,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("delivered")]
        delivered,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("delivering")]
        delivering,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("toDeliver")]
        toDeliver,
    }
    
    // Id: NetworkAcl Namespace: cluster.hadoop
    public class NetworkAcl {
        
        // Key: block Type: ipBlock FullType: ipBlock
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("block")]
        public string Block { get; set; }//;
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: state Type: cluster.hadoop.NetworkAclStateEnum FullType: cluster.hadoop.NetworkAclStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _cluster_hadoop.NetworkAclStateEnum State { get; set; }//;
    }
    
    // Id: NetworkAclStateEnum Namespace: cluster.hadoop
    public enum NetworkAclStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("disabled")]
        disabled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enabled")]
        enabled,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pending")]
        pending,
    }
    
    // Id: Node Namespace: cluster.hadoop
    public class Node {
        
        // Key: billingProfileName Type: cluster.hadoop.BillingNameEnum FullType: cluster.hadoop.BillingNameEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("billingProfileName")]
        public _cluster_hadoop.BillingNameEnum BillingProfileName { get; set; }//;
        
        // Key: hostname Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostname")]
        public string Hostname { get; set; }//;
        
        // Key: ip Type: ip FullType: ip
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ip")]
        public string Ip { get; set; }//;
        
        // Key: isRemovable Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isRemovable")]
        public bool IsRemovable { get; set; }//;
        
        // Key: softwareProfile Type: cluster.hadoop.NodeProfileEnum FullType: cluster.hadoop.NodeProfileEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("softwareProfile")]
        public _cluster_hadoop.NodeProfileEnum SoftwareProfile { get; set; }//;
        
        // Key: state Type: cluster.hadoop.NodeStateEnum FullType: cluster.hadoop.NodeStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _cluster_hadoop.NodeStateEnum State { get; set; }//;
    }
    
    // Id: NodeBillingProfile Namespace: cluster.hadoop
    public class NodeBillingProfile {
        
        // Key: CPUFrequency Type: complexType.UnitAndValue<double> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CPUFrequency")]
        public _complexType.UnitAndValue<double> CPUFrequency { get; set; }//;
        
        // Key: diskCapacity Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("diskCapacity")]
        public _complexType.UnitAndValue<long> DiskCapacity { get; set; }//;
        
        // Key: nbCPUCores Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nbCPUCores")]
        public long NbCPUCores { get; set; }//;
        
        // Key: nbCPUThreads Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nbCPUThreads")]
        public long NbCPUThreads { get; set; }//;
        
        // Key: networkBandwidth Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("networkBandwidth")]
        public _complexType.UnitAndValue<long> NetworkBandwidth { get; set; }//;
        
        // Key: nodeProfile Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nodeProfile")]
        public string NodeProfile { get; set; }//;
        
        // Key: ramQuantity Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ramQuantity")]
        public _complexType.UnitAndValue<long> RamQuantity { get; set; }//;
    }
    
    // Id: NodeConsumption Namespace: cluster.hadoop
    public class NodeConsumption {
        
        // Key: hostname Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hostname")]
        public string Hostname { get; set; }//;
        
        // Key: nodeProfile Type: cluster.hadoop.BillingNameEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nodeProfile")]
        public _cluster_hadoop.BillingNameEnum NodeProfile { get; set; }//;
        
        // Key: quantity Type: complexType.UnitAndValue<long> FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _complexType.UnitAndValue<long> Quantity { get; set; }//;
    }
    
    // Id: NodeProfileEnum Namespace: cluster.hadoop
    public enum NodeProfileEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ApplicationServer")]
        ApplicationServer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BasicNode")]
        BasicNode,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ClouderaManager")]
        ClouderaManager,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MasterServer")]
        MasterServer,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("SecondaryServer")]
        SecondaryServer,
    }
    
    // Id: NodeStateEnum Namespace: cluster.hadoop
    public enum NodeStateEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("available")]
        available,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("delivered")]
        delivered,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("toDeploy")]
        toDeploy,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unavailable")]
        unavailable,
    }
    
    // Id: OperationStateEnum Namespace: cluster.hadoop
    public enum OperationStateEnum {
        
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
    
    // Id: OrderInformations Namespace: cluster.hadoop
    public class OrderInformations {
        
        // Key: maximumOrderableNodes Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maximumOrderableNodes")]
        public long MaximumOrderableNodes { get; set; }//;
        
        // Key: minimumOrderableNodes Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minimumOrderableNodes")]
        public long MinimumOrderableNodes { get; set; }//;
    }
    
    // Id: Role Namespace: cluster.hadoop
    public class Role {
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: type Type: cluster.hadoop.RoleTypeEnum FullType: cluster.hadoop.RoleTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _cluster_hadoop.RoleTypeEnum Type { get; set; }//;
    }
    
    // Id: RoleTypeEnum Namespace: cluster.hadoop
    public enum RoleTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cloudera_manager")]
        cloudera_manager,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("data_node")]
        data_node,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("elasticsearch_server")]
        elasticsearch_server,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hbase_master")]
        hbase_master,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hbase_region_server")]
        hbase_region_server,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hive_server2")]
        hive_server2,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hue")]
        hue,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("impala_daemon")]
        impala_daemon,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("impala_server")]
        impala_server,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("map_reduce_history_server")]
        map_reduce_history_server,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name_node")]
        name_node,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("oozie_server")]
        oozie_server,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("open_tsdb")]
        open_tsdb,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("secondary_name_node")]
        secondary_name_node,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("solr_server")]
        solr_server,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("spark_master")]
        spark_master,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("spark_worker")]
        spark_worker,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sqoop_server")]
        sqoop_server,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("yarn_node_manager")]
        yarn_node_manager,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("yarn_resource_manager")]
        yarn_resource_manager,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("zoo_keeper")]
        zoo_keeper,
    }
    
    // Id: Task Namespace: cluster.hadoop
    public class Task {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: status Type: cluster.hadoop.OperationStateEnum FullType: cluster.hadoop.OperationStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _cluster_hadoop.OperationStateEnum Status { get; set; }//;
        
        // Key: taskId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("taskId")]
        public long TaskId { get; set; }//;
    }
    
    // Id: User Namespace: cluster.hadoop
    public class User {
        
        // Key: clouderaManager Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clouderaManager")]
        public bool ClouderaManager { get; set; }//;
        
        // Key: httpFrontend Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("httpFrontend")]
        public bool HttpFrontend { get; set; }//;
        
        // Key: hue Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hue")]
        public bool Hue { get; set; }//;
        
        // Key: username Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("username")]
        public string Username { get; set; }//;
    }
    
    // Id: hadoop Namespace: cluster.hadoop
    public class hadoop {
        
        // Key: clouderaVersion Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clouderaVersion")]
        public string ClouderaVersion { get; set; }//;
        
        // Key: maxOrderableNodes Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxOrderableNodes")]
        public long MaxOrderableNodes { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: state Type: cluster.hadoop.ClusterStateEnum FullType: cluster.hadoop.ClusterStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _cluster_hadoop.ClusterStateEnum State { get; set; }//;
    }
    
    // Id: hadoop Namespace: cluster.hadoop
    public class hadoopWithIAM {
        
        // Key: clouderaVersion Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("clouderaVersion")]
        public string ClouderaVersion { get; set; }//;
        
        // Key: iam Type: iam.ResourceMetadata FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("iam")]
        public _iam.ResourceMetadata? Iam { get; set; }//;
        
        // Key: maxOrderableNodes Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxOrderableNodes")]
        public long MaxOrderableNodes { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: state Type: cluster.hadoop.ClusterStateEnum FullType: cluster.hadoop.ClusterStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _cluster_hadoop.ClusterStateEnum State { get; set; }//;
    }
}
