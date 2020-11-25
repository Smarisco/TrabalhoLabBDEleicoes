using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeitorJson
{
    public class Candidato
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nomeUrna")]
        public string NomeUrna { get; set; }

        [JsonProperty("numero")]
        public int Numero { get; set; }

        [JsonProperty("idCandidatoSuperior")]
        public int IdCandidatoSuperior { get; set; }

        [JsonProperty("nomeCompleto")]
        public string NomeCompleto { get; set; }

        [JsonProperty("descricaoSexo")]
        public string DescricaoSexo { get; set; }

        [JsonProperty("dataDeNascimento")]
        public string DataDeNascimento { get; set; }

        [JsonProperty("tituloEleitor")]
        public string TituloEleitor { get; set; }

        [JsonProperty("cpf")]
        public string Cpf { get; set; }

        [JsonProperty("descricaoEstadoCivil")]
        public string DescricaoEstadoCivil { get; set; }

        [JsonProperty("descricaoCorRaca")]
        public string DescricaoCorRaca { get; set; }

        [JsonProperty("descricaoSituacao")]
        public string DescricaoSituacao { get; set; }

        [JsonProperty("nacionalidade")]
        public string Nacionalidade { get; set; }

        [JsonProperty("grauInstrucao")]
        public string GrauInstrucao { get; set; }

        [JsonProperty("ocupacao")]
        public string Ocupacao { get; set; }

        [JsonProperty("gastoCampanha1T")]
        public double GastoCampanha1T { get; set; }

        [JsonProperty("gastoCampanha2T")]
        public int GastoCampanha2T { get; set; }

        [JsonProperty("sgUfNascimento")]
        public string SgUfNascimento { get; set; }

        [JsonProperty("nomeMunicipioNascimento")]
        public string NomeMunicipioNascimento { get; set; }

        [JsonProperty("localCandidatura")]
        public string LocalCandidatura { get; set; }

        [JsonProperty("ufCandidatura")]
        public string UfCandidatura { get; set; }

        [JsonProperty("ufSuperiorCandidatura")]
        public string UfSuperiorCandidatura { get; set; }

        [JsonProperty("dataUltimaAtualizacao")]
        public string DataUltimaAtualizacao { get; set; }

        [JsonProperty("fotoUrl")]
        public string FotoUrl { get; set; }

        [JsonProperty("fotoDataUltimaAtualizacao")]
        public DateTime? FotoDataUltimaAtualizacao { get; set; }

        [JsonProperty("descricaoTotalizacao")]
        public string DescricaoTotalizacao { get; set; }

        [JsonProperty("nomeColigacao")]
        public string NomeColigacao { get; set; }

        [JsonProperty("composicaoColigacao")]
        public string ComposicaoColigacao { get; set; }

        [JsonProperty("numeroProcessoDrap")]
        public string NumeroProcessoDrap { get; set; }

        [JsonProperty("numeroProcessoDrapEncrypt")]
        public string NumeroProcessoDrapEncrypt { get; set; }

        [JsonProperty("numeroProcesso")]
        public string NumeroProcesso { get; set; }

        [JsonProperty("numeroProcessoEncrypt")]
        public string NumeroProcessoEncrypt { get; set; }

        [JsonProperty("numeroProcessoPrestContas")]
        public string NumeroProcessoPrestContas { get; set; }

        [JsonProperty("numeroProcessoPrestContasEncrypt")]
        public string NumeroProcessoPrestContasEncrypt { get; set; }

        [JsonProperty("numeroProtocolo")]
        public string NumeroProtocolo { get; set; }

        [JsonProperty("cargo")]
        public Cargo Cargo { get; set; }

        [JsonProperty("bens")]
        public List<Bens> Bens { get; set; }

        [JsonProperty("totalDeBens")]
        public double TotalDeBens { get; set; }

        [JsonProperty("vices")]
        public List<Vice> Vices { get; set; }

        [JsonProperty("partido")]
        public Partido Partido { get; set; }

        [JsonProperty("eleicao")]
        public Eleicao Eleicao { get; set; }

        [JsonProperty("emails")]
        public List<string> Emails { get; set; }

        [JsonProperty("sites")]
        public List<string> Sites { get; set; }

        [JsonProperty("arquivos")]
        public List<Arquivo> Arquivos { get; set; }

        [JsonProperty("eleicoesAnteriores")]
        public List<EleicaoAnterior> EleicoesAnteriores { get; set; }

        [JsonProperty("substituto")]
        public string Substituto { get; set; }

        [JsonProperty("motivos")]
        public string Motivos { get; set; }

        [JsonProperty("codigoSituacaoCandidato")]
        public int CodigoSituacaoCandidato { get; set; }

        [JsonProperty("descricaoSituacaoCandidato")]
        public string DescricaoSituacaoCandidato { get; set; }

        [JsonProperty("st_SUBSTITUIDO")]
        public bool StSUBSTITUIDO { get; set; }

        [JsonProperty("descricaoNaturalidade")]
        public string DescricaoNaturalidade { get; set; }

        [JsonProperty("st_MOTIVO_AUSENCIA_REQUISITO")]
        public bool StMOTIVOAUSENCIAREQUISITO { get; set; }

        [JsonProperty("st_MOTIVO_CONDUTA_VEDADA")]
        public bool StMOTIVOCONDUTAVEDADA { get; set; }

        [JsonProperty("cnpjcampanha")]
        public string Cnpjcampanha { get; set; }

        [JsonProperty("gastoCampanha")]
        public double GastoCampanha { get; set; }

        [JsonProperty("st_MOTIVO_ABUSO_PODER")]
        public bool StMOTIVOABUSOPODER { get; set; }

        [JsonProperty("st_MOTIVO_COMPRA_VOTO")]
        public bool StMOTIVOCOMPRAVOTO { get; set; }

        [JsonProperty("ds_MOTIVO_OUTROS")]
        public string DsMOTIVOOUTROS { get; set; }

        [JsonProperty("st_MOTIVO_GASTO_ILICITO")]
        public bool StMOTIVOGASTOILICITO { get; set; }

        [JsonProperty("st_MOTIVO_IND_PARTIDO")]
        public bool StMOTIVOINDPARTIDO { get; set; }

        [JsonProperty("st_MOTIVO_FICHA_LIMPA")]
        public bool StMOTIVOFICHALIMPA { get; set; }

        [JsonProperty("st_DIVULGA_ARQUIVOS")]
        public bool StDIVULGAARQUIVOS { get; set; }

        [JsonProperty("st_DIVULGA_BENS")]
        public bool StDIVULGABENS { get; set; }

        [JsonProperty("st_DIVULGA")]
        public bool StDIVULGA { get; set; }

        [JsonProperty("st_REELEICAO")]
        public bool StREELEICAO { get; set; }
    }
}