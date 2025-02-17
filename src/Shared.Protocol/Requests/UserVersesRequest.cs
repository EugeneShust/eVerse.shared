using Shared.Protocol.Api;
using Shared.Protocol.Dtos;
using System.Text.Json.Serialization;

namespace Shared.Protocol.Requests
{
    public class UserVersesRequest : IRequest<UserVersesResponse>
    {
    }

    public class UserVersesResponse 
    {
        [JsonPropertyName("verses")]
        public List<VersePreviewDto> Verses { get; set; }
        [JsonPropertyName("favorites")]
        public List<VersePreviewDto> Favorites { get; set; }
    }
}
