using System.Text.Json.Serialization;

namespace SupabaseService.Models
{
    public class User : BaseEntity
    {
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;
        
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        
        [JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }
        
        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; } = true;
    }
}