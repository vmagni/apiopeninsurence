using Caixa.OpenInsurence.Data.Interfaces;
using Caixa.OpenInsurence.Model.Api.Person;
using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.Helpers;
using Caixa.OpenInsurence.Model.Data.Person;
using Caixa.OpenInsurence.Model.Enums.Person;
using Caixa.OpenInsurence.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Services
{
    public class PersonService : IPersonService
    {
        private readonly IDatabaseService _databaseService;
        public PersonService(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<ValidaResponseDTO> GetPerson(ApiRequest request)
        {
            try
            {
                var responseServiceCaixa = await _databaseService.GetProdutosVidaPf();

                PersonResponse response = new PersonResponse();

                var dados = responseServiceCaixa.dados.Take(1).ToList();

                response.Brand.Name = "Caixa Livre Previdência";

                response.Brand.companies.Name = "Caixa Livre Previdência";
                response.Brand.companies.CnpjNumber = "38.122.278/0001-04";

                foreach (var product in dados)
                {
                    var converages = ReturnCoverages(product);

                    response.Brand.companies.PersonProducts.Add(new PersonProduct
                    {
                        Name = product.SEGUROS == null ? "" : product.SEGUROS,
                        Code = product.COD_PRODUTO,
                        Category = CategoryEnum.TRADICIONAL,
                        InsuranceModality = InsuranceModalityEnum.FUNERAL,
                        Coverages = converages,
                        AssistanceType = AssistanceTypePersonEnum.FUNERAL,//Deixar fixo sempre Funeral ?
                        Additional = product.SERV_SORTEIOS == "S" ? AdditionalPersonEnum.SORTEIO : AdditionalPersonEnum.NAO_HA,
                        AssistanceTypeOthers = new List<string>(),
                        TermsAndConditions = new List<PersonTermsAndCondition> { new PersonTermsAndCondition 
                        { 
                            SusepProcessNumber = product.PROCESSO_SUSEP, 
                            Sefinition="" 

                        } },
                        GlobalCapital = false,
                        Validity = product.VIGENCIA_APOLICE != "" ? ValidityEnum.TEMPORARIA_PRAZO_FIXO : ValidityEnum.TEMPORARIA_INTERMITENTE,
                        PmbacRemuneration = new PersonPmbacRemuneration
                        {
                            CapitalizationMethod = CapitalizationMethodEnum.FINANCEIRA,
                            InterestRate = 0,
                            PmbacUpdateIndex = PmbacUpdateIndexEnum.IPCA
                        },
                        BenefitRecalculation = new PersonBenefitRecalculation
                        {
                            BenefitRecalculationCriteria = BenefitRecalculationCriteriaEnum.INDICE,
                            BenefitUpdateIndex = BenefitUpdateIndexEnum.IPCA
                        },
                        AgeAdjustment = new PersonAgeAdjustment
                        {
                            Criterion = CriterionEnum.APOS_PERIODO_EM_ANOS,
                            Frequency = (int)FrequencyEnum.DIARIA,
                        },
                        ContractType = ContractTypePersonEnum.REPARTICAO_SIMPLES,
                        Reclaim = new PersonReclaim
                        {
                            ReclaimTable = new PersonReclaimTable
                            {
                                InitialMonthRange = 0,
                                FinalMonthRange = 0,
                                Percentage = 0
                            },
                            DifferentiatedPercentage = "",
                            GracePeriod = new PersonCovaregeAttibutesDetails
                            {
                                Amount = 0,
                                unit = new PersonCovaregeAttibutesDetailsUnit
                                {
                                    Code ="",
                                    Description = ""
                                }
                            }

                        },
                        OtherGuaranteedValues = OtherGuaranteedValuesEnum.NAO_SE_APLICA,
                        PortabilityGraceTime = 0,
                        IndemnityPaymentMethod = IndemnityPaymentMethodEnum.UNICO,
                        IndemnityPaymentIncome = IndemnityPaymentIncomeEnum.TEMPORARIA,
                        PremiumPayment = new PersonPremiumPayment
                        {
                            PaymentMethod = PaymentMethodPersonEnum.CARTAO_CREDITO,
                            Frequency = FrequencyEnum.DIARIA,
                            premiumTax = ""
                        },
                        MinimunRequirements = new PersonMinimunRequirements
                        {
                            ContractingType = ContractingTypeEnum.COLETIVO,
                            contractingMinRequirement = ""
                        },
                        TargetAudience = TargetAudiencePersonEnum.PESSOA_NATURAL

                    }) ;
                    
                }

                response.MetaPaginated.TotalPages = request.Page;
                response.MetaPaginated.TotalRecords = request.PageSize;

                return new PersonDTO()
                {
                    ResponseCode = 200,
                    ResponseMessage = "",
                    Person = response
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private List<Coverage> ReturnCoverages(ProdutosVidaPfCompleto produtosVidaPfCompleto)
        {
            var response = new List<Coverage>();

            if (produtosVidaPfCompleto.COB_MORTE_ACIDENTAL == "S")
            {
                response.Add(new Coverage
                {
                    CoverageType = CoverageEnum.MORTE_ACIDENTAL,
                    CoverageOthers = "",
                    coverageAttributes = new PersonCoverageAttributes()
                });
            }

            if (produtosVidaPfCompleto.COB_INVAL_PERMA_TOTAL_PARC_ACIDENTE == "S")
            {
                response.Add(new Coverage
                {
                    CoverageType = CoverageEnum.INCAPACIDADE_TOTAL_ACIDENTE,
                    CoverageOthers = "",
                    coverageAttributes = new PersonCoverageAttributes()
                });

                response.Add(new Coverage
                {
                    CoverageType = CoverageEnum.INCAPACIDADE_PARCIAL_ACIDENTE,
                    CoverageOthers = "",
                    coverageAttributes = new PersonCoverageAttributes()
                });
            }

            return response;

        }
    }
}
