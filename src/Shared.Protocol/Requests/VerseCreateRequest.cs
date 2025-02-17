using Shared.Protocol.Api;
using System.Text.Json.Serialization;

namespace Shared.Protocol.Requests
{
    public class VerseCreateRequest : IRequest<VerseCreateResponse>
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("logo")]
        public string Logo { get; set; }
        [JsonPropertyName("start")]
        public DateTime Start { get; set; }
        [JsonPropertyName("end")]
        public DateTime End { get; set; }
    }

    public class VerseCreateResponse
    {
        [JsonPropertyName("verseId")]
        public string VerseId { get; set; }
    }
}
