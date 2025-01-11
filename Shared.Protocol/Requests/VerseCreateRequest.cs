using Shared.Protocol.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Protocol.Requests
{
    public class VerseCreateRequest : IRequest<VerseCreateResponse>
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class VerseCreateResponse
    {
        public string VerseId { get; set; }
    }
}
