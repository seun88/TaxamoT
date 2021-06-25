using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxamoT.Helper;
using TaxamoT.TaxamoPages;
using TechTalk.SpecFlow;

namespace TaxamoT.StepDefinition
{
    [Binding]
    public  class TaxamoStepDefinition
    {
        private TaxamoSignUpPage sp;
        private TaxamoVerificationPage vp;


        [Given(@"i navigate to Taxamo website")]
        public void GivenINavigateToTaxamoWebsite()
        {
            sp = BaseClass.NavigateToTaxamoWeb();
        }

        [Given(@"i am on the signup page")]
        public void GivenIAmOnTheSignupPage()
        {
            sp.Aloginpage();
        }

        [Given(@"input ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void GivenInput(string FirstName, string LastName, string Email, string Company)
        {
            sp.inputfirstname(FirstName);
            sp.inputlastname(LastName);
            sp.inputemail(Email);
            sp.inputcompany(Company);
        }

        [Given(@"click the checkbox")]
        public void GivenClickTheCheckbox()
        {
            sp.clickbox();
            
        }


        [When(@"i click signup cta button")]
        public void WhenIClickSignupCtaButton()
        {

            vp = sp.clicksignupbutton();
        }

        [Then(@"i am signed up")]
        public void ThenIAmSignedUp()
        {
           
        }






    }
}
