using Newtonsoft.Json;
using System;

namespace LeitorJson
{
    public class Eleicao
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("siglaUF")]
        public string SiglaUF { get; set; }

        [JsonProperty("localidadeSgUe")]
        public string LocalidadeSgUe { get; set; }

        [JsonProperty("ano")]
        public int Ano { get; set; }

        [JsonProperty("codigo")]
        public int? Codigo { get; set; }

        [JsonProperty("nomeEleicao")]
        public string NomeEleicao { get; set; }

        [JsonProperty("tipoEleicao")]
        public string TipoEleicao { get; set; }

        [JsonProperty("turno")]
        public int? Turno { get; set; }

        [JsonProperty("tipoAbrangencia")]
        public string TipoAbrangencia { get; set; }

        [JsonProperty("dataEleicao")]
        public DateTime? DataEleicao { get; set; }

        [JsonProperty("codSituacaoEleicao")]
        public string CodSituacaoEleicao { get; set; }

        [JsonProperty("descricaoSituacaoEleicao")]
        public string DescricaoSituacaoEleicao { get; set; }

        [JsonProperty("descricaoEleicao")]
        public string DescricaoEleicao { get; set; }

    }
}