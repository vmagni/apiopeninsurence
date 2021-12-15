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

                response.Brand.Name = "CAIXA VIDA E PREVIDENCIA";

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
                            Segment = SegmentEnum.PREVIDENCIA,
                            Modality = ModalityEnumLife.BENEFICIO_DEFINIDO, 
                            OptionalCoverage = "",
                            productDetails = new LifePensionProductDetails
                            {
                                SusepProcessNumber = product.COD_SUSEP,
                                Type = TypeEnum.OUTROS,
                                ContractTermsConditions = "https://www.caixavidaeprevidencia.com.br",
                                DefferalPeriod = new LifePensionDefferalPeriod
                                {
                                    InterestRate= 0,
                                    UpdateIndex = UpdateIndexEnum.OUTROS,
                                    otherMinimumPerformanceGarantees = "",
                                    ReversalFinancialResults = 0,
                                    minimumPremiumAmount= new MinimumPremiumAmount(),
                                    PremiumPaymentMethod = PremiumPaymentMethodEnum.DEBITO_CONTA,
                                    PermissionExtraordinaryContributions = true,
                                    PermissonScheduledFinancialPayments = true,
                                    GracePeriodRedemption = 100,
                                    GracePeriodBetweenRedemptionRequests = 30,
                                    RedemptionPaymentTerm = 10,
                                    GracePeriodPortability = 12,
                                    GracePeriodBetweenPortabilityRequests = 15,
                                    PortabilityPaymentTerm = 20,
                                    InvestimentFunds = new LifePensionInvestmentFunds
                                    {
                                        CnpjNumber = cnpj,
                                        CompanyName = product.DESCRICAO_COD_FUNDO,
                                        MaximumAdministrationFee = 20.1,
                                        TypePerformanceFee = TypePerformanceFeeEnum.DIRETAMENTE,
                                        MaximumPerformanceFee = 20,
                                        EligibilityRule = true,
                                        MinimumContributionAmount = 500,
                                        MinimumMathematicalProvisionAmount = 500
                                    }
                                },
                                GrantPeriodBenefit = new LifePensionPeriodGrantBenefit
                                {
                                    IncomeModality = IncomeModalityEnum.RENDA_PRAZO_CERTO,
                                    BiometricTable = BiometricTableEnum.OUTROS,
                                    interestRate = 3.225,
                                    UpdateIndex = UpdateIndexEnum.IPCA,
                                    ReversalResultsFinancial = 13.252,
                                    InvestimentFunds = new LifePensionInvestmentFunds
                                    {
                                        CnpjNumber = cnpj,
                                        CompanyName = product.DESCRICAO_COD_FUNDO,
                                        MaximumAdministrationFee = 20.1,
                                        TypePerformanceFee = TypePerformanceFeeEnum.DIRETAMENTE,
                                        MaximumPerformanceFee = 20,
                                        EligibilityRule = true,
                                        MinimumContributionAmount = 500,
                                        MinimumMathematicalProvisionAmount = 500
                                    }
                                },
                                Costs = new LifePensionCosts
                                {
                                    LoadingAntecipated = new LifePensionLoading
                                    {
                                        MaxValue =4.122,
                                        MinValue =  10
                                    },
                                    LoadingLate = new LifePensionLoading
                                    {
                                        MaxValue =4.122,
                                        MinValue =  10
                                    }
                                }
                            },
                            MinimumRequirements = new LifePensionMinimumRequirements
                            {
                                ContractType = ContractTypeEnum.INDIVIDUAL,
                                ParticipantQualified = true,
                                MinRequirementsContract = "10"
                            },
                            targetAudience = TargetAudienceEnum.PESSOA_NATURAL

                        });
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
                            Segment = SegmentEnum.PREVIDENCIA,
                            Modality = ModalityEnumLife.BENEFICIO_DEFINIDO,
                            OptionalCoverage = "",
                            productDetails = new LifePensionProductDetails
                            {
                                SusepProcessNumber = product.COD_SUSEP,
                                Type = TypeEnum.OUTROS,
                                ContractTermsConditions = "https://www.caixavidaeprevidencia.com.br",
                                DefferalPeriod = new LifePensionDefferalPeriod
                                {
                                    InterestRate= 0,
                                    UpdateIndex = UpdateIndexEnum.OUTROS,
                                    otherMinimumPerformanceGarantees = "",
                                    ReversalFinancialResults = 0,
                                    minimumPremiumAmount= new MinimumPremiumAmount(),
                                    PremiumPaymentMethod = PremiumPaymentMethodEnum.DEBITO_CONTA,
                                    PermissionExtraordinaryContributions = true,
                                    PermissonScheduledFinancialPayments = true,
                                    GracePeriodRedemption = 100,
                                    GracePeriodBetweenRedemptionRequests = 30,
                                    RedemptionPaymentTerm = 10,
                                    GracePeriodPortability = 12,
                                    GracePeriodBetweenPortabilityRequests = 15,
                                    PortabilityPaymentTerm = 20,
                                    InvestimentFunds = new LifePensionInvestmentFunds
                                    {
                                        CnpjNumber = cnpj,
                                        CompanyName = product.DESCRICAO_COD_FUNDO,
                                        MaximumAdministrationFee = 20.1,
                                        TypePerformanceFee = TypePerformanceFeeEnum.DIRETAMENTE,
                                        MaximumPerformanceFee = 20,
                                        EligibilityRule = true,
                                        MinimumContributionAmount = 500,
                                        MinimumMathematicalProvisionAmount = 500
                                    }
                                },
                                GrantPeriodBenefit = new LifePensionPeriodGrantBenefit
                                {
                                    IncomeModality = IncomeModalityEnum.RENDA_PRAZO_CERTO,
                                    BiometricTable = BiometricTableEnum.OUTROS,
                                    interestRate = 3.225,
                                    UpdateIndex = UpdateIndexEnum.IPCA,
                                    ReversalResultsFinancial = 13.252,
                                    InvestimentFunds = new LifePensionInvestmentFunds
                                    {
                                        CnpjNumber = cnpj,
                                        CompanyName = product.DESCRICAO_COD_FUNDO,
                                        MaximumAdministrationFee = 20.1,
                                        TypePerformanceFee = TypePerformanceFeeEnum.DIRETAMENTE,
                                        MaximumPerformanceFee = 20,
                                        EligibilityRule = true,
                                        MinimumContributionAmount = 500,
                                        MinimumMathematicalProvisionAmount = 500
                                    }
                                },
                                Costs = new LifePensionCosts
                                {
                                    LoadingAntecipated = new LifePensionLoading
                                    {
                                        MaxValue =4.122,
                                        MinValue =  10
                                    },
                                    LoadingLate = new LifePensionLoading
                                    {
                                        MaxValue =4.122,
                                        MinValue =  10
                                    }
                                }
                            },
                            MinimumRequirements = new LifePensionMinimumRequirements
                            {
                                ContractType = ContractTypeEnum.INDIVIDUAL,
                                ParticipantQualified = true,
                                MinRequirementsContract = "10"
                            },
                            targetAudience = TargetAudienceEnum.PESSOA_NATURAL

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
