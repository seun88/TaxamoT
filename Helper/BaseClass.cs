using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxamoT.TaxamoPages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TaxamoT.Helper
{
    public class BaseClass
    {
        public static IWebDriver driver { get; set; }

        static BaseClass()
        {
            driver = null;
        }

        public static void LaunchBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                new DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
                break;
                case "Firefox":
                new DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
                break;
            }

            driver.Manage().Window.Maximize();
        }

        private static  IWebDriver  initializeChrome()
        {
            driver = new ChromeDriver();
            return driver;
        }

        public static void CloseBrowser()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Close();
            driver.Quit();
        }

        public static void LaunchURL(string URL)
        {
            driver.Navigate().GoToUrl(URL);
            
        }

        public static TaxamoSignUpPage NavigateToTaxamoWeb()
        {
            LaunchURL("https://manage.taxamo.com/auth.html#signup");
            return new TaxamoSignUpPage();
        }
    }
}
