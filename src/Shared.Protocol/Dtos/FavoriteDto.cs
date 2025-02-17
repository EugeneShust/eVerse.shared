using System.Text.Json.Serialization;

namespace Shared.Protocol.Dtos
{
    public class FavoriteDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("events")]
        public List<string> Events { get; set; }
    }
}
