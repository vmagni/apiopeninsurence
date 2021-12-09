using System;
using System.ComponentModel.DataAnnotations;

namespace Caixa.OpenInsurence.Model.Api.Shared
{
    public class CustomValidations : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            if (value is string)
                return false;

            int i = Convert.ToInt32(value);

            if(i == 0 || i < 0)
                return false;

            return true;
           
        }
    }
}
