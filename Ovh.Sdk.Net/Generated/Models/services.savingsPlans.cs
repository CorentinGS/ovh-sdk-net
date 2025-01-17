//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _services_savingsPlans {
    
    
    // Id: ChangePeriodEndAction Namespace: services.savingsPlans
    public class ChangePeriodEndAction {
        
        // Key: periodEndAction Type: services.savingsPlans.PeriodEndActionEnum FullType: services.savingsPlans.PeriodEndActionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("periodEndAction")]
        public _services_savingsPlans.PeriodEndActionEnum PeriodEndAction { get; set; }//;
    }
    
    // Id: ChangeSize Namespace: services.savingsPlans
    public class ChangeSize {
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public long Size { get; set; }//;
    }
    
    // Id: PeriodEndActionEnum Namespace: services.savingsPlans
    public enum PeriodEndActionEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REACTIVATE")]
        REACTIVATE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TERMINATE")]
        TERMINATE,
    }
    
    // Id: PlannedChange Namespace: services.savingsPlans
    public class PlannedChange {
        
        // Key: plannedOn Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plannedOn")]
        public System.DateOnly PlannedOn { get; set; }//;
        
        // Key: properties Type: services.savingsPlans.PlannedChangeProperties FullType: services.savingsPlans.PlannedChangeProperties
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("properties")]
        public _services_savingsPlans.PlannedChangeProperties Properties { get; set; }//;
    }
    
    // Id: PlannedChangeProperties Namespace: services.savingsPlans
    public class PlannedChangeProperties {
        
        // Key: status Type: services.savingsPlans.StatusEnum FullType: services.savingsPlans.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _services_savingsPlans.StatusEnum Status { get; set; }//;
    }
    
    // Id: SavingsPlan Namespace: services.savingsPlans
    public class SavingsPlan {
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public string DisplayName { get; set; }//;
        
        // Key: endDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateOnly EndDate { get; set; }//;
        
        // Key: flavor Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("flavor")]
        public string Flavor { get; set; }//;
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: offerId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offerId")]
        public string OfferId { get; set; }//;
        
        // Key: period Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("period")]
        public System.TimeSpan Period { get; set; }//;
        
        // Key: periodEndAction Type: services.savingsPlans.PeriodEndActionEnum FullType: services.savingsPlans.PeriodEndActionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("periodEndAction")]
        public _services_savingsPlans.PeriodEndActionEnum PeriodEndAction { get; set; }//;
        
        // Key: periodEndDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("periodEndDate")]
        public System.DateOnly PeriodEndDate { get; set; }//;
        
        // Key: periodStartDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("periodStartDate")]
        public System.DateOnly PeriodStartDate { get; set; }//;
        
        // Key: plannedChanges Type: services.savingsPlans.PlannedChange[] FullType: services.savingsPlans.PlannedChange[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("plannedChanges")]
        public _services_savingsPlans.PlannedChange[] PlannedChanges { get; set; }//;
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public long Size { get; set; }//;
        
        // Key: startDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public System.DateOnly StartDate { get; set; }//;
        
        // Key: status Type: services.savingsPlans.StatusEnum FullType: services.savingsPlans.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _services_savingsPlans.StatusEnum Status { get; set; }//;
        
        // Key: terminationDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("terminationDate")]
        public System.DateOnly? TerminationDate { get; set; }//;
    }
    
    // Id: SimulatedSavingsPlan Namespace: services.savingsPlans
    public class SimulatedSavingsPlan {
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public string DisplayName { get; set; }//;
        
        // Key: endDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateOnly EndDate { get; set; }//;
        
        // Key: flavor Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("flavor")]
        public string Flavor { get; set; }//;
        
        // Key: offerId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offerId")]
        public string OfferId { get; set; }//;
        
        // Key: period Type: duration FullType: duration
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("period")]
        public System.TimeSpan Period { get; set; }//;
        
        // Key: periodEndAction Type: services.savingsPlans.PeriodEndActionEnum FullType: services.savingsPlans.PeriodEndActionEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("periodEndAction")]
        public _services_savingsPlans.PeriodEndActionEnum PeriodEndAction { get; set; }//;
        
        // Key: periodEndDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("periodEndDate")]
        public System.DateOnly PeriodEndDate { get; set; }//;
        
        // Key: periodStartDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("periodStartDate")]
        public System.DateOnly PeriodStartDate { get; set; }//;
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public long Size { get; set; }//;
        
        // Key: startDate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("startDate")]
        public System.DateOnly StartDate { get; set; }//;
        
        // Key: status Type: services.savingsPlans.StatusEnum FullType: services.savingsPlans.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _services_savingsPlans.StatusEnum Status { get; set; }//;
    }
    
    // Id: StatusEnum Namespace: services.savingsPlans
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ACTIVE")]
        ACTIVE,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PENDING")]
        PENDING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("TERMINATED")]
        TERMINATED,
    }
    
    // Id: SubscribableSavingsPlanOffer Namespace: services.savingsPlans
    public class SubscribableSavingsPlanOffer {
        
        // Key: offerId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offerId")]
        public string OfferId { get; set; }//;
    }
    
    // Id: Subscribe Namespace: services.savingsPlans
    public class Subscribe {
        
        // Key: displayName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("displayName")]
        public string DisplayName { get; set; }//;
        
        // Key: offerId Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offerId")]
        public string OfferId { get; set; }//;
        
        // Key: size Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size")]
        public long Size { get; set; }//;
    }
}
