using Newtonsoft.Json;

namespace LeitorJson
{
    public class Vice
    {
        [JsonProperty("nomeColigacao")]
        public object NomeColigacao { get; set; }

        [JsonProperty("composicaoColigacao")]
        public object ComposicaoColigacao { get; set; }

        [JsonProperty("stRegistro")]
        public object StRegistro { get; set; }

        [JsonProperty("situacaoCandidato")]
        public object SituacaoCandidato { get; set; }

        [JsonProperty("urlFoto")]
        public string UrlFoto { get; set; }

        [JsonProperty("sg_PARTIDO")]
        public string SgPARTIDO { get; set; }

        [JsonProperty("nm_URNA")]
        public string NmURNA { get; set; }

        [JsonProperty("nm_CANDIDATO")]
        public string NmCANDIDATO { get; set; }

        [JsonProperty("sq_ELEICAO")]
        public int SqELEICAO { get; set; }

        [JsonProperty("sq_CANDIDATO_SUPERIOR")]
        public object SqCANDIDATOSUPERIOR { get; set; }

        [JsonProperty("nr_CANDIDATO")]
        public string NrCANDIDATO { get; set; }

        [JsonProperty("ds_CARGO")]
        public string DsCARGO { get; set; }

        [JsonProperty("nm_PARTIDO")]
        public string NmPARTIDO { get; set; }

        [JsonProperty("sq_CANDIDATO")]
        public long SqCANDIDATO { get; set; }

        [JsonProperty("sg_UE")]
        public string SgUE { get; set; }

        [JsonProperty("dt_ULTIMA_ATUALIZACAO")]
        public string DtULTIMAATUALIZACAO { get; set; }

    }
}