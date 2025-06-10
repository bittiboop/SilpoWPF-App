using System;
using System.Text.Json.Serialization;

namespace SupabaseService.Models
{
    public abstract class BaseEntity
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}