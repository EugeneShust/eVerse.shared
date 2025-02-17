using System.Text.Json.Serialization;

namespace Shared.Protocol.Dtos
{
    public class VersePreviewDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }
}
