using Newtonsoft.Json;

namespace LeitorJson
{
    public class Arquivo
    {
        [JsonProperty("idArquivo")]
        public long IdArquivo { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("codTipo")]
        public string CodTipo { get; set; }

        [JsonProperty("fullFilePath")]
        public string FullFilePath { get; set; }

        [JsonProperty("fileInputStream")]
        public string FileInputStream { get; set; }

        [JsonProperty("fileByteArray")]
        public byte[] FileByteArray { get; set; }    
    }
}