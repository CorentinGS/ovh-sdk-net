//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _me_credit_balance {
    
    
    // Id: BalanceDetails Namespace: me.credit.balance
    public class BalanceDetails {
        
        // Key: amount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("amount")]
        public _order.Price Amount { get; set; }//;
        
        // Key: balanceSubName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("balanceSubName")]
        public string BalanceSubName { get; set; }//;
        
        // Key: expiring Type: me.credit.balance.ExpiringMovement[] FullType: me.credit.balance.ExpiringMovement[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expiring")]
        public _me_credit_balance.ExpiringMovement[] Expiring { get; set; }//;
        
        // Key: serviceId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceId")]
        public long ServiceId { get; set; }//;
    }
    
    // Id: BookedMovement Namespace: me.credit.balance
    public class BookedMovement {
        
        // Key: amount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("amount")]
        public _order.Price Amount { get; set; }//;
        
        // Key: balanceSubName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("balanceSubName")]
        public string BalanceSubName { get; set; }//;
        
        // Key: orderId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderId")]
        public long OrderId { get; set; }//;
    }
    
    // Id: ExpiringMovement Namespace: me.credit.balance
    public class ExpiringMovement {
        
        // Key: amount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("amount")]
        public _order.Price Amount { get; set; }//;
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public System.DateTime CreationDate { get; set; }//;
        
        // Key: expirationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expirationDate")]
        public System.DateTime ExpirationDate { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime LastUpdate { get; set; }//;
        
        // Key: sourceObject Type: me.credit.balance.movement.SubObject FullType: me.credit.balance.movement.SubObject
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sourceObject")]
        public _me_credit_balance_movement.SubObject SourceObject { get; set; }//;
    }
    
    // Id: Movement Namespace: me.credit.balance
    public class Movement {
        
        // Key: amount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("amount")]
        public _order.Price Amount { get; set; }//;
        
        // Key: balanceName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("balanceName")]
        public string BalanceName { get; set; }//;
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public System.DateTime CreationDate { get; set; }//;
        
        // Key: destinationObject Type: me.credit.balance.movement.SubObject FullType: me.credit.balance.movement.SubObject
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("destinationObject")]
        public _me_credit_balance_movement.SubObject DestinationObject { get; set; }//;
        
        // Key: expirationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expirationDate")]
        public System.DateTime ExpirationDate { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime LastUpdate { get; set; }//;
        
        // Key: movementId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("movementId")]
        public long MovementId { get; set; }//;
        
        // Key: orderId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderId")]
        public long OrderId { get; set; }//;
        
        // Key: sourceObject Type: me.credit.balance.movement.SubObject FullType: me.credit.balance.movement.SubObject
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sourceObject")]
        public _me_credit_balance_movement.SubObject SourceObject { get; set; }//;
        
        // Key: type Type: me.credit.balance.movement.TypeEnum FullType: me.credit.balance.movement.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _me_credit_balance_movement.TypeEnum Type { get; set; }//;
    }
    
    // Id: TypeEnum Namespace: me.credit.balance
    public enum TypeEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("BONUS")]
        BONUS,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DEPOSIT")]
        DEPOSIT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("PREPAID_ACCOUNT")]
        PREPAID_ACCOUNT,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("VOUCHER")]
        VOUCHER,
    }
}