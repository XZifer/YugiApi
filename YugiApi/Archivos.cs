using Newtonsoft.Json;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Json;
using YugiApi.Models;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace YugiApi
{
    public class Archivos
    {
        public void Serealizar(List<MagicCard> magias)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                Converters =
                {
                    new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                }
            };
            string json = JsonSerializer.Serialize(magias, options);
            //string json = JsonSerializer.Serialize(nombre, options);
            File.WriteAllText("CartasMagia.json", json);
        }
        public List<MagicCard> Deserealizar(string nombre)
        {
            List<MagicCard> tarjetaMagiaTrampas = new List<MagicCard>();
            string jsonString = File.ReadAllText(nombre);
            List<MagicCard>? lst = JsonConvert.DeserializeObject<List<MagicCard>>(jsonString);
            return lst;
        }
    }
}
