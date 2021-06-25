using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxamoT.Helper;

namespace TaxamoT.TaxamoPages
{
    public class TaxamoSignUpPage:BaseClass
    {
        IWebElement SignUpPage = driver.FindElement(By.Id("taxamo_logo"));
        IWebElement FirstName = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div/div[3]/div/form/div/div[2]/div[1]/div/div[1]/input"));
        IWebElement LastName = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div/div[3]/div/form/div/div[2]/div[1]/div/div[2]/input"));
        IWebElement Email = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div/div[3]/div/form/div/div[2]/div[1]/div/div[3]/input"));
        IWebElement Company = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div/div[3]/div/form/div/div[2]/div[1]/div/div[4]/input"));
        IWebElement Checkbox = driver.FindElement(By.XPath("//*[@id='app']/div/div/div/div/div[3]/div/form/div/div[2]/div[1]/div/div[5]/label/input"));
        IWebElement SignUPCTA = driver.FindElement(By.CssSelector(".btn.btn-default.submit"));
        
        
        public void Aloginpage()
        {
            Assert.True(SignUpPage.Displayed, "is not displayed");
        }

        public void inputfirstname(string First)
        {
            FirstName.SendKeys(First);
        }

        public void inputlastname(string Last)
        {
            LastName.SendKeys(Last);
        }

        public void inputemail(string EMail)
        {
            Email.SendKeys(EMail);
        }

        public void inputcompany(string Comp)
        {
            Company.SendKeys(Comp);
        }

        public void clickbox()
        {
            Checkbox.Click();
        }

        public TaxamoVerificationPage  clicksignupbutton()
        {
            SignUPCTA.Click();

            return new TaxamoVerificationPage();
        }

        
    }
}
