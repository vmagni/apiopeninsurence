using Caixa.OpenInsurence.Data.Interfaces;
using Caixa.OpenInsurence.Model.Api.LifePension;
using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.LifePension;
using Caixa.OpenInsurence.Model.Data.Token;
using Caixa.OpenInsurence.Model.Enums.LifePension;
using Caixa.OpenInsurence.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Services
{
    public class LifePensionService : ILifePensionService
    {
        private readonly IDatabaseService _databaseService;

        public LifePensionService (IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public async Task<ValidaResponseDTO> GetLifePension(ApiRequest request)
        {
            try
            {
                var responseServiceCaixa = await _databaseService.GetProdutosVidaPfCompleto();


                LifePensionResponse response = new LifePensionResponse();

                response.Brand.Name = "";

                var dados = responseServiceCaixa.dados.OrderBy(x => x.CNPJ_COD_FUNDO).ToList();

                string cnpj = "vazio";
                int count = -1;


                foreach (var product in dados)
                {

                    if (cnpj == product.CNPJ_COD_FUNDO)
                    {
                        response.Brand.companies[count].products.Add(new LifePensionProduct
                        {
                            Name = product.NOME_PRODUTO,
                            Code = product.COD_PRODUTO,
                            Segment = SegmentEnum.PREVIDENCIA,//TODO : bater qual será esse campo
                            Modality = ModalityEnumLife.BENEFICIO_DEFINIDO, //TODO : bater qual será esse campo
                            OptionalCoverage = "",//TODO : bater qual será esse campo
                            productDetails = new LifePensionProductDetails
                            {
                                SusepProcessNumber = product.COD_SUSEP,
                                Type = TypeEnum.VGBL,  //TODO : bater qual será esse campo
                                ContractTermsConditions = "",//TODO : bater qual será esse campo
                                DefferalPeriod = new LifePensionDefferalPeriod
                                {
                                    InterestRate= 0,//TODO : bater qual será esse campo
                                    UpdateIndex = UpdateIndexEnum.IPCA,//TODO : bater qual será esse campo
                                    otherMinimumPerformanceGarantees = "",//TODO : bater qual será esse campo
                                    ReversalFinancialResults = 0,//TODO : bater qual será esse campo
                                    minimumPremiumAmount= new MinimumPremiumAmount(),//TODO : bater qual será esse campo
                                    PremiumPaymentMethod = PremiumPaymentMethodEnum.CARTAO_CREDITO,//TODO : bater qual será esse campo
                                    PermissionExtraordinaryContributions = false,//TODO : bater qual será esse campo
                                    PermissonScheduledFinancialPayments = false,//TODO : bater qual será esse campo
                                    GracePeriodRedemption = 0,//TODO : bater qual será esse campo
                                    GracePeriodBetweenRedemptionRequests = 0,//TODO : bater qual será esse campo
                                    RedemptionPaymentTerm = 0,//TODO : bater qual será esse campo
                                    GracePeriodPortability = 0,//TODO : bater qual será esse campo
                                    GracePeriodBetweenPortabilityRequests = 0,//TODO : bater qual será esse campo
                                    PortabilityPaymentTerm = 0,//TODO : bater qual será esse campo
                                    InvestimentFunds = new LifePensionInvestmentFunds
                                    {
                                        CnpjNumber = "",//TODO : bater qual será esse campo
                                        CompanyName = "",//TODO : bater qual será esse campo
                                        MaximumAdministrationFee = 0,//TODO : bater qual será esse campo
                                        TypePerformanceFee = TypePerformanceFeeEnum.NAO_APLICA,//TODO : bater qual será esse campo
                                        MaximumPerformanceFee = 0,//TODO : bater qual será esse campo
                                        EligibilityRule = false,//TODO : bater qual será esse campo
                                        MinimumContributionAmount = 0,//TODO : bater qual será esse campo
                                        MinimumMathematicalProvisionAmount = 0//TODO : bater qual será esse campo
                                    }
                                },
                                GrantPeriodBenefit = new LifePensionPeriodGrantBenefit
                                {
                                    IncomeModality = IncomeModalityEnum.PAGAMENTO_UNICO,//TODO : bater qual será esse campo
                                    BiometricTable = BiometricTableEnum.AT_2000_MALE_SUAVIZADA_15, //Existe o campo TABUA_ATUARIAL e TABUA_ATUARIAL_FML, porem não são iguias aos enums existentes
                                    interestRate = 0,//TODO : bater qual será esse campo
                                    UpdateIndex = UpdateIndexEnum.IPCA,//TODO : bater qual será esse campo
                                    ReversalResultsFinancial = 0,//TODO : bater qual será esse campo
                                    InvestimentFunds = new LifePensionInvestmentFunds
                                    {
                                        CnpjNumber = "",//TODO : bater qual será esse campo
                                        CompanyName = "",//TODO : bater qual será esse campo
                                        MaximumAdministrationFee = 0,//TODO : bater qual será esse campo
                                        TypePerformanceFee = TypePerformanceFeeEnum.NAO_APLICA,//TODO : bater qual será esse campo
                                        MaximumPerformanceFee = 0,//TODO : bater qual será esse campo
                                        EligibilityRule = false,//TODO : bater qual será esse campo
                                        MinimumContributionAmount = 0,//TODO : bater qual será esse campo
                                        MinimumMathematicalProvisionAmount = 0//TODO : bater qual será esse campo
                                    }
                                },
                                Costs = new LifePensionCosts
                                {
                                    LoadingAntecipated = new LifePensionLoading
                                    {
                                        MaxValue =0,   //TODO : bater qual será esse campo
                                        MinValue =  0//TODO : bater qual será esse campo
                                    },
                                    LoadingLate = new LifePensionLoading
                                    {
                                        MaxValue =0,//TODO : bater qual será esse campo
                                        MinValue =  0//TODO : bater qual será esse campo
                                    }
                                }
                            },
                            MinimumRequirements = new LifePensionMinimumRequirements
                            {
                                ContractType = ContractTypeEnum.INDIVIDUAL,//TODO : bater qual será esse campo
                                ParticipantQualified = false,//TODO : bater qual será esse campo
                                MinRequirementsContract = ""//TODO : bater qual será esse campo
                            },
                            targetAudience = TargetAudienceEnum.PESSOA_NATURAL  //TODO : bater qual será esse campo                          

                        }) ;
                    }
                    else
                    {
                        count++;

                        cnpj = product.CNPJ_COD_FUNDO;

                        response.Brand.companies.Add(new LifePensionCompany
                        {
                            CnpjNumber = product.CNPJ_COD_FUNDO,
                            Name = product.DESCRICAO_COD_FUNDO,
                            products = new List<LifePensionProduct>()
                        });

                        response.Brand.companies[count].products.Add(new LifePensionProduct
                        {
                            Name = product.NOME_PRODUTO,
                            Code = product.COD_PRODUTO,
                            Segment = SegmentEnum.PREVIDENCIA,//TODO : bater qual será esse campo
                            Modality = ModalityEnumLife.BENEFICIO_DEFINIDO, //TODO : bater qual será esse campo
                            OptionalCoverage = "",//TODO : bater qual será esse campo
                            productDetails = new LifePensionProductDetails
                            {
                                SusepProcessNumber = product.COD_SUSEP,
                                Type = TypeEnum.VGBL,  //TODO : bater qual será esse campo
                                ContractTermsConditions = "",//TODO : bater qual será esse campo
                                DefferalPeriod = new LifePensionDefferalPeriod
                                {
                                    InterestRate= 0,//TODO : bater qual será esse campo
                                    UpdateIndex = UpdateIndexEnum.IPCA,//TODO : bater qual será esse campo
                                    otherMinimumPerformanceGarantees = "",//TODO : bater qual será esse campo
                                    ReversalFinancialResults = 0,//TODO : bater qual será esse campo
                                    minimumPremiumAmount= new MinimumPremiumAmount(),//TODO : bater qual será esse campo
                                    PremiumPaymentMethod = PremiumPaymentMethodEnum.CARTAO_CREDITO,//TODO : bater qual será esse campo
                                    PermissionExtraordinaryContributions = false,//TODO : bater qual será esse campo
                                    PermissonScheduledFinancialPayments = false,//TODO : bater qual será esse campo
                                    GracePeriodRedemption = 0,//TODO : bater qual será esse campo
                                    GracePeriodBetweenRedemptionRequests = 0,//TODO : bater qual será esse campo
                                    RedemptionPaymentTerm = 0,//TODO : bater qual será esse campo
                                    GracePeriodPortability = 0,//TODO : bater qual será esse campo
                                    GracePeriodBetweenPortabilityRequests = 0,//TODO : bater qual será esse campo
                                    PortabilityPaymentTerm = 0,//TODO : bater qual será esse campo
                                    InvestimentFunds = new LifePensionInvestmentFunds
                                    {
                                        CnpjNumber = "",//TODO : bater qual será esse campo
                                        CompanyName = "",//TODO : bater qual será esse campo
                                        MaximumAdministrationFee = 0,//TODO : bater qual será esse campo
                                        TypePerformanceFee = TypePerformanceFeeEnum.NAO_APLICA,//TODO : bater qual será esse campo
                                        MaximumPerformanceFee = 0,//TODO : bater qual será esse campo
                                        EligibilityRule = false,//TODO : bater qual será esse campo
                                        MinimumContributionAmount = 0,//TODO : bater qual será esse campo
                                        MinimumMathematicalProvisionAmount = 0//TODO : bater qual será esse campo
                                    }
                                },
                                GrantPeriodBenefit = new LifePensionPeriodGrantBenefit
                                {
                                    IncomeModality = IncomeModalityEnum.PAGAMENTO_UNICO,//TODO : bater qual será esse campo
                                    BiometricTable = BiometricTableEnum.AT_2000_MALE_SUAVIZADA_15, //Existe o campo TABUA_ATUARIAL e TABUA_ATUARIAL_FML, porem não são iguias aos enums existentes
                                    interestRate = 0,//TODO : bater qual será esse campo
                                    UpdateIndex = UpdateIndexEnum.IPCA,//TODO : bater qual será esse campo
                                    ReversalResultsFinancial = 0,//TODO : bater qual será esse campo
                                    InvestimentFunds = new LifePensionInvestmentFunds
                                    {
                                        CnpjNumber = "",//TODO : bater qual será esse campo
                                        CompanyName = "",//TODO : bater qual será esse campo
                                        MaximumAdministrationFee = 0,//TODO : bater qual será esse campo
                                        TypePerformanceFee = TypePerformanceFeeEnum.NAO_APLICA,//TODO : bater qual será esse campo
                                        MaximumPerformanceFee = 0,//TODO : bater qual será esse campo
                                        EligibilityRule = false,//TODO : bater qual será esse campo
                                        MinimumContributionAmount = 0,//TODO : bater qual será esse campo
                                        MinimumMathematicalProvisionAmount = 0//TODO : bater qual será esse campo
                                    }
                                },
                                Costs = new LifePensionCosts
                                {
                                    LoadingAntecipated = new LifePensionLoading
                                    {
                                        MaxValue =0,   //TODO : bater qual será esse campo
                                        MinValue =  0//TODO : bater qual será esse campo
                                    },
                                    LoadingLate = new LifePensionLoading
                                    {
                                        MaxValue =0,//TODO : bater qual será esse campo
                                        MinValue =  0//TODO : bater qual será esse campo
                                    }
                                }
                            },
                            MinimumRequirements = new LifePensionMinimumRequirements
                            {
                                ContractType = ContractTypeEnum.INDIVIDUAL,//TODO : bater qual será esse campo
                                ParticipantQualified = false,//TODO : bater qual será esse campo
                                MinRequirementsContract = ""//TODO : bater qual será esse campo
                            },
                            targetAudience = TargetAudienceEnum.PESSOA_NATURAL  //TODO : bater qual será esse campo                          

                        });
                    }

                }

                response.Brand.companies = response.Brand.companies.Take(1).ToList();

                response.MetaPaginated.TotalPages = request.Page;
                response.MetaPaginated.TotalRecords = request.PageSize;

                return new LifePensionDTO()
                {
                    ResponseCode = 200,
                    ResponseMessage = "",
                    LifePension = response
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
