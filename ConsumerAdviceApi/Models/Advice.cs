using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ConsumerAdviceApi.Models
{

    public class AdviceResponse
    {
        [JsonPropertyName("slip")]
        public Slip? Slip { get; set; }
    }

    public class Slip
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
        [JsonPropertyName("advice")]
        public string? Advice { get; set; }
    }
}