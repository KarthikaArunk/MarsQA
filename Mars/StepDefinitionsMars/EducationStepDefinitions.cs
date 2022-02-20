using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Mars.PagesMars
{
    [Binding]
    public class EducationStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        EducationProfile edprofile;

        [Given(@"\[Logged in]")]
        public void GivenLoggedIn()
        {
            var lpage = new MarsLoginpage(driver);
            lpage.MarsLogin();
        }

        [When(@"\[I click on Education Tab]")]
        public void WhenIClickOnEducationTab()
        {
            edprofile = new EducationProfile(driver);
            edprofile.LocateEducationTab();
            edprofile.AddNewEducation();

        }

        [Then(@"\[Education should be saved successfully]")]
        public void ThenEducationShouldBeSavedSuccessfully()
        {
            

            var eduCountry = edprofile.getCountry();
            var educUniversity = edprofile.getUniversity();
            var educTitle = edprofile.getTitle();
            var educDegree = edprofile.getDegree();
            var educYear = edprofile.getYear();

            Assert.That(eduCountry == "Australia", "Country doesn't match");
            Assert.That(educUniversity == "UQ", "University doesn't match");
            Assert.That(educTitle == "M.Tech", "Title doesn't match");
            Assert.That(educDegree == "Computer", "Degree doesn't match");
            Assert.That(educYear == "2010", "Year doesn't match");

            driver.Quit();
        }
    }
}
