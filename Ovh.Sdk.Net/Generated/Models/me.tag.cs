//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _me_tag {
    
    
    // Id: AvailableTag Namespace: me.tag
    public class AvailableTag {
        
        // Key: keys Type: me.tag.TagKey[] FullType: me.tag.TagKey[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("keys")]
        public _me_tag.TagKey[] Keys { get; set; }//;
        
        // Key: name Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
        public string Name { get; set; }//;
    }
    
    // Id: Creation Namespace: me.tag
    public class Creation {
        
        // Key: reason Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("reason")]
        public string Reason { get; set; }//;
        
        // Key: tagName Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tagName")]
        public string TagName { get; set; }//;
    }
    
    // Id: StatusEnum Namespace: me.tag
    public enum StatusEnum {
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CREATED")]
        CREATED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("CREATING")]
        CREATING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETED")]
        DELETED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("DELETING")]
        DELETING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ERROR")]
        ERROR,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("MODERATING")]
        MODERATING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REFUSED")]
        REFUSED,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REFUSING")]
        REFUSING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("REVOCATING")]
        REVOCATING,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("WAIT_MODERATION")]
        WAIT_MODERATION,
        
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("WAIT_REVOCATION")]
        WAIT_REVOCATION,
    }
    
    // Id: Tag Namespace: me.tag
    public class Tag {
        
        // Key: creationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("creationDate")]
        public System.DateTime CreationDate { get; set; }//;
        
        // Key: customerCode Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("customerCode")]
        public string CustomerCode { get; set; }//;
        
        // Key: expirationDate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("expirationDate")]
        public System.DateTime ExpirationDate { get; set; }//;
        
        // Key: extra Type: me.tag.TagExtra FullType: me.tag.TagExtra
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("extra")]
        public _me_tag.TagExtra Extra { get; set; }//;
        
        // Key: lastUpdate Type: datetime FullType: datetime
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("lastUpdate")]
        public System.DateTime LastUpdate { get; set; }//;
        
        // Key: status Type: me.tag.StatusEnum FullType: me.tag.StatusEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
        public _me_tag.StatusEnum Status { get; set; }//;
        
        // Key: tag Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("tag")]
        public string _Tag { get; set; }//;
    }
    
    // Id: TagExtra Namespace: me.tag
    public class TagExtra {
        
        // Key: exemption Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("exemption")]
        public string Exemption { get; set; }//;
    }
    
    // Id: TagKey Namespace: me.tag
    public class TagKey {
        
        // Key: enum Type: string[] FullType: string[]
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("enum")]
        public string[] @enum { get; set; }//;
        
        // Key: key Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("key")]
        public string Key { get; set; }//;
        
        // Key: maxLength Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("maxLength")]
        public long MaxLength { get; set; }//;
        
        // Key: minValue Type: long FullType: long
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("minValue")]
        public long MinValue { get; set; }//;
        
        // Key: optional Type: boolean FullType: boolean
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("optional")]
        public bool Optional { get; set; }//;
        
        // Key: pattern Type: string FullType: string
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pattern")]
        public string Pattern { get; set; }//;
        
        // Key: type Type: me.tag.tagKey.TypeEnum FullType: me.tag.tagKey.TypeEnum
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("type")]
        public _me_tag_tagKey.TypeEnum Type { get; set; }//;
    }
}