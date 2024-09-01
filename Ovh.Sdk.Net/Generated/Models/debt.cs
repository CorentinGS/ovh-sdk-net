//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _debt {
    
    
    // Id: Balance Namespace: debt
    public class Balance {
        
        // Key: active Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("active")]
        public bool Active { get; set; }//;
        
        // Key: dueAmount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dueAmount")]
        public _order.Price DueAmount { get; set; }//;
        
        // Key: pendingAmount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pendingAmount")]
        public _order.Price PendingAmount { get; set; }//;
        
        // Key: todoAmount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todoAmount")]
        public _order.Price TodoAmount { get; set; }//;
        
        // Key: unmaturedAmount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unmaturedAmount")]
        public _order.Price UnmaturedAmount { get; set; }//;
    }
    
    // Id: Debt Namespace: debt
    public class Debt {
        
        // Key: amount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("amount")]
        public _order.Price Amount { get; set; }//;
        
        // Key: date Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("date")]
        public System.DateTime Date { get; set; }//;
        
        // Key: debtId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("debtId")]
        public long DebtId { get; set; }//;
        
        // Key: dueAmount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dueAmount")]
        public _order.Price DueAmount { get; set; }//;
        
        // Key: dueDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dueDate")]
        public System.DateTime DueDate { get; set; }//;
        
        // Key: orderId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("orderId")]
        public long OrderId { get; set; }//;
        
        // Key: pendingAmount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pendingAmount")]
        public _order.Price PendingAmount { get; set; }//;
        
        // Key: status Type: debt.entry.StatusDebtOrderEnum FullType: debt.entry.StatusDebtOrderEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _debt_entry.StatusDebtOrderEnum Status { get; set; }//;
        
        // Key: todoAmount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("todoAmount")]
        public _order.Price TodoAmount { get; set; }//;
        
        // Key: unmaturedAmount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unmaturedAmount")]
        public _order.Price UnmaturedAmount { get; set; }//;
    }
    
    // Id: Operation Namespace: debt
    public class Operation {
        
        // Key: amount Type: order.Price FullType: order.Price
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("amount")]
        public _order.Price Amount { get; set; }//;
        
        // Key: date Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("date")]
        public System.DateTime Date { get; set; }//;
        
        // Key: depositOrderId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("depositOrderId")]
        public long DepositOrderId { get; set; }//;
        
        // Key: operationId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("operationId")]
        public long OperationId { get; set; }//;
        
        // Key: status Type: debt.entry.StatusEnum FullType: debt.entry.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _debt_entry.StatusEnum Status { get; set; }//;
        
        // Key: type Type: debt.entry.OperationEnum FullType: debt.entry.OperationEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _debt_entry.OperationEnum Type { get; set; }//;
    }
}