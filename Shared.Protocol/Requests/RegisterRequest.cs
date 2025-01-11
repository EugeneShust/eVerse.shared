using Shared.Protocol.Api;
using TypeGen.Core.TypeAnnotations;

namespace Shared.Protocol.Requests
{
    [ExportTsClass]
    public class RegistrationRequest : IRequest<RegistrationResponse>
    {
    }

    public class RegistrationResponse
    {
        public required string UserId { get; set; }
    }
}
