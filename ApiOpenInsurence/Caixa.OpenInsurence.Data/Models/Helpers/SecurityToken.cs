using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.Token
{
    public class SecurityToken
    {
        public SecurityToken() { }
        public string Username { get; set; }
        public string SHArsaKey { get; set; }
    }


    public class SecurityTokenResponse
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public SecurityTokenData Dados { get; set; }
    }

    public class SecurityTokenRequest
    {
        public SecurityTokenRequest() { }
        [JsonProperty("cpf")]
        public string Username { get; set; }
        [JsonProperty("funcao")]
        public string Funcao { get; set; }
    }

    public class SecurityTokenData
    {
        public string Mapdata { get; set; }
        public string KeyData { get; set; }
    }


    public enum TokenFunctionEnum
    {
        [Description("OPIN_ConsultaProdutosPrevidenciaCompleto")]
        OPIN_ConsultaProdutosPrevidenciaCompleto,
        [Description("OPIN_ConsultaProdutosPrevidenciaNovosFundos")]
        OPIN_ConsultaProdutosPrevidenciaNovosFundos,
        [Description("OPIN_ConsultaProdutosVidaPF")]
        OPIN_ConsultaProdutosVidaPF,
        [Description("OPIN_ConsultarAgenciasCAIXA")]
        OPIN_ConsultarAgenciasCAIXA
    }
}
