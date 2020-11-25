﻿using Newtonsoft.Json;
using Npgsql;
using System;
using System.IO;

namespace LeitorJson
{
    class Program
    {
        //teste
        static void Main(string[] args)
        {
            LoadJson();
        }

        public static string TratarNulo(string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return "NULL";
            }

            return valor;
        }

        public static string TratarNuloData(DateTime? valor)
        {
            if (valor == null)
            {
                return "NULL";
            }

            return "'" + valor + "'";
        }

        public static string TratarNuloByteArray(byte[] arquivo)
        {
            if (arquivo == null)
            {
                return "NULL";
            }

            return arquivo.ToString();
        }

        public static void LoadJson()
        {

            string jsonFilePath = @"C:\Teste\";
            DirectoryInfo directoryInfo = new DirectoryInfo(jsonFilePath);


            foreach (var file in directoryInfo.GetFiles("*.json"))
            {
                using (StreamReader r = new StreamReader(file.FullName))
                {
                    string json = r.ReadToEnd();
                    Candidato candidato = JsonConvert.DeserializeObject<Candidato>(json);

                    string connStr = "User ID=postgres;Password=123;Host=localhost;Port=5432;Database=Trabalho;Pooling=true;";
                    var m_conn = new NpgsqlConnection(connStr);

                    m_conn.Open();

                    string sqlInsert = @$"INSERT INTO politica.candidato(
                            id,
                            nomeurna, 
                            numero, 
                            idcandidatosuperior,
                            nomecompleto, 
                            descricaosexo, 
                            datadenascimento, 
                            tituloeleitor, 
                            cpf, 
                            descricaoestadocivil, 
                            descricaocorraca, 
                            descricaosituacao, 
                            nacionalidade, 
                            grauinstrucao, 
                            ocupacao, 
                            gastocampanha1t, 
                            gastocampanha2t, 
                            sgufnascimento, 
                            nomemunicipionascimento, 
                            localcandidatura, 
                            ufcandidatura, 
                            ufsuperiorcandidatura, 
                            dataultimaatualizacao, 
                            fotourl, 
                            fotodataultimaatualizacao, 
                            descricaototalizacao, 
                            nomecoligacao, 
                            composicaocoligacao, 
                            numeroprocessodrap, 
                            numeroprocessodrapencrypt, 
                            numeroprocesso, 
                            numeroprocessoencrypt, 
                            numeroprocessoprestcontas, 
                            numeroprocessoprestcontasencrypt,
                            numeroprotocolo, 
                            substituto, 
                            motivos, 
                            codigosituacaocandidato, 
                            descricaosituacaocandidato, 
                            st_substituido, 
                            descricaonaturalidade, 
                            st_motivo_ausencia_requisito, 
                            st_motivo_conduta_vedada, 
                            cnpjcampanha, 
                            gastocampanha, 
                            st_motivo_abuso_poder, 
                            st_motivo_compra_voto, 
                            ds_motivo_outros, 
                            st_motivo_gasto_ilicito, 
                            st_motivo_ind_partido, 
                            st_motivo_ficha_limpa, 
                            st_divulga_arquivos, 
                            st_divulga_bens, 
                            st_divulga, 
                            st_reeleicao, 
                            totaldebens)
                
	                        VALUES({candidato.Id} , '{candidato.NomeUrna}', {candidato.Numero},{candidato.IdCandidatoSuperior}, '{candidato.NomeCompleto}', 
                                 '{candidato.DescricaoSexo}', '{candidato.DataDeNascimento}', '{candidato.TituloEleitor}', '{candidato.Cpf}', '{candidato.DescricaoEstadoCivil}', 
                                 '{candidato.DescricaoCorRaca}', '{candidato.DescricaoSituacao}','{candidato.Nacionalidade}', '{candidato.GrauInstrucao}', '{candidato.Ocupacao}',
                                  {candidato.GastoCampanha1T.ToString("F2").Replace(",", ".")}, {candidato.GastoCampanha2T}, '{candidato.SgUfNascimento}', '{candidato.NomeMunicipioNascimento}', '{candidato.LocalCandidatura}', 
                                 '{candidato.UfCandidatura}',  '{candidato.UfSuperiorCandidatura}', '{candidato.DataUltimaAtualizacao}', '{candidato.FotoUrl}', {TratarNulo(candidato.FotoDataUltimaAtualizacao.ToString())},
                                 '{candidato.DescricaoTotalizacao}', '{candidato.NomeColigacao}', '{candidato.ComposicaoColigacao}','{candidato.NumeroProcessoDrap}',
                                 '{candidato.NumeroProcessoDrapEncrypt}', '{candidato.NumeroProcesso}','{candidato.NumeroProcessoEncrypt}', '{candidato.NumeroProcessoPrestContas}',
                                 '{candidato.NumeroProcessoPrestContasEncrypt}', '{candidato.NumeroProtocolo}', '{candidato.Substituto}','{candidato.Motivos}',
                                 {candidato.CodigoSituacaoCandidato}, '{candidato.DescricaoSituacaoCandidato}', {candidato.StSUBSTITUIDO}, '{candidato.DescricaoNaturalidade}',
                                 {candidato.StMOTIVOAUSENCIAREQUISITO}, {candidato.StMOTIVOCONDUTAVEDADA}, '{candidato.Cnpjcampanha}', {candidato.GastoCampanha}, {candidato.StMOTIVOABUSOPODER},
                                 {candidato.StMOTIVOCOMPRAVOTO}, '{candidato.DsMOTIVOOUTROS}', {candidato.StMOTIVOGASTOILICITO}, {candidato.StMOTIVOINDPARTIDO}, {candidato.StMOTIVOFICHALIMPA},
                                 {candidato.StDIVULGAARQUIVOS}, {candidato.StDIVULGABENS}, {candidato.StDIVULGA} , {candidato.StREELEICAO},{candidato.TotalDeBens})";

                    var m_createdb_cmd = new NpgsqlCommand(sqlInsert, m_conn);

                    m_createdb_cmd.ExecuteNonQuery();
                    m_conn.Close();

                    foreach (var arquivo in candidato.Arquivos)
                    {
                        sqlInsert = @$"INSERT INTO  politica.arquivo (                             
                            idarquivo, 
                            nome, 
                            url, 
                            tipo, 
                            codtipo, 
                            fullfilepath, 
                            fileinputstream, 
                            filebytearray, 
                            id_candidato) 
                         VALUES ({arquivo.IdArquivo}, '{arquivo.Nome}', '{arquivo.Url}', '{arquivo.Tipo}', '{arquivo.CodTipo}', '{arquivo.FullFilePath}', 
                                    '{arquivo.FileInputStream}', {TratarNuloByteArray(arquivo.FileByteArray)}, {candidato.Id})";

                        m_conn.Open();
                        m_createdb_cmd = new NpgsqlCommand(sqlInsert, m_conn);

                        m_createdb_cmd.ExecuteNonQuery();
                        m_conn.Close();
                    }

                    foreach (var eleicaoAnterior in candidato.EleicoesAnteriores)
                    {
                        sqlInsert = @$"INSERT INTO politica.eleicaoanterior(	                            
                                nrano, 
                                id, 
                                nomeurna, 
                                nomecandidato, 
                                ideleicao, 
                                sgue, 
                                local, 
                                cargo, 
                                partido, 
                                situacaototalizacao, 
                                txlink, 
                                id_candidato) 
                               VALUES ('{eleicaoAnterior.NrAno}',{eleicaoAnterior.Id},'{eleicaoAnterior.NomeUrna}','{eleicaoAnterior.NomeCandidato}',
                                    '{eleicaoAnterior.IdEleicao}','{eleicaoAnterior.SgUe}','{eleicaoAnterior.Local}','{eleicaoAnterior.Cargo}','{eleicaoAnterior.Partido}',
                                    '{eleicaoAnterior.SituacaoTotalizacao}','{eleicaoAnterior.TxLink}',{candidato.Id})";


                        m_conn.Open();
                        m_createdb_cmd = new NpgsqlCommand(sqlInsert, m_conn);

                        m_createdb_cmd.ExecuteNonQuery();
                        m_conn.Close();

                    }

