using Shared.Protocol.Api;
using Shared.Protocol.Dtos;
using System.Text.Json.Serialization;
using TypeGen.Core.TypeAnnotations;

namespace Shared.Protocol.Requests
{
    [ExportTsClass]
    public class ProfileRequest : IRequest<ProfileResponse>
    {
    }

    public class ProfileResponse 
    {
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; } = string.Empty;
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; } = string.Empty;
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;
        [JsonPropertyName("phone")]
        public string Phone { get; set; } = string.Empty;
        [JsonPropertyName("favorites")]
        public List<FavoriteDto> Favorites { get; set; } = [];
    }
}
