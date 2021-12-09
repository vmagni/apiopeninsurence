using Caixa.OpenInsurence.Model.Enums.Channel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Caixa.OpenInsurence.Model.Data.Channel
{
    public class BranchService
    {
        public ServicesEnum Type { get; set; }
        public string Name { get => Name; set => Name = Type.ToString(); }
        public int Code { get => Code; set => Code = (int)Type; }
    }
}
