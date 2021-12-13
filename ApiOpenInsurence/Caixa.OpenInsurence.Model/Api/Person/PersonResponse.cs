using Caixa.OpenInsurence.Model.Api.Shared;
using Caixa.OpenInsurence.Model.Data.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Api.Person
{
    public class PersonResponse
    {
        public PersonBrand Brand { get; set; }
        public LinksPaginated LinksPaginated { get; set; }
        public MetaPaginated MetaPaginated { get; set; }

        public PersonResponse(PersonResponse response)
        {
            Brand = response.Brand;

            LinksPaginated = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/person");

            MetaPaginated = response.MetaPaginated;

        }

        public PersonResponse()
        {
            Brand = new PersonBrand();

            LinksPaginated = new LinksPaginated("https://api.seguradora.com.br/open-insurance/products-services/v1/person");

            MetaPaginated = new MetaPaginated();
        }
    }
}
