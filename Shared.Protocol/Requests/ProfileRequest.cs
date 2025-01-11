using Shared.Protocol.Api;
using Shared.Protocol.Dtos;
using TypeGen.Core.TypeAnnotations;

namespace Shared.Protocol.Requests
{
    [ExportTsClass]
    public class ProfileRequest : IRequest<ProfileResponse>
    {
    }

    public class ProfileResponse 
    {
        public required ProfileDto Profile { get; set; }
    }
}
