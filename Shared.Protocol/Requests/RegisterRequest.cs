using Shared.Protocol.Api;
using System.Text.Json.Serialization;
using TypeGen.Core.TypeAnnotations;

namespace Shared.Protocol.Requests
{
    [ExportTsClass]
    public class RegistrationRequest : IRequest<RegistrationResponse>
    {
    }

    public class RegistrationResponse
    {
        [JsonPropertyName("userId")]
        public required string UserId { get; set; }
    }
}