                    //Sites é uma lista
                    foreach (var sites in candidato.Sites)
                    {
                        sqlInsert = @$"INSERT INTO politica.site(	                            
                                site, 
                                id_candidato) 
                               VALUES ('{sites}',{candidato.Id})";


                        m_conn.Open();
                        m_createdb_cmd = new NpgsqlCommand(sqlInsert, m_conn);

                        m_createdb_cmd.ExecuteNonQuery();
                        m_conn.Close();

                    }

                    //Partido é um objeto
                    sqlInsert = @$"INSERT INTO politica.partido(	
                                numero, 
                                sigla, 
                                nome, 
                                id_candidato) 
                               VALUES ({candidato.Partido.Numero},'{candidato.Partido.Sigla}','{candidato.Partido.Nome}',{candidato.Id})";


                    m_conn.Open();
                    m_createdb_cmd = new NpgsqlCommand(sqlInsert, m_conn);

                    m_createdb_cmd.ExecuteNonQuery();
                    m_conn.Close();

                    //Email é lista

                    foreach (var email in candidato.Emails)
                    {
                        sqlInsert = @$"INSERT INTO politica.email(	                            
                                email, 
                                id_candidato) 
                               VALUES ('{email}',{candidato.Id})";


                        m_conn.Open();
                        m_createdb_cmd = new NpgsqlCommand(sqlInsert, m_conn);

                        m_createdb_cmd.ExecuteNonQuery();
                        m_conn.Close();

                    }

                    foreach (var bens in candidato.Bens)
                    {
                        sqlInsert = @$"INSERT INTO politica.bens(	                            
                                ordem, 
                                descricao, 
                                descricaodetipodebem, 
                                valor, 
                                dataultimaatualizacao, 
                                id_candidato) 
                               VALUES ('{bens.Ordem}','{bens.Descricao}','{bens.DescricaoDeTipoDeBem}',{bens.Valor.ToString("F2").Replace(",", ".")},
                                '{bens.DataUltimaAtualizacao}',{candidato.Id})";


                        m_conn.Open();
                        m_createdb_cmd = new NpgsqlCommand(sqlInsert, m_conn);

                        m_createdb_cmd.ExecuteNonQuery();
                        m_conn.Close();

                    }

                    //Cargo é um objeto
                    sqlInsert = @$"INSERT INTO politica.cargo(	                            
                                codigo, 
                                sigla, 
                                nome, 
                                codsuperior, 
                                titular, 
                                contagem, 
                                id_candidato) 
                                VALUES ({candidato.Cargo.Codigo},'{candidato.Cargo.Sigla}','{candidato.Cargo.Nome}', '{candidato.Cargo.CodSuperior}', 
                                '{candidato.Cargo.Titular}', '{candidato.Cargo.Contagem}', {candidato.Id})";

                    m_conn.Open();
                    m_createdb_cmd = new NpgsqlCommand(sqlInsert, m_conn);

                    m_createdb_cmd.ExecuteNonQuery();
                    m_conn.Close();

                    // Eleição é um objeto

                    sqlInsert = @$"INSERT INTO politica.eleicao(
                                eleicaoid,
                                siglauf, 
                                localidadesgue, 
                                ano, 
                                codigo, 
                                nomeeleicao, 
                                tipoeleicao, 
                                turno, 
                                tipoabrangencia, 
                                dataeleicao, 
                                codsituacaoeleicao, 
                                descricaosituacaoeleicao, 
                                descricaoeleicao, 
                                idcandidato)
	
                               VALUES ({candidato.Eleicao.Id},'{candidato.Eleicao.SiglaUF}','{candidato.Eleicao.LocalidadeSgUe}',{candidato.Eleicao.Ano},{TratarNulo(candidato.Eleicao.Codigo?.ToString())},
                                '{candidato.Eleicao.NomeEleicao}', '{candidato.Eleicao.TipoEleicao}', {TratarNulo(candidato.Eleicao.Turno.ToString())}, '{candidato.Eleicao.TipoAbrangencia}',
                                {TratarNuloData(candidato.Eleicao.DataEleicao)},'{candidato.Eleicao.CodSituacaoEleicao}', '{candidato.Eleicao.DescricaoSituacaoEleicao}', 
                            '{candidato.Eleicao.DescricaoEleicao}',{candidato.Id})";


                    m_conn.Open();
                    m_createdb_cmd = new NpgsqlCommand(sqlInsert, m_conn);

                    m_createdb_cmd.ExecuteNonQuery();
                    m_conn.Close();
                }
            }
        }
    }
}
