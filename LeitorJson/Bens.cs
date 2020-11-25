using Newtonsoft.Json;

namespace LeitorJson
{
    public class Bens
    {
        [JsonProperty("ordem")]
        public int Ordem { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("descricaoDeTipoDeBem")]
        public string DescricaoDeTipoDeBem { get; set; }

        [JsonProperty("valor")]
        public double Valor { get; set; }

        [JsonProperty("dataUltimaAtualizacao")]
        public string DataUltimaAtualizacao { get; set; }

    }
}