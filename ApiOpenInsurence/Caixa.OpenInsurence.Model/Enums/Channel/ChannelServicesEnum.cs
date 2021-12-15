using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Enums.Channel
{
    public enum ChannelServicesEnum
    {
        [Description("Alterações de Forma de Pagamento")]
        ALTERACOES_FORMA_PAGAMENTO = 1,
        [Description("Aviso de Sinistro")]
        AVISO_SINISTRO = 2,
        [Description("Cancelamento de Suspensao de Pagamento de Premios e Contribuição")]
        CANCELAMENTO_SUSPENSAO_PAGAMENTO_PREMIOS_CONTRIBUICAO = 3,
        [Description("Efetivação de Aporte")]
        EFETIVACAO_APORTE = 4,
        [Description("Endosso")]
        ENDOSSO = 5,
        [Description("Envio de Documentos")]
        ENVIO_DOCUMENTOS = 6,
        [Description("Informações Gerais de Dúvidas")]
        INFORMACOES_GERAIS_DUVIDAS = 7,
        [Description("Informações de Intermediários")]
        INFORMACOES_INTERMEDIARIOS = 8,
        [Description("Informações sobre Serviços e Assintências")]
        INFORMACOES_SOBRE_SERVICOS_ASSISTENCIAS = 9,
        [Description("Informações sobre Sorteios")]
        INFORMACOES_SOBRE_SORTEIOS = 10,
        [Description("Ouvidoria - Recepção, Sugestões e Elogios")]
        OUVIDORIA_RECEPCAO_SUGESTOES_ELOGIOS = 11,
        [Description("Ouvidoria - Solução de Eventuais Divergências (Contrato de Seguro, Capitalização da Previdencia após esgotados, " +
            "Canais regulares de Atendimento, Aquelas oriundas, Orgãos Reguladores ou Integrantes do Sistema Nacional, Defesa do Consumidor)")]
        OUVIDORIA_SOLUCAO_EVENTUAIS_DIVERGENCIAS = 12,
        [Description("Ouvidoria - Tratamento de Insatisfação do Consumidor com relação ao Atendimento Recebido nos Canais Regulares")]
        OUVIDORIA_TRATAMENTO_INSATISFACAO_CONSUMIDOR = 13,
        [Description("Ouvidoria - Tratamento de Reclamações sobre Irregularidades e Conduta da Companhia")]
        OUVIDORIA_TRATAMENTO_RECLAMACOES_SOBRE_IRREGULARDADES_CONDUTA_COMPANHIA = 14,
        [Description("Portabilidade")]
        PORTABILIDADE = 15,
        [Description("Reclamação")]
        RECLAMACAO = 16,
        [Description("Resgate")]
        RESGATE = 17,
        [Description("2ª via de Documentos Contratuais")]
        SEGUNDA_VIA_DOCUMENTOS_CONTRATUAIS = 18,
        [Description("Sugestões e Elogios")]
        SUGESTOES_ELOGIOS = 19,
        [Description("Atendimento ao Cliente")]
        ATENDIMENTO_AO_CLIENTE = 20
    }
}
