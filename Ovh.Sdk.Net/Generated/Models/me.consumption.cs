//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _me_consumption {
    
    
    // Id: Price Namespace: me.consumption
    public class Price {
        
        // Key: currencyCode Type: order.CurrencyCodeEnum FullType: order.CurrencyCodeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("currencyCode")]
        public _order.CurrencyCodeEnum CurrencyCode { get; set; }//;
        
        // Key: text Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("text")]
        public string Text { get; set; }//;
        
        // Key: value Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("value")]
        public double Value { get; set; }//;
        
        // Key: valueInUcents Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("valueInUcents")]
        public long ValueInUcents { get; set; }//;
    }
    
    // Id: Transaction Namespace: me.consumption
    public class Transaction {
        
        // Key: beginDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("beginDate")]
        public System.DateTime BeginDate { get; set; }//;
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public System.DateTime CreationDate { get; set; }//;
        
        // Key: elements Type: me.consumption.transaction.Element[] FullType: me.consumption.transaction.Element[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("elements")]
        public _me_consumption_transaction.Element[] Elements { get; set; }//;
        
        // Key: endDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("endDate")]
        public System.DateTime EndDate { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime LastUpdate { get; set; }//;
        
        // Key: price Type: me.consumption.Price FullType: me.consumption.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("price")]
        public _me_consumption.Price Price { get; set; }//;
        
        // Key: serviceId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceId")]
        public long ServiceId { get; set; }//;
    }
}