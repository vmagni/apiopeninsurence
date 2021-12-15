using Caixa.OpenInsurence.Model.Api.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.Channel
{
    public class BranchChannelsDTO: ValidaResponseDTO
    {
        private BranchChannelsDTO channelsDTO;

        public BranchChannelsDTO()
        {
        }

        public BranchChannelsDTO(BranchChannelsDTO channelsDTO)
        {
            this.channelsDTO = channelsDTO;
        }

        public BranchChannelResponse BranchChannelsResponse { get; set; }
    }

    public class PhoneChannelsDTO : ValidaResponseDTO
    {
        private PhoneChannelsDTO channelsDTO;

        public PhoneChannelsDTO()
        {
        }

        public PhoneChannelsDTO(PhoneChannelsDTO channelsDTO)
        {
            this.channelsDTO = channelsDTO;
        }

        public PhoneChannelResponse PhoneChannelResponse { get; set; }
    }

    public class ElectronicChannelsDTO : ValidaResponseDTO
    {
        private ElectronicChannelsDTO channelsDTO;

        public ElectronicChannelsDTO()
        {
        }

        public ElectronicChannelsDTO(ElectronicChannelsDTO channelsDTO)
        {
            this.channelsDTO = channelsDTO;
        }

        public ElectronicChannelResponse ElectronicChannelResponse { get; set; }
    }

}
