using Newtonsoft.Json;

namespace LeitorJson
{
    public class Partido
    {
        [JsonProperty("numero")]
        public int Numero { get; set; }

        [JsonProperty("sigla")]
        public string Sigla { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }
    }
}