using Newtonsoft.Json;

namespace LeitorJson
{
    public class EleicaoAnterior
    {
        [JsonProperty("nrAno")]
        public int NrAno { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nomeUrna")]
        public string NomeUrna { get; set; }

        [JsonProperty("nomeCandidato")]
        public string NomeCandidato { get; set; }

        [JsonProperty("idEleicao")]
        public string IdEleicao { get; set; }

        [JsonProperty("sgUe")]
        public string SgUe { get; set; }

        [JsonProperty("local")]
        public string Local { get; set; }

        [JsonProperty("cargo")]
        public string Cargo { get; set; }

        [JsonProperty("partido")]
        public string Partido { get; set; }

        [JsonProperty("situacaoTotalizacao")]
        public string SituacaoTotalizacao { get; set; }

        [JsonProperty("txLink")]
        public string TxLink { get; set; }
    }
}