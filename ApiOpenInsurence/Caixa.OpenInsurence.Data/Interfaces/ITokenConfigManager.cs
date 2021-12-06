using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Data.Interfaces
{
    public interface ITokenConfigManager
    {
        public string TokenUrl { get; }
        public string TokenUsername { get;  }
    }

    public class TokenConfigManager : ITokenConfigManager
    {
        private readonly IConfiguration _configuration;
        public  TokenConfigManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string TokenUrl
        {
            get { return _configuration["TokenConfig:Url"]; }
        }

        public string TokenUsername
        {
            get { return _configuration["TokenConfig:Username"]; }
        }

    }
}
