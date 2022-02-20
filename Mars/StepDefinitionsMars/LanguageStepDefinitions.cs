using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Mars.PagesMars
{
    [Binding]
    public class LanguageStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        LanguageProfile language;

        [Given(@"\[Logged In Successfully]")]
        public void GivenLoggedInSuccessfully()
        {
            var lpage = new MarsLoginpage(driver);
            lpage.MarsLogin();
        }

        [When(@"\[I add new Language]")]
        public void WhenIAddNewLanguage()
        {
            language = new LanguageProfile(driver);
            language.AddNewLanguage();
        }

        [Then(@"\[Language details saved successfully]")]
        public void ThenLanguageDetailsSavedSuccessfully()
        {
            var languagename = language.getLanguage();
            var languageLevel = language.getLangaugeLevel();

            Assert.That(languagename == "English", "Language doesn't match");
            Assert.That(languageLevel == "Basic", "Language level doesn't match");

            driver.Quit();
        }
    }
}
