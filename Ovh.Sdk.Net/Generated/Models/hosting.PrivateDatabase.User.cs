//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _hosting_PrivateDatabase_User {
    
    
    // Id: Database Namespace: hosting.PrivateDatabase.User
    public class Database {
        
        // Key: databaseName Type: string FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("databaseName")]
        public string DatabaseName { get; set; }//;
        
        // Key: grantId Type: long FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("grantId")]
        public long GrantId { get; set; }//;
        
        // Key: grantType Type: hosting.PrivateDatabase.grant.GrantEnum FullType: 
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("grantType")]
        public _hosting_PrivateDatabase_grant.GrantEnum GrantType { get; set; }//;
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _hosting_privateDatabase_User {
    
    
    // Id: ChangePasswordPayload Namespace: hosting.privateDatabase.User
    public class ChangePasswordPayload {
        
        // Key: password Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public string Password { get; set; }//;
    }
    
    // Id: CreatePayload Namespace: hosting.privateDatabase.User
    public class CreatePayload {
        
        // Key: password Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("password")]
        public string Password { get; set; }//;
        
        // Key: userName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("userName")]
        public string UserName { get; set; }//;
    }
    
    // Id: Database Namespace: hosting.privateDatabase.User
    public class Database {
        
        // Key: databaseName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("databaseName")]
        public string DatabaseName { get; set; }//;
        
        // Key: grantId Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("grantId")]
        public long GrantId { get; set; }//;
        
        // Key: grantType Type: hosting.privateDatabase.grant.GrantEnum FullType: hosting.privateDatabase.grant.GrantEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("grantType")]
        public _hosting_privateDatabase_grant.GrantEnum GrantType { get; set; }//;
    }
    
    // Id: Grant Namespace: hosting.privateDatabase.User
    public class Grant {
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public System.DateTime CreationDate { get; set; }//;
        
        // Key: databaseName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("databaseName")]
        public string DatabaseName { get; set; }//;
        
        // Key: grant Type: hosting.privateDatabase.grant.GrantEnum FullType: hosting.privateDatabase.grant.GrantEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("grant")]
        public _hosting_privateDatabase_grant.GrantEnum _Grant { get; set; }//;
    }
}