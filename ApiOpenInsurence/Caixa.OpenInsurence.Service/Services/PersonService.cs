using Caixa.OpenInsurence.Data.Interfaces;
using Caixa.OpenInsurence.Model.Api.Person;
using Caixa.OpenInsurence.Model.Api.Shared;
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

                response.Brand.Name = ""; // Deixar fixo vazio ?

                response.Brand.companies.Name = "";// Deixar fixo vazio ?
                response.Brand.companies.CnpjNumber = "";// Deixar fixo vazio ?

                foreach (var product in dados)
                {

                    response.Brand.companies.PersonProducts.Add(new PersonProduct
                    {
                        Name = product.SEGUROS == null ? "" : product.SEGUROS,//Algusn seguros vem sem nome, o que fazer ?
                        Code = product.COD_PRODUTO,
                        Category = CategoryEnum.TRADICIONAL, // Deixar fixo sempre Tradicional ?
                        InsuranceModality = InsuranceModalityEnum.FUNERAL,// Deixar fixo sempre Funeral ?
                        Coverages = new List<Coverage>(),//O que colocar ?
                        AssistanceType = AssistanceTypePersonEnum.FUNERAL,//Deixar fixo sempre Funeral ?
                        Additional = AdditionalPersonEnum.NAO_HA,//Deixar fixo sempre NAO_HA ?
                        AssistanceTypeOthers = new List<string>(),//Deixar fixo Lista Fazia ?
                        TermsAndConditions = new List<PersonTermsAndCondition>(),// existe o campo PROCESSO_SUSEP, porém não é um lista
                        GlobalCapital = false, //Deixar fixo false ?
                        Validity = ValidityEnum.VITALICIA,//Deixar fixo VITALICIA ?
                        PmbacRemuneration = new PersonPmbacRemuneration
                        {
                            CapitalizationMethod = CapitalizationMethodEnum.FINANCEIRA,//Deixar fixo FINANCEIRA ?
                            InterestRate = 0,//Deixar fixo 0 ?
                            PmbacUpdateIndex = PmbacUpdateIndexEnum.IPCA //Deixar fixo IPCA ?
                        },
                        BenefitRecalculation = new PersonBenefitRecalculation
                        {
                            BenefitRecalculationCriteria = BenefitRecalculationCriteriaEnum.INDICE,//Deixar fixo INDICE ?
                            BenefitUpdateIndex = BenefitUpdateIndexEnum.IPCA //Deixar fixo IPCA ?
                        },
                        AgeAdjustment = new PersonAgeAdjustment
                        {
                            Criterion = CriterionEnum.APOS_PERIODO_EM_ANOS,//Deixar fixo APOS_PERIODO_EM_ANOS ?
                            Frequency = (int)FrequencyEnum.DIARIA,//Deixar fixo DIARIA == 0 ?
                        },
                        ContractType = ContractTypePersonEnum.REPARTICAO_SIMPLES, //Deixar fixo REPARTICAO_SIMPLES ?
                        Reclaim = new PersonReclaim
                        {
                            ReclaimTable = new PersonReclaimTable
                            {
                                InitialMonthRange = 1,//Deixar fixo 1 ?
                                FinalMonthRange = 12,//Deixar fixo 12 ?
                                Percentage = 0 //Deixar fixo 0 ?
                            },
                            DifferentiatedPercentage = "",//Deixar fixo vazio ?
                            GracePeriod = new PersonCovaregeAttibutesDetails
                            {
                                Amount = 60,//Deixar fixo 60 ?
                                unit = new PersonCovaregeAttibutesDetailsUnit
                                {
                                    Code ="R$",//Deixar fixo R$ ?
                                    Description = ""//Deixar fixo vazio ?
                                }
                            }

                        },
                        OtherGuaranteedValues = OtherGuaranteedValuesEnum.SALDAMENTO,//Deixar fixo SALDAMENTO ?
                        PortabilityGraceTime = 0,//Deixar fixo 0 ?
                        IndemnityPaymentMethod = IndemnityPaymentMethodEnum.UNICO,//Deixar fixo UNICO ?
                        IndemnityPaymentIncome = IndemnityPaymentIncomeEnum.CERTA,//Deixar fixo CERTA ?
                        PremiumPayment = new PersonPremiumPayment
                        {
                            PaymentMethod = PaymentMethodPersonEnum.DEBITO_CONTA,// Existe o campo FORMA_PAGTO, porém é string
                            Frequency = FrequencyEnum.DIARIA,// Existe uma frenquencia no campo VALOR, mas esta dentro da string
                            premiumTax = ""//Deixar fixo vazio ?
                        },
                        MinimunRequirements = new PersonMinimunRequirements
                        {
                            ContractingType = ContractingTypeEnum.COLETIVO,//Deixar fixo COLETIVO ?
                            contractingMinRequirement = ""//Deixar fixo vazio ?
                        },
                        TargetAudience = TargetAudiencePersonEnum.PESSOA_NATURAL //Deixar fixo PESSOA_NATURAL ?

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
    }
}
