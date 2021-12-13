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

}
