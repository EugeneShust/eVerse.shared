using Shared.Protocol.Api;
using Shared.Protocol.Dtos;
using System.Text.Json.Serialization;

namespace Shared.Protocol.Requests
{
    public class AppExploreRequest : IRequest<AppExploreResponse>
    {
    }

    public class AppExploreResponse
    {
        [JsonPropertyName("apps")]
        public List<AppPreviewDto> Apps { get; set; }
    }
}
