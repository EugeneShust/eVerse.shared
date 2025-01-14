using Shared.Protocol.Api;
using Shared.Protocol.Dtos;

namespace Shared.Protocol.Requests
{
    public class VerseRequest : IRequest<VerseResponse>
    {
    }

    public class VerseResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Logo { get; set; }
        public string Map { get; set; }

        public List<EventDto> Events { get; set; } = new();
        public List<LocationDto> Locations { get; set; } = new();
        public List<CategoryDto> Categories { get; set; } = new();
        public List<PresenterDto> Presenters { get; set; } = new();
    }
}
