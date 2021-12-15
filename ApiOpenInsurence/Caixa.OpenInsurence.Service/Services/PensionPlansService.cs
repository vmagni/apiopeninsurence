using Caixa.OpenInsurence.Data.Interfaces;
using Caixa.OpenInsurence.Model.Api.PensionPlan;
using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.PensionPlan;
using Caixa.OpenInsurence.Model.Enums.PensionPlan;
using Caixa.OpenInsurence.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Services
{
    public class PensionPlansService : IPensionPlansService
    {
        private readonly IDatabaseService _databaseService;
        public PensionPlansService(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public async Task<ValidaResponseDTO> GetPensionPlan(ApiRequest request)
        {    
            try
            {
                var responseServiceCaixa = await _databaseService.GetProdutosPrevidenciaNovosFundos();

    
                PensionPlanResponse response = new PensionPlanResponse();

                response.Data.Name = "";

                var dados = responseServiceCaixa.dados.OrderBy(x => x.CNPJ_COD_FUNDO).ToList();

                string cnpj = "vazio";
                int count = -1;

                foreach (var product in dados)
                {

                    if (cnpj == product.CNPJ_COD_FUNDO)
                    {
                        response.Data.Companies[count].PensionPlanProducts.Add(new PensionPlanProduct
                        {
                            Name = product.NOME_PRODUTO,
                            Code = product.COD_PRODUTO,
                            Modality = ModalityEnum.PECULIO, //TODO : bater qual será esse campo
                            PensionPlanCoverages = "Aposentadoria",
                            Additional = (AdditionalEnum)Convert.ToInt16(product.COD_PRODUTO),
                            AdditionalOthers = new List<string>(),
                            AssistanceTypes = AssistanceTypeEnum.N_A,
                            AssistanceTypesOthers = new List<string>(),
                            TermsAndConditions = new PensionPlanTerm
                            {
                                SusepProcessNumber = product.COD_SUSEP,
                                Definition = product.DESCRICAO_COD_FUNDO
                            },
                            UpdatePMBaC = new PensionPlanUpdatePMBaC
                            {
                                InterestRate = "6",
                                UpdateIndex = UpdateIndexPersonPlanEnum.IPCA,
                            },
                            PremiumUpdateIndex = PremiumUpdateIndexEnum.IPCA,
                            AgeReframing = new PensionPlanAgeReframing
                            {
                                ReframingCriterion = ReframingCriterionEnum.MUDANCA_FAIXA_ETARIA,
                                ReframingPeriodicty = 0 
                            },
                            FinancialRegimeContractType = RegimeContractTypeEnum.CAPITALIZACAO,
                            Reclaim = new PensionPlanReclaim
                            {
                                ReclaimTable = new PensionPlanReclaimTable
                                {
                                    InitialMonthRange = 1,
                                    FinalMonthRange = 12,
                                    Percentage = "0"
                                },
                                DifferentiatePercentage = "",
                                GracePeriod = "60"
                            },
                            OtherGuarateedValues = OtherGuarateedValuesEnum.NAO_APLICA,
                            ProfitModality = product.Modalidade_Indenizacao == "PAGAMENTO_UNICO" ? ProfitModalityEnum.PAGAMENTO_UNICO : ProfitModalityEnum.FORMA_RENDA,
                            ContributionPayment = new PensionPlanContributionPayment(),
                            ContributionTax = "",
                            MinimunRequirement = new PensionPlanMinimunRequirement
                            {
                                MinRequirementContractType = product.TIPO_PESSOA == "PF" ? RequirementContractTypeEnum.INDIVIDUAL : RequirementContractTypeEnum.COLETIVO,//TODO : bater qual será esse campo
                                MinRequirementContract = ""
                            },
                            TargetAudiance = TargetAudianceEnum.PESSOA_JURIDICA

                        });
                    }
                    else
                    {
                        count++;

                        cnpj = product.CNPJ_COD_FUNDO;

                        response.Data.Companies.Add(new PensionPlanCompany
                        {
                            CnpjNumber = product.CNPJ_COD_FUNDO,
                            Name = product.DESCRICAO_COD_FUNDO,
                            PensionPlanProducts = new List<PensionPlanProduct>()
                        });

                        response.Data.Companies[count].PensionPlanProducts.Add(new PensionPlanProduct
                        {
                            Name = product.NOME_PRODUTO,
                            Code = product.COD_PRODUTO,
                            Modality = ModalityEnum.PECULIO, //TODO : bater qual será esse campo
                            PensionPlanCoverages = "Aposentadoria",
                            Additional = (AdditionalEnum)Convert.ToInt16(product.COD_PRODUTO),
                            AdditionalOthers = new List<string>(),
                            AssistanceTypes = AssistanceTypeEnum.N_A,
                            AssistanceTypesOthers = new List<string>(),
                            TermsAndConditions = new PensionPlanTerm
                            {
                                SusepProcessNumber = product.COD_SUSEP,
                                Definition = product.DESCRICAO_COD_FUNDO
                            },
                            UpdatePMBaC = new PensionPlanUpdatePMBaC
                            {
                                InterestRate = "6",
                                UpdateIndex = UpdateIndexPersonPlanEnum.IPCA,
                            },
                            PremiumUpdateIndex = PremiumUpdateIndexEnum.IPCA,
                            AgeReframing = new PensionPlanAgeReframing
                            {
                                ReframingCriterion = ReframingCriterionEnum.MUDANCA_FAIXA_ETARIA,
                                ReframingPeriodicty = 0
                            },
                            FinancialRegimeContractType = RegimeContractTypeEnum.CAPITALIZACAO,
                            Reclaim = new PensionPlanReclaim
                            {
                                ReclaimTable = new PensionPlanReclaimTable
                                {
                                    InitialMonthRange = 1,
                                    FinalMonthRange = 12,
                                    Percentage = "0"
                                },
                                DifferentiatePercentage = "",
                                GracePeriod = "60"
                            },
                            OtherGuarateedValues = OtherGuarateedValuesEnum.NAO_APLICA,
                            ProfitModality = product.Modalidade_Indenizacao == "PAGAMENTO_UNICO" ? ProfitModalityEnum.PAGAMENTO_UNICO : ProfitModalityEnum.FORMA_RENDA,
                            ContributionPayment = new PensionPlanContributionPayment(),
                            ContributionTax = "",
                            MinimunRequirement = new PensionPlanMinimunRequirement
                            {
                                MinRequirementContractType = product.TIPO_PESSOA == "PF" ? RequirementContractTypeEnum.INDIVIDUAL : RequirementContractTypeEnum.COLETIVO,//TODO : bater qual será esse campo
                                MinRequirementContract = ""
                            },
                            TargetAudiance = TargetAudianceEnum.PESSOA_JURIDICA
                        });
                    }

                }

                response.Data.Companies = response.Data.Companies.Skip(4).Take(20).ToList();

                response.MetaPaginated.TotalPages = request.Page;
                response.MetaPaginated.TotalRecords = request.PageSize;                

                return new PensionPlanDTO() 
                {
                    ResponseCode = 200,
                    ResponseMessage = "",
                    PensionPlan = response
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }        
            
        }
    }
}
