using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxamoT.Helper;
using TechTalk.SpecFlow;

namespace TaxamoT.Hook
{
    [Binding]
    public sealed class TaxamoHooks: BaseClass
    {
        

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}
