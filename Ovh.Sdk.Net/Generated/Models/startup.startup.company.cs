//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _startup_startup_company {
    
    
    // Id: detail Namespace: startup.startup.company
    public class detail {
        
        // Key: creationdate Type: date FullType: date
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationdate")]
        public System.DateOnly Creationdate { get; set; }//;
        
        // Key: lastYearTurnover Type: double FullType: double
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastYearTurnover")]
        public double LastYearTurnover { get; set; }//;
        
        // Key: vatNumber Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vatNumber")]
        public string VatNumber { get; set; }//;
    }
    
    // Id: incubator Namespace: startup.startup.company
    public class incubator {
        
        // Key: city Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("city")]
        public string City { get; set; }//;
        
        // Key: country Type: nichandle.CountryEnum FullType: nichandle.CountryEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("country")]
        public _nichandle.CountryEnum Country { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: socialNetwork Namespace: startup.startup.company
    public class socialNetwork {
        
        // Key: linkedin Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("linkedin")]
        public string Linkedin { get; set; }//;
        
        // Key: twitter Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("twitter")]
        public string Twitter { get; set; }//;
    }
}