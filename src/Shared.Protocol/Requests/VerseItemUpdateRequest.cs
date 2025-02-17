using Shared.Protocol.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shared.Protocol.Requests
{
    public class VerseItemUpdateRequest : IRequest<VerseItemUpdateResponse>
    {
    }

    public class VerseItemUpdateResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
