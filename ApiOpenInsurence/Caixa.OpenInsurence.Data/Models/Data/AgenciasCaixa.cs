using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Data.Models.Data
{
    public class AgenciasCaixa
    {
        public string CNPJ { get; set; }
        public string SEQUENCIAL_CNPJ { get; set; }
        public string DV_CNPJ { get; set; }

        [JsonProperty("NOME_ INSTITUICAO")]
        public string NOME_INSTITUICAO { get; set; }

        public string ORGAO { get; set; }
        public string NOME_AGENCIA { get; set; }
        public string ENDERECO { get; set; }
        public string NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CEP { get; set; }
        public string MUNICIPIO { get; set; }
        public string UF { get; set; }
        public string DATA_INICIO { get; set; }
        public string DDD { get; set; }
        public string FONE { get; set; }
        public string TIPO { get; set; }
        public string CNPJ_ENTIDADE_A { get; set; }
        public string NOME_ENTIDADE_ASSISTIDA { get; set; }
        public string HORA_ABERTURA { get; set; }
        public string HORA_FECHAMENTO { get; set; }
        public string DIA_SEMANA { get; set; }
        public string EXCESSAO { get; set; }
        public string SERVIÇOS { get; set; }
    }
}
