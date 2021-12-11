using Newtonsoft.Json;

namespace BlazorApp1.Models
{

    public class ErrorCodeModel
    {
        
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

    }

    public class ErrorCodeResults
    {

        [JsonProperty("errors")]
        public ErrorCodeModel[] Errors { get; set; }

    }
}