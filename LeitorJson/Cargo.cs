using Newtonsoft.Json;

namespace LeitorJson
{
    public class Cargo
    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; }

        [JsonProperty("sigla")]
        public object Sigla { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("codSuperior")]
        public int CodSuperior { get; set; }

        [JsonProperty("titular")]
        public bool Titular { get; set; }

        [JsonProperty("contagem")]
        public int Contagem { get; set; }
    }
}