using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Mars.PagesMars;
using NUnit.Framework;


namespace Mars
{
    [Binding]
    public class MarsprojectfeatureStepDefinitions
    {
        public IWebDriver driver = new ChromeDriver();
        MarsHomePage homeObj = new MarsHomePage();
        MarsLoginpage loginObj = new MarsLoginpage();
        MarsProfile profileObj = new MarsProfile();

        [Given(@"\[Logged into the home page successfully ]")]
        public void GivenLoggedIntoTheHomePageSuccessfully()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000");
            loginObj.MarsLogin(driver);
            
        }

        [Given(@"\[I navigate to Profile tab]")]
        public void GivenINavigateToProfileTab()
        {
            //Locating the Profile Tab

            homeObj.GoToProfile(driver);
            
        }

        [When(@"\[I will add new profile details]")]
        public void WhenIWillAddNewProfileDetails()
        {
            //Adding New language details

            profileObj.AddNewLanguage(driver);

            //Adding New skill details

            profileObj.AddNewSkill(driver);

            //Adding New Education Details

            profileObj.AddNewEducation(driver);
        }

        [Then(@"\[Seller is able to see the seller's details on the Profile page]")]
        public void ThenSellerIsAbleToSeeTheSellersDetailsOnTheProfilePage()
        {
            //Gets langauge details

            string newLanguage = profileObj.getLanguage(driver);
            string newlangLevel = profileObj.getLangaugeLevel(driver);
            
            //Gets  skill details
            string newSkill = profileObj.GetNewSkill(driver);
            string newskillLevel = profileObj.GetNewSkillLevel(driver);

            //Gets  Education details

            string educCountry = profileObj.getCountry(driver);
            string educUniversity = profileObj.getUniversity(driver);
            string educTitle = profileObj.getTitle(driver);
            string educDegree = profileObj.getDegree(driver);
            string educYear = profileObj.getYear(driver);

            //Assertion For Language
            Assert.That(newLanguage == "Malayalam", "Actual language and expected language do not match");
            Assert.That(newlangLevel == "Fluent", "Actual level and expected level do not match");

            //Assertion For Skill
            Assert.That(newSkill == "Painting", "Actual skill and expected skill do not match");
            Assert.That(newskillLevel == "Beginner", "Actual skill level and expected skill level do not match");

            //Assertion For Education
            Assert.That(educCountry == "Australia", "Actual country and expected country do not match");
            Assert.That(educUniversity == "UQ", "Actual University and expected University do not match");
            Assert.That(educTitle == "M.Tech", "Actual title and expected title do not match");
            Assert.That(educDegree == "Computer", "Actual degree and expected degree do not match");
            Assert.That(educYear == "2010", "Actual year and expected year do not match");

        }

        //[Given(@"\[Logged into the home page successfully]")]
        //public void GivenLoggedIntoTheHomePageSuccessfully()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"\[I upadte the profile details]")]
        //public void WhenIUpadteTheProfileDetails()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"\[The profile should have an updated detaials]")]
        //public void ThenTheProfileShouldHaveAnUpdatedDetaials()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"\[I delete the profile details]")]
        //public void WhenIDeleteTheProfileDetails()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"\[The profile should be deleted successfully]")]
        //public void ThenTheProfileShouldBeDeletedSuccessfully()
        //{
        //    throw new PendingStepException();
        //}
    }
}
