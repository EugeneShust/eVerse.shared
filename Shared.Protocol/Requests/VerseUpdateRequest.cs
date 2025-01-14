using Shared.Protocol.Api;

namespace Shared.Protocol.Requests
{
    public class VerseUpdateRequest : IRequest<VerseUpdateResponse>
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class VerseUpdateResponse
    {
    }
}
