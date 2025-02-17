using Shared.Protocol.Requests;
using System.Text.Json.Serialization;

namespace Shared.Protocol.Dtos
{
    public class LocationDto : BaseItemDto
    {
        [JsonPropertyName("coords")]
        public LocationCoordsDto Coords { get; set; }
    }
}
