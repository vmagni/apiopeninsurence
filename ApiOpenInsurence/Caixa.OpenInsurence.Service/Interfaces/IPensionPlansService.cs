using Caixa.OpenInsurence.Model.Api.Channel;
using Caixa.OpenInsurence.Model.Api.PensionPlan;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Service.Interfaces
{
    public interface IPensionPlansService
    {
        public Task<PensionPlanResponse> GetPensionPlan(ChannelsRequest request);
    }
}
