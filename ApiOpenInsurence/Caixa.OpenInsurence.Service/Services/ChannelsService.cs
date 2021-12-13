using Caixa.OpenInsurence.Data.Interfaces;
using Caixa.OpenInsurence.Model.Api;
using Caixa.OpenInsurence.Model.Api.Channel;
using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.Channel;
using Caixa.OpenInsurence.Model.Enums.Channel;
using Caixa.OpenInsurence.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Services
{

    public class ChannelsService : IChannelsService
    {
        private readonly IDatabaseService _databaseService;
        public ChannelsService(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<ValidaResponseDTO> GetBranches(ApiRequest request)
        {
            var responseServiceCaixa = await _databaseService.GetAgenciasCaixa();        
            var brachesGroupedBy = responseServiceCaixa.dados.GroupBy(x => x.CNPJ).ToList();

            BranchChannelResponse response = new BranchChannelResponse();
            int count = 0;
            foreach (var branches in brachesGroupedBy)
            {                  
                response.Data.Name = "Caixa Vida e Previdência";
                response.Data.Companies = new List<BranchCompany>();
                foreach (var branch in branches)
                {
                    count++;
                    BranchCompany company = new BranchCompany();
                    company.Cnpj = branch.CNPJ + "/" + branch.SEQUENCIAL_CNPJ;
                    company.Name = branch.NOME_INSTITUICAO;
                    company.UrlComplementaryList = null;
                    company.Branches = new List<Branch>();
                    Branch branchUnity = new Branch();

                    //Avaibility
                    branchUnity.Availbility = new Availability();
                    branchUnity.Availbility.IsPublicAccessAllowed = true;
                    branchUnity.Availbility.Standards = new List<AvailabilityStandards>();
                    AvailabilityStandards availabilityStandards = new AvailabilityStandards();
                    availabilityStandards.ClosingTime = branch.HORA_FECHAMENTO;
                    availabilityStandards.OpeningTime = branch.HORA_ABERTURA;
                    availabilityStandards.WeekDay = branch.DIA_SEMANA;
                    availabilityStandards.Exception = branch.EXCESSAO;
                    branchUnity.Availbility.Standards.Add(availabilityStandards);

                    //Identification
                    branchUnity.Identification = new BranchIdentification();
                    branchUnity.Identification.Name = branch.NOME_AGENCIA;
                    branchUnity.Identification.Code = null;
                    branchUnity.Identification.CheckDigit = 0;
                    branchUnity.Identification.Type = BranchTypesEnum.AGENCIA;

                    //Phones
                    branchUnity.Phones = new List<BranchPhone>();
                    BranchPhone phone = new BranchPhone();
                    phone.AreaCode = branch.DDD;
                    phone.CountryCallingCode = null;
                    phone.Number = branch.FONE;
                    phone.Type = null;
                    branchUnity.Phones.Add(phone);

                    //PostalAddress
                    branchUnity.PostalAddress = new BranchPostalAddress();
                    branchUnity.PostalAddress.AdditionalInfo = null;
                    branchUnity.PostalAddress.Address = branch.ENDERECO + ", " + branch.NUMERO + " - " + branch.COMPLEMENTO;
                    branchUnity.PostalAddress.DistrictName = branch.BAIRRO;
                    branchUnity.PostalAddress.PostCode = branch.CEP;
                    branchUnity.PostalAddress.Country = null;
                    branchUnity.PostalAddress.CountryCode = null;
                    branchUnity.PostalAddress.CountrySubDivision = branch.UF;
                    branchUnity.PostalAddress.TownName = branch.MUNICIPIO;

                    branchUnity.PostalAddress.GeographicCoordinates = new BranchCoordinates();
                    branchUnity.PostalAddress.GeographicCoordinates.Latitude = null;
                    branchUnity.PostalAddress.GeographicCoordinates.Longitude = null;

                    //Services
                    branchUnity.Services = new List<ChannelService>();
                    ChannelService service = new ChannelService();
                    service.Type = ServicesEnum.OUVIDORIA_SOLUCAO_EVENTUAIS_DIVERGENCIAS;
                    service.Code = (int)ServicesEnum.OUVIDORIA_SOLUCAO_EVENTUAIS_DIVERGENCIAS;
                    service.Name = ServicesEnum.OUVIDORIA_SOLUCAO_EVENTUAIS_DIVERGENCIAS.ToString();
                    branchUnity.Services.Add(service);

                    company.Branches.Add(branchUnity);
                    response.Data.Companies.Add(company);
                }
            }
            response.Meta.TotalRecords = count;
            return new BranchChannelsDTO()
            {
                ResponseCode = 200,
                ResponseMessage = "",
                BranchChannelsResponse = response
            };
        }

        public async Task<ValidaResponseDTO> GetEletronicChannels(ApiRequest request)
        {
            var responseServiceCaixa = await _databaseService.GetAgenciasCaixa();
            throw new NotImplementedException();
        }

        public async Task<ValidaResponseDTO> GetPhoneChannels(ApiRequest request)
        {
            var responseServiceCaixa = await _databaseService.GetAgenciasCaixa();
            throw new NotImplementedException();
        }
    }
}
