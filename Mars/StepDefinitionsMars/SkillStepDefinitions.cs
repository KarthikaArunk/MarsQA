using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Mars.PagesMars
{
    [Binding]
    public class SkillStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        SkillProfile skill;
                
        [Given(@"\[Logged in successfully]")]
        public void GivenLoggedInSuccessfully()
        {
            var lpage = new MarsLoginpage(driver);
            lpage.MarsLogin();
        }

        [When(@"\[I click on Skill Tab]")]
        public void WhenIClickOnSkillTab()
        {
            skill = new SkillProfile(driver);
            skill.LocateSkillTab();
            skill.AddNewSkill();
        }

        [Then(@"\[Skill should be saved successfully]")]
        public void ThenSkillShouldBeSavedSuccessfully()
        {
           
            var skillname =skill.GetNewSkill();
            var skillLevel = skill.GetNewSkillLevel();

            Assert.That(skillname == "Painting", "Skills Do not match");
            Assert.That(skillLevel == "Beginner", "Skill level doesn't match");

            driver.Quit();
        }
    }
}
