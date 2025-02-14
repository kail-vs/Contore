using System.Text.Json.Serialization;

namespace Contore.Model
{
    public class Language
    {
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        [JsonPropertyName("language")]
        public string? LanguageName { get; set; }
    }
}
