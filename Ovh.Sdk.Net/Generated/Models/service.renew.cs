//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _service_renew {
    
    
    // Id: Interval Namespace: service.renew
    public enum Interval {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("P1M")]
        P1M,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("P1Y")]
        P1Y,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("P2Y")]
        P2Y,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("P3M")]
        P3M,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("P3Y")]
        P3Y,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("P6M")]
        P6M,
    }
    
    // Id: Mode Namespace: service.renew
    public enum Mode {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("automaticForcedProduct")]
        automaticForcedProduct,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("automaticV2012")]
        automaticV2012,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("automaticV2014")]
        automaticV2014,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("automaticV2016")]
        automaticV2016,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteAtEndEngagement")]
        deleteAtEndEngagement,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("deleteAtExpiration")]
        deleteAtExpiration,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("manual")]
        manual,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("oneShot")]
        oneShot,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("option")]
        option,
    }
    
    // Id: RenewDescription Namespace: service.renew
    public class RenewDescription {
        
        // Key: renewPeriod Type: string FullType: duration:string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("renewPeriod")]
        public string RenewPeriod { get; set; }//;
        
        // Key: strategies Type: service.renew.RenewStrategy[] FullType: service.renew.RenewStrategy[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("strategies")]
        public _service_renew.RenewStrategy[] Strategies { get; set; }//;
    }
    
    // Id: RenewForecast Namespace: service.renew
    public class RenewForecast {
        
        // Key: details Type: service.renew.RenewForecastDetail[] FullType: service.renew.RenewForecastDetail[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("details")]
        public _service_renew.RenewForecastDetail[] Details { get; set; }//;
        
        // Key: prices Type: service.renew.RenewForecastPrices FullType: service.renew.RenewForecastPrices
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("prices")]
        public _service_renew.RenewForecastPrices Prices { get; set; }//;
    }
    
    // Id: RenewForecastDetail Namespace: service.renew
    public class RenewForecastDetail {
        
        // Key: description Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public System.String? Description { get; set; }//;
        
        // Key: quantity Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("quantity")]
        public long Quantity { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public string ServiceName { get; set; }//;
        
        // Key: totalPrice Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("totalPrice")]
        public _order.Price TotalPrice { get; set; }//;
        
        // Key: unitPrice Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unitPrice")]
        public _order.Price UnitPrice { get; set; }//;
    }
    
    // Id: RenewForecastDetailPrices Namespace: service.renew
    public class RenewForecastPrices {
        
        // Key: tax Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tax")]
        public _order.Price Tax { get; set; }//;
        
        // Key: withTax Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("withTax")]
        public _order.Price WithTax { get; set; }//;
        
        // Key: withoutTax Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("withoutTax")]
        public _order.Price WithoutTax { get; set; }//;
    }
    
    // Id: RenewOrder Namespace: service.renew
    public class RenewOrder {
        
        // Key: date Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("date")]
        public System.DateTime? Date { get; set; }//;
        
        // Key: expirationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expirationDate")]
        public System.DateTime? ExpirationDate { get; set; }//;
        
        // Key: orderId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderId")]
        public long OrderId { get; set; }//;
        
        // Key: password Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public string Password { get; set; }//;
        
        // Key: pdfUrl Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pdfUrl")]
        public string PdfUrl { get; set; }//;
        
        // Key: priceWithTax Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("priceWithTax")]
        public _order.Price PriceWithTax { get; set; }//;
        
        // Key: priceWithoutTax Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("priceWithoutTax")]
        public _order.Price PriceWithoutTax { get; set; }//;
        
        // Key: retractionDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("retractionDate")]
        public System.DateTime? RetractionDate { get; set; }//;
        
        // Key: tax Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tax")]
        public _order.Price Tax { get; set; }//;
        
        // Key: url Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("url")]
        public string Url { get; set; }//;
    }
    
    // Id: RenewStrategy Namespace: service.renew
    public class RenewStrategy {
        
        // Key: price Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public _order.Price Price { get; set; }//;
        
        // Key: priceInUcents Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("priceInUcents")]
        public long PriceInUcents { get; set; }//;
        
        // Key: services Type: long[] FullType: coreTypes.ServiceId[]:long[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("services")]
        public long[] Services { get; set; }//;
        
        // Key: servicesDetails Type: service.renew.Service[] FullType: service.renew.Service[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("servicesDetails")]
        public _service_renew.Service[] ServicesDetails { get; set; }//;
    }
    
    // Id: Service Namespace: service.renew
    public class Service {
        
        // Key: serviceId Type: long FullType: coreTypes.ServiceId:long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceId")]
        public long ServiceId { get; set; }//;
        
        // Key: serviceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceName")]
        public string ServiceName { get; set; }//;
        
        // Key: serviceType Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceType")]
        public string ServiceType { get; set; }//;
    }
}
