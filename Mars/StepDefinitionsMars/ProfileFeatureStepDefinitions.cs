using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using Mars.PagesMars;
using NUnit.Framework;
#nullable disable


namespace Mars
{
    [Binding]
    public class ProfileFeatureStepDefinitions
    {
        IWebDriver driver;
        MarsProfile marsprofile = new MarsProfile();

        //LogIn

        [Given(@"\[I am logged in successfully]")]
        public void GivenIAmLoggedInSuccessfully()
        {
            driver = new ChromeDriver();
            new MarsLoginpage().MarsLogin(driver);
        }

        //Adding Language Details

        [When(@"\[I add language details]")]
        public void WhenIAddProfileDetails()
        {
            marsprofile.LocateLanguageTab(driver);
            marsprofile.AddNewLanguage(driver);
        }

        //Saving Language Details

        [Then(@"\[Language Details should be saved]")]
        public void ThenProfileDetailsShouldBeAddedSuccessfully()
        {
            var language = marsprofile.getLanguage(driver);
            var languageLevel = marsprofile.getLangaugeLevel(driver);

            Assert.That(language == "English", "Language doesn't match");
            Assert.That(languageLevel == "Basic", "Language level doesn't match");

            driver.Quit();
        }

        //Adding Skill Details

        [When(@"\[I add Skill details]")]
        public void WhenIAddSkillDetails()
        {
            marsprofile.LocateSkillTab(driver);
            marsprofile.AddNewSkill(driver);
        }

        //Saving Skill Details

        [Then(@"\[Skill Details should be saved]")]
        public void ThenSkillDetailsShuoldBeSaved()
        {
            var skill = marsprofile.GetNewSkill(driver);
            var skillLevel = marsprofile.GetNewSkillLevel(driver);

            Assert.That(skill == "Painting", "Skills Do not match");
            Assert.That(skillLevel == "Beginner", "Skill level doesn't match");

            driver.Quit();
        }

        //Adding Education Details

        [When(@"\[I add education details]")]
        public void WhenIAddEducationDetails()
        {
            marsprofile.LocateEducationTab(driver);
            marsprofile.AddNewEducation(driver);
        }

        //Saving Education Details

        [Then(@"\[Education Details should be saved]")]
        public void ThenEducationDetailsShouldBeSaved()
        {
            var eduCountry = marsprofile.getCountry(driver);
            var educUniversity = marsprofile.getUniversity(driver);
            var educTitle = marsprofile.getTitle(driver);
            var educDegree = marsprofile.getDegree(driver);
            var educYear = marsprofile.getYear(driver);

            Assert.That(eduCountry == "Australia", "Country doesn't match");
            Assert.That(educUniversity == "UQ", "University doesn't match");
            Assert.That(educTitle == "M.Tech", "Title doesn't match");
            Assert.That(educDegree == "Computer", "Degree doesn't match");
            Assert.That(educYear == "2010", "Year doesn't match");

            driver.Quit();

        }

        //Adding Certification Details

        [When(@"\[I add certification details]")]
        public void WhenIAddCertificationDetails()
        {
            marsprofile.LocateCertificationTab(driver);
            marsprofile.AddNewCertification(driver);
        }


        //Saving Certification Details

        [Then(@"\[Certification Details should be saved]")]
        public void ThenCertificationDetailsShouldBeSaved()
        {
            var certificateName = marsprofile.getCertificate(driver);
            var certificationFrom = marsprofile.getCertificateFrom(driver);
            var certificationYear = marsprofile.getCertificationYear(driver);

            Assert.That(certificateName == "ISTQB", "Certification doesn't match");
            Assert.That(certificationFrom == "ITB", "Certification from doesn't match");
            Assert.That(certificationYear == "2010", "Certification year doesn't match");

            driver.Quit();
        }


        //Adding Availability, Hours and EarnTarget details

        [When(@"\[I add Availability,Hours and EarnTarget details]")]
        public void WhenIAddAvailabilityHoursAndEarnTargetDetails()
        {
            marsprofile.AvailabilityHoursTarget(driver);
        }


        //Updating Availability, Hours, and EarnTarget

        [Then(@"\[All details should be saved]")]
        public void ThenAllDetailsShouldBeSaved()
        {
            var newAvailability = marsprofile.GetNewAvailability(driver);
            var newHours = marsprofile.GetNewHours(driver);
            var newEarnTarget = marsprofile.GetNewEarnTarget(driver);

            //Assertion
            Assert.That(newAvailability == "Part Time", "Availability doesn't match");
            Assert.That(newHours == "More than 30hours a week", "Hours doesn't match");
            Assert.That(newEarnTarget == "Between $500 and $1000 per month", "EarnTarget doesn't match");

            driver.Quit();
        }
    }
}
