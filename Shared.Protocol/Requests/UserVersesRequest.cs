using Shared.Protocol.Api;
using Shared.Protocol.Dtos;

namespace Shared.Protocol.Requests
{
    public class UserVersesRequest : IRequest<UserVersesResponse>
    {
    }

    public class UserVersesResponse 
    {
        public List<VersePreviewDto> Verses { get; set; }
        public List<VersePreviewDto> Favorites { get; set; }
    }
}
