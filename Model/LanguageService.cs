using System.Reflection;
using System.Text.Json;

namespace Contore.Model
{
    public class LanguageService
    {
        public List<Language> Languages { get; private set; } = new();

        public LanguageService()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                using var stream = assembly.GetManifestResourceStream("Contore.Resources.Raw.Languages.json")
                    ?? throw new FileNotFoundException("Could not find the resource Languages.json");

                using var reader = new StreamReader(stream);
                var json = reader.ReadToEnd();

                var jsonDocument = JsonDocument.Parse(json);
                Languages = JsonSerializer.Deserialize<List<Language>>(jsonDocument.RootElement.GetProperty("Languages").GetRawText())
                           ?? new List<Language>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading languages: {ex.Message}");
                Languages = new List<Language>();
            }
        }
    }
}
