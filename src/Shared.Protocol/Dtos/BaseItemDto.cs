using System.Text.Json.Serialization;

namespace Shared.Protocol.Dtos
{
    public class BaseItemDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
