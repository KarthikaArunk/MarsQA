using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Mars.PagesMars;
#nullable disable


namespace Mars.UtilitiesMars
{
    public class DriverMars
    {
        public IWebDriver driver;
        [SetUp]
        public void LoginFunction()
        {
            driver = new ChromeDriver();

            //Login page object initialization and definition
            MarsLoginpage loginObj = new MarsLoginpage();
            loginObj.MarsLogin(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
