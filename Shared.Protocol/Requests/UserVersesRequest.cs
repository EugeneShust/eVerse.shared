using Shared.Protocol.Api;
using Shared.Protocol.Dtos;

namespace Shared.Protocol.Requests
{
    public class UserVersesRequest : IRequest<UserVersesResponse>
    {
    }

    public class UserVersesResponse 
    {
        public List<VerseDto> Verses { get; set; }
        public List<VerseDto> Favorites { get; set; }
    }
}
