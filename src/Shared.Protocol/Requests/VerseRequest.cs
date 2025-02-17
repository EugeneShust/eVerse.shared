using Shared.Protocol.Api;
using Shared.Protocol.Dtos;
using System.Text.Json.Serialization;

namespace Shared.Protocol.Requests
{
    public class VerseRequest : IRequest<VerseResponse>
    {
    }

    public class VerseResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("start")]
        public DateTime Start { get; set; }
        [JsonPropertyName("end")]
        public DateTime End { get; set; }
        [JsonPropertyName("logo")]
        public string Logo { get; set; }
        [JsonPropertyName("map")]
        public string Map { get; set; }

        [JsonPropertyName("events")]
        public List<EventDto> Events { get; set; } = new();
        [JsonPropertyName("locations")]
        public List<LocationDto> Locations { get; set; } = new();
        [JsonPropertyName("categories")]
        public List<CategoryDto> Categories { get; set; } = new();
        [JsonPropertyName("presenters")]
        public List<PresenterDto> Presenters { get; set; } = new();
    }
}
