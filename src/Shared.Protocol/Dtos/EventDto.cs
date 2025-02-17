using System.Text.Json.Serialization;

namespace Shared.Protocol.Dtos
{
    public class EventDto : BaseItemDto
    {
        [JsonPropertyName("locationId")]
        public string LocationId { get; set; }
        [JsonPropertyName("categoryId")]
        public string CategoryId { get; set; }
        [JsonPropertyName("start")]
        public DateTime Start { get; set; }
        [JsonPropertyName("end")]
        public DateTime End { get; set; }
        [JsonPropertyName("presenterIds")]
        public List<string> PresenterIds { get; set; } = [];
    }
}
