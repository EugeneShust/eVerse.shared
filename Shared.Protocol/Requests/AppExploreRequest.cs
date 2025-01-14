using Shared.Protocol.Api;
using Shared.Protocol.Dtos;

namespace Shared.Protocol.Requests
{
    public class AppExploreRequest : IRequest<AppExploreResponse>
    {
    }

    public class AppExploreResponse
    {
        public List<AppPreviewDto> Apps { get; set; }
    }
}
