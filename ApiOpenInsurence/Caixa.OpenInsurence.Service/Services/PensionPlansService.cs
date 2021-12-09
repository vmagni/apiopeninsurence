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
                var responseServiceCaixa = await _databaseService.GetProdutosPrevidenciaCompleto();

    
                PensionPlanResponse response = new PensionPlanResponse();

                //response.RequestTime = DateTime.Now.ToLongDateString();

                response.Data.Name = "";//TODO : bater qual será esse campo

                var t = responseServiceCaixa.dados.OrderBy(x => x.CNPJ_COD_FUNDO).Take(10).ToList();

                string cnpj = "vazio";
                int count = -1;

                foreach (var product in t)
                {

                    if (cnpj == product.CNPJ_COD_FUNDO)
                    {
                        response.Data.Companies[count].PensionPlanProducts.Add(new PensionPlanProduct
                        {
                            Name = product.NOME_PRODUTO,
                            Code = product.COD_PRODUTO,
                            Modality = ModalityEnum.PECULIO, //TODO : bater qual será esse campo
                            PensionPlanCoverages = new List<PensionPlanCoverage>(),//TODO : bater qual será esse campo
                            Additional = (AdditionalEnum)Convert.ToInt16(product.COD_PRODUTO),//TODO : esta correto ?
                            AdditionalOthers = new List<string>(),//TODO : bater qual será esse campo
                            AssistanceTypes = AssistanceTypeEnum.N_A,//TODO : bater qual será esse campo
                            AssistanceTypesOthers = new List<string>(),//TODO : bater qual será esse campo
                            TermsAndConditions = new PensionPlanTerm
                            {
                                SusepProcessNumber = product.COD_SUSEP,
                                Definition = "" //TODO : bater qual será esse campo
                            },
                            UpdatePMBaC = new PensionPlanUpdatePMBaC
                            {
                                InterestRate = "6",//TODO : bater qual será esse campo
                                UpdateIndex = UpdateIndexPersonPlanEnum.IPCA,//TODO : bater qual será esse campo
                            },
                            PremiumUpdateIndex = PremiumUpdateIndexEnum.IPCA,//TODO : bater qual será esse campo
                            AgeReframing = new PensionPlanAgeReframing
                            {
                                ReframingCriterion = ReframingCriterionEnum.MUDANCA_FAIXA_ETARIA,//TODO : bater qual será esse campo
                                ReframingPeriodicty = 0 //TODO : bater qual será esse campo
                            },
                            FinancialRegimeContractType = RegimeContractTypeEnum.CAPITALIZACAO,//TODO : bater qual será esse campo
                            Reclaim = new PensionPlanReclaim
                            {
                                ReclaimTable = new PensionPlanReclaimTable
                                {
                                    InitialMonthRange = 1,//TODO : bater qual será esse campo
                                    FinalMonthRange = 12,//TODO : bater qual será esse campo
                                    Percentage = "0"//TODO : bater qual será esse campo
                                },
                                DifferentiatePercentage = "",//TODO : bater qual será esse campo
                                GracePeriod = "60"//TODO : bater qual será esse campo
                            },
                            OtherGuarateedValues = OtherGuarateedValuesEnum.NAO_APLICA,//TODO : bater qual será esse campo
                            ProfitModality = ProfitModalityEnum.FORMA_RENDA,//TODO : bater qual será esse campo
                            ContributionPayment = new PensionPlanContributionPayment
                            {
                                ContributionPaymentMethod = ContributionPaymentMethodEnum.BOLETO_BANCARIO,//TODO : bater qual será esse campo
                                ContributionPeriodicity = ContributionPeriodicityEnum.ANUAL//TODO : bater qual será esse campo
                            },
                            ContributionTax = "",
                            MinimunRequirement = new PensionPlanMinimunRequirement
                            {
                                MinRequirementContractType = product.TIPO_PESSOA == "PF" ? RequirementContractTypeEnum.INDIVIDUAL : RequirementContractTypeEnum.COLETIVO,//TODO : bater qual será esse campo
                                MinRequirementContract = ""//TODO : bater qual será esse campo
                            },
                            TargetAudiance = TargetAudianceEnum.PESSOA_JURIDICA//TODO : Esta vindo string do API product.TIPO_PESSOA

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
                            PensionPlanCoverages = new List<PensionPlanCoverage>(),//TODO : bater qual será esse campo
                            Additional = (AdditionalEnum)Convert.ToInt16(product.COD_PRODUTO),//TODO : esta correto ?
                            AdditionalOthers = new List<string>(),//TODO : bater qual será esse campo
                            AssistanceTypes = AssistanceTypeEnum.AUTOMOVEL,//TODO : bater qual será esse campo
                            AssistanceTypesOthers = new List<string>(),//TODO : bater qual será esse campo
                            TermsAndConditions = new PensionPlanTerm
                            {
                                SusepProcessNumber = product.COD_SUSEP,
                                Definition = "" //TODO : bater qual será esse campo
                            },
                            UpdatePMBaC = new PensionPlanUpdatePMBaC
                            {
                                InterestRate = "0",//TODO : bater qual será esse campo
                                UpdateIndex = UpdateIndexPersonPlanEnum.FINANCEIRA,//TODO : bater qual será esse campo
                            },
                            PremiumUpdateIndex = PremiumUpdateIndexEnum.IGPM,//TODO : bater qual será esse campo
                            AgeReframing = new PensionPlanAgeReframing
                            {
                                ReframingCriterion = ReframingCriterionEnum.NAO_APLICAVEL,//TODO : bater qual será esse campo
                                ReframingPeriodicty = 0 //TODO : bater qual será esse campo
                            },
                            FinancialRegimeContractType = RegimeContractTypeEnum.CAPITALIZACAO,//TODO : bater qual será esse campo
                            Reclaim = new PensionPlanReclaim
                            {
                                ReclaimTable = new PensionPlanReclaimTable
                                {
                                    InitialMonthRange = 0,//TODO : bater qual será esse campo
                                    FinalMonthRange = 0,//TODO : bater qual será esse campo
                                    Percentage = ""//TODO : bater qual será esse campo
                                },
                                DifferentiatePercentage = "",//TODO : bater qual será esse campo
                                GracePeriod = ""//TODO : bater qual será esse campo
                            },
                            OtherGuarateedValues = OtherGuarateedValuesEnum.NAO_APLICA,//TODO : bater qual será esse campo
                            ProfitModality = ProfitModalityEnum.FORMA_RENDA,//TODO : bater qual será esse campo
                            ContributionPayment = new PensionPlanContributionPayment
                            {
                                ContributionPaymentMethod = ContributionPaymentMethodEnum.BOLETO_BANCARIO,//TODO : bater qual será esse campo
                                ContributionPeriodicity = ContributionPeriodicityEnum.ANUAL//TODO : bater qual será esse campo
                            },
                            ContributionTax = "",
                            MinimunRequirement = new PensionPlanMinimunRequirement
                            {
                                MinRequirementContractType = RequirementContractTypeEnum.INDIVIDUAL,//TODO : bater qual será esse campo
                                MinRequirementContract = ""//TODO : bater qual será esse campo
                            },
                            TargetAudiance = TargetAudianceEnum.PESSOA_JURIDICA//TODO : Esta vindo string do API product.TIPO_PESSOA

                        });
                    }

                }


                //var pensionplan = responseServiceCaixa.dados.Select(x => new PensionPlanCompany
                //{
                //   Name = DateTime.Now.ToLongTimeString(),

                //}).ToList();

                //response.Data.Companies.AddRange(pensionplan);

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
