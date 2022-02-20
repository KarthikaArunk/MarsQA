using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Mars.PagesMars
{
    [Binding]
    public class CertificationStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        CertificationProfile cprofile;

        [Given(@"\[Logged in ]")]
        public void GivenLoggedIn()
        {
            var lpage = new MarsLoginpage(driver);
            lpage.MarsLogin();
        }

        [When(@"\[I click on Certification Tab]")]
        public void WhenIClickOnCertificationTab()
        {
            cprofile = new CertificationProfile(driver);
            cprofile.LocateCertificationTab();
            cprofile.AddNewCertification();
        }

        [Then(@"\[Certification should be saved successfully]")]
        public void ThenCertificationShouldBeSavedSuccessfully()
        {
            var certificateName = cprofile.getCertificate();
            var certificationFrom = cprofile.getCertificateFrom();
            var certificationYear = cprofile.getCertificationYear();

            Assert.That(certificateName == "ISTQB", "Certification doesn't match");
            Assert.That(certificationFrom == "ITB", "Certification from doesn't match");
            Assert.That(certificationYear == "2010", "Certification year doesn't match");
            driver.Quit();
        }
    }
}
