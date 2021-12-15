using System;
using System.Collections.Generic;
using System.Text;

namespace Caixa.OpenInsurence.Model.Data.LifePension
{
    public class LifePensionCosts
    {
        public LifePensionLoading LoadingAntecipated { get; set; }
        public LifePensionLoading LoadingLate { get; set; }

        public LifePensionCosts()
        {
            LoadingAntecipated = new LifePensionLoading();
            LoadingLate = new LifePensionLoading();
        }
    }
}
