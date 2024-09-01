//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _cloud_keymanager {
    
    
    // Id: Certificate Namespace: cloud.keymanager
    public class Certificate {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
        
        // Key: secrets Type: cloud.keymanager.SecretRef[] FullType: cloud.keymanager.SecretRef[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("secrets")]
        public _cloud_keymanager.SecretRef[] Secrets { get; set; }//;
    }
    
    // Id: CertificateCreate Namespace: cloud.keymanager
    public class CertificateCreate {
        
        // Key: certificate Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("certificate")]
        public string Certificate { get; set; }//;
        
        // Key: intermediates Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("intermediates")]
        public string Intermediates { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: privateKey Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("privateKey")]
        public string PrivateKey { get; set; }//;
        
        // Key: privateKeyPassphrase Type: password FullType: password
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("privateKeyPassphrase")]
        public string PrivateKeyPassphrase { get; set; }//;
    }
    
    // Id: Secret Namespace: cloud.keymanager
    public class Secret {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
        
        // Key: region Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("region")]
        public string Region { get; set; }//;
    }
    
    // Id: SecretRef Namespace: cloud.keymanager
    public class SecretRef {
        
        // Key: id Type: uuid FullType: uuid
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public System.Guid Id { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
}