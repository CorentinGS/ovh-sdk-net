//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_billingView {
    
    
    // Id: BandwidthInstance Namespace: cloud.billingView
    public class BandwidthInstance {
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: BandwidthStorage Namespace: cloud.billingView
    public class BandwidthStorage {
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: Component Namespace: cloud.billingView
    public class Component {
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: HourlyInstance Namespace: cloud.billingView
    public class HourlyInstance {
        
        // Key: details Type: cloud.billingView.HourlyInstanceDetail[] FullType: cloud.billingView.HourlyInstanceDetail[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public _cloud_billingView.HourlyInstanceDetail[] Details { get; set; }//;
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: reference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reference")]
        public string Reference { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: HourlyInstanceBandwidth Namespace: cloud.billingView
    public class HourlyInstanceBandwidth {
        
        // Key: incomingBandwidth Type: cloud.billingView.BandwidthInstance FullType: cloud.billingView.BandwidthInstance
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("incomingBandwidth")]
        public _cloud_billingView.BandwidthInstance IncomingBandwidth { get; set; }//;
        
        // Key: outgoingBandwidth Type: cloud.billingView.BandwidthInstance FullType: cloud.billingView.BandwidthInstance
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("outgoingBandwidth")]
        public _cloud_billingView.BandwidthInstance OutgoingBandwidth { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: HourlyInstanceDetail Namespace: cloud.billingView
    public class HourlyInstanceDetail {
        
        // Key: instanceId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instanceId")]
        public string InstanceId { get; set; }//;
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: HourlyInstanceOption Namespace: cloud.billingView
    public class HourlyInstanceOption {
        
        // Key: details Type: cloud.billingView.HourlyInstanceOptionDetail[] FullType: cloud.billingView.HourlyInstanceOptionDetail[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public _cloud_billingView.HourlyInstanceOptionDetail[] Details { get; set; }//;
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: reference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reference")]
        public string Reference { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: HourlyInstanceOptionDetail Namespace: cloud.billingView
    public class HourlyInstanceOptionDetail {
        
        // Key: instanceId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instanceId")]
        public string InstanceId { get; set; }//;
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: HourlyResources Namespace: cloud.billingView
    public class HourlyResources {
        
        // Key: instance Type: cloud.billingView.HourlyInstance[] FullType: cloud.billingView.HourlyInstance[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instance")]
        public _cloud_billingView.HourlyInstance[] Instance { get; set; }//;
        
        // Key: instanceBandwidth Type: cloud.billingView.HourlyInstanceBandwidth[] FullType: cloud.billingView.HourlyInstanceBandwidth[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instanceBandwidth")]
        public _cloud_billingView.HourlyInstanceBandwidth[] InstanceBandwidth { get; set; }//;
        
        // Key: instanceOption Type: cloud.billingView.HourlyInstanceOption[] FullType: cloud.billingView.HourlyInstanceOption[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instanceOption")]
        public _cloud_billingView.HourlyInstanceOption[] InstanceOption { get; set; }//;
        
        // Key: snapshot Type: cloud.billingView.HourlySnapshot[] FullType: cloud.billingView.HourlySnapshot[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("snapshot")]
        public _cloud_billingView.HourlySnapshot[] Snapshot { get; set; }//;
        
        // Key: storage Type: cloud.billingView.HourlyStorage[] FullType: cloud.billingView.HourlyStorage[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage")]
        public _cloud_billingView.HourlyStorage[] Storage { get; set; }//;
        
        // Key: volume Type: cloud.billingView.HourlyVolume[] FullType: cloud.billingView.HourlyVolume[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("volume")]
        public _cloud_billingView.HourlyVolume[] Volume { get; set; }//;
    }
    
    // Id: HourlySnapshot Namespace: cloud.billingView
    public class HourlySnapshot {
        
        // Key: instance Type: cloud.billingView.InstanceSnapshot FullType: cloud.billingView.InstanceSnapshot
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instance")]
        public _cloud_billingView.InstanceSnapshot Instance { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
        
        // Key: volume Type: cloud.billingView.VolumeSnapshot FullType: cloud.billingView.VolumeSnapshot
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("volume")]
        public _cloud_billingView.VolumeSnapshot Volume { get; set; }//;
    }
    
    // Id: HourlyStorage Namespace: cloud.billingView
    public class HourlyStorage {
        
        // Key: bucketName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("bucketName")]
        public string BucketName { get; set; }//;
        
        // Key: incomingBandwidth Type: cloud.billingView.BandwidthStorage FullType: cloud.billingView.BandwidthStorage
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("incomingBandwidth")]
        public _cloud_billingView.BandwidthStorage IncomingBandwidth { get; set; }//;
        
        // Key: incomingInternalBandwidth Type: cloud.billingView.BandwidthStorage FullType: cloud.billingView.BandwidthStorage
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("incomingInternalBandwidth")]
        public _cloud_billingView.BandwidthStorage IncomingInternalBandwidth { get; set; }//;
        
        // Key: outgoingBandwidth Type: cloud.billingView.BandwidthStorage FullType: cloud.billingView.BandwidthStorage
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("outgoingBandwidth")]
        public _cloud_billingView.BandwidthStorage OutgoingBandwidth { get; set; }//;
        
        // Key: outgoingInternalBandwidth Type: cloud.billingView.BandwidthStorage FullType: cloud.billingView.BandwidthStorage
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("outgoingInternalBandwidth")]
        public _cloud_billingView.BandwidthStorage OutgoingInternalBandwidth { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: stored Type: cloud.billingView.StoredStorage FullType: cloud.billingView.StoredStorage
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("stored")]
        public _cloud_billingView.StoredStorage Stored { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
        
        // Key: type Type: cloud.billingView.StorageTypeEnum FullType: cloud.billingView.StorageTypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _cloud_billingView.StorageTypeEnum Type { get; set; }//;
    }
    
    // Id: HourlyVolume Namespace: cloud.billingView
    public class HourlyVolume {
        
        // Key: details Type: cloud.billingView.HourlyVolumeDetail[] FullType: cloud.billingView.HourlyVolumeDetail[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public _cloud_billingView.HourlyVolumeDetail[] Details { get; set; }//;
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: HourlyVolumeDetail Namespace: cloud.billingView
    public class HourlyVolumeDetail {
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
        
        // Key: volumeId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("volumeId")]
        public string VolumeId { get; set; }//;
    }
    
    // Id: InstanceSnapshot Namespace: cloud.billingView
    public class InstanceSnapshot {
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: MonthlyCertification Namespace: cloud.billingView
    public class MonthlyCertification {
        
        // Key: details Type: cloud.billingView.MonthlyCertificationDetail[] FullType: cloud.billingView.MonthlyCertificationDetail[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public _cloud_billingView.MonthlyCertificationDetail[] Details { get; set; }//;
        
        // Key: reference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reference")]
        public string Reference { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: MonthlyCertificationDetail Namespace: cloud.billingView
    public class MonthlyCertificationDetail {
        
        // Key: activation Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activation")]
        public System.DateTime Activation { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: MonthlyInstance Namespace: cloud.billingView
    public class MonthlyInstance {
        
        // Key: details Type: cloud.billingView.MonthlyInstanceDetail[] FullType: cloud.billingView.MonthlyInstanceDetail[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public _cloud_billingView.MonthlyInstanceDetail[] Details { get; set; }//;
        
        // Key: reference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reference")]
        public string Reference { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: MonthlyInstanceDetail Namespace: cloud.billingView
    public class MonthlyInstanceDetail {
        
        // Key: activation Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activation")]
        public System.DateTime Activation { get; set; }//;
        
        // Key: instanceId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instanceId")]
        public string InstanceId { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: MonthlyInstanceOption Namespace: cloud.billingView
    public class MonthlyInstanceOption {
        
        // Key: details Type: cloud.billingView.MonthlyInstanceOptionDetail[] FullType: cloud.billingView.MonthlyInstanceOptionDetail[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public _cloud_billingView.MonthlyInstanceOptionDetail[] Details { get; set; }//;
        
        // Key: reference Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reference")]
        public string Reference { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: MonthlyInstanceOptionDetail Namespace: cloud.billingView
    public class MonthlyInstanceOptionDetail {
        
        // Key: instanceId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instanceId")]
        public string InstanceId { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: MonthlyResources Namespace: cloud.billingView
    public class MonthlyResources {
        
        // Key: certification Type: cloud.billingView.MonthlyCertification[] FullType: cloud.billingView.MonthlyCertification[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("certification")]
        public _cloud_billingView.MonthlyCertification[] Certification { get; set; }//;
        
        // Key: instance Type: cloud.billingView.MonthlyInstance[] FullType: cloud.billingView.MonthlyInstance[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instance")]
        public _cloud_billingView.MonthlyInstance[] Instance { get; set; }//;
        
        // Key: instanceOption Type: cloud.billingView.MonthlyInstanceOption[] FullType: cloud.billingView.MonthlyInstanceOption[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("instanceOption")]
        public _cloud_billingView.MonthlyInstanceOption[] InstanceOption { get; set; }//;
    }
    
    // Id: Quantity Namespace: cloud.billingView
    public class Quantity {
        
        // Key: unit Type: cloud.billingView.UnitQuantityEnum FullType: cloud.billingView.UnitQuantityEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unit")]
        public _cloud_billingView.UnitQuantityEnum Unit { get; set; }//;
        
        // Key: value Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public double Value { get; set; }//;
    }
    
    // Id: RegionalizedResource Namespace: cloud.billingView
    public class RegionalizedResource {
        
        // Key: components Type: cloud.billingView.Component[] FullType: cloud.billingView.Component[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("components")]
        public _cloud_billingView.Component[] Components { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
    }
    
    // Id: StorageTypeEnum Namespace: cloud.billingView
    public enum StorageTypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pca")]
        pca,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pcs")]
        pcs,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage-coldarchive")]
        storage_coldarchive,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage-high-perf")]
        storage_high_perf,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("storage-standard")]
        storage_standard,
    }
    
    // Id: StoredStorage Namespace: cloud.billingView
    public class StoredStorage {
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
    
    // Id: TypedResources Namespace: cloud.billingView
    public class TypedResources {
        
        // Key: resources Type: cloud.billingView.RegionalizedResource[] FullType: cloud.billingView.RegionalizedResource[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("resources")]
        public _cloud_billingView.RegionalizedResource[] Resources { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
        
        // Key: type Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public string Type { get; set; }//;
    }
    
    // Id: UnitQuantityEnum Namespace: cloud.billingView
    public enum UnitQuantityEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GiB")]
        GiB,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("GiBh")]
        GiBh,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Hour")]
        Hour,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Minute")]
        Minute,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Second")]
        Second,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Unit")]
        Unit,
    }
    
    // Id: UsedCredit Namespace: cloud.billingView
    public class UsedCredit {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string Description { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: usedAmount Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("usedAmount")]
        public double UsedAmount { get; set; }//;
    }
    
    // Id: UsedCredits Namespace: cloud.billingView
    public class UsedCredits {
        
        // Key: details Type: cloud.billingView.UsedCredit[] FullType: cloud.billingView.UsedCredit[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public _cloud_billingView.UsedCredit[] Details { get; set; }//;
        
        // Key: totalCredit Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalCredit")]
        public double TotalCredit { get; set; }//;
    }
    
    // Id: VolumeSnapshot Namespace: cloud.billingView
    public class VolumeSnapshot {
        
        // Key: quantity Type: cloud.billingView.Quantity FullType: cloud.billingView.Quantity
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public _cloud_billingView.Quantity Quantity { get; set; }//;
        
        // Key: totalPrice Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public double TotalPrice { get; set; }//;
    }
}