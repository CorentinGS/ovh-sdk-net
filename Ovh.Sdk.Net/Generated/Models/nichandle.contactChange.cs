//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _nichandle_contactChange {
    
    
    // Id: Task Namespace: nichandle.contactChange
    public class Task {
        
        // Key: askingAccount Type: string FullType: coreTypes.AccountId:string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("askingAccount")]
        public System.String? AskingAccount { get; set; }//;
        
        // Key: contactTypes Type: nichandle.changeContact.ContactTypeEnum[] FullType: nichandle.changeContact.ContactTypeEnum[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contactTypes")]
        public _nichandle_changeContact.ContactTypeEnum[] ContactTypes { get; set; }//;
        
        // Key: dateDone Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dateDone")]
        public System.DateTime? DateDone { get; set; }//;
        
        // Key: dateRequest Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dateRequest")]
        public System.DateTime DateRequest { get; set; }//;
        
        // Key: fromAccount Type: string FullType: coreTypes.AccountId:string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("fromAccount")]
        public string FromAccount { get; set; }//;
        
        // Key: id Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public long Id { get; set; }//;
        
        // Key: serviceDomain Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("serviceDomain")]
        public System.String? ServiceDomain { get; set; }//;
        
        // Key: state Type: nichandle.changeContact.TaskStateEnum FullType: nichandle.changeContact.TaskStateEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state")]
        public _nichandle_changeContact.TaskStateEnum State { get; set; }//;
        
        // Key: toAccount Type: string FullType: coreTypes.AccountId:string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("toAccount")]
        public string ToAccount { get; set; }//;
    }
}
