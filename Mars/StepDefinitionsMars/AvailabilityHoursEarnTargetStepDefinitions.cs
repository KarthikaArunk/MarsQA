using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Mars.PagesMars
{
    [Binding]
    public class AvailabilityHoursEarnTargetStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        AvailabilityHoursEarnTarget earntarget;

        [Given(@"\[Logged In ]")]
        public void GivenLoggedIn()
        {
            var lpage = new MarsLoginpage(driver);
            lpage.MarsLogin();
        }

        [When(@"\[Adding Availability,Hours and EarnTarget]")]
        public void WhenAddingAvailabilityHoursAndEarnTarget()
        {
            earntarget = new AvailabilityHoursEarnTarget(driver);
            earntarget.AvailabilityHoursTarget();
        }

        [Then(@"\[Availability,Hours and EarnTarget saved successfully]")]
        public void ThenAvailabilityHoursAndEarnTargetSavedSuccessfully()
        {
            var newAvailability = earntarget.getNewAvailability();
            var newHours = earntarget.getNewHours();
            var newEarnTarget = earntarget.getNewEarnTarget();

            //Assertion
            Assert.That(newAvailability == "Part Time", "Availability doesn't match");
            Assert.That(newHours == "More than 30hours a week", "Hours doesn't match");
            Assert.That(newEarnTarget == "Between $500 and $1000 per month", "EarnTarget doesn't match");

            driver.Quit();
        }
    }
}
