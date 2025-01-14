﻿using System.Text.Json.Serialization;

namespace Shared.Protocol.Dtos
{
    public class AppPreviewDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("logo")]
        public string Logo { get; set; }
        [JsonPropertyName("start")]
        public string Start { get; set; }
        [JsonPropertyName("end")]
        public string End { get; set; }
    }
}