using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Mars.PagesMars;
using NUnit.Framework;
using Mars.UtilitiesMars;


namespace Mars
{
    [Binding]
    public class MarsprojectfeatureStepDefinitions : DriverMars
    {
        //MarsHomePage homeObj = new MarsHomePage();
        MarsLoginpage loginObj = new MarsLoginpage();
        MarsProfile profileObj = new MarsProfile();

        
        [Given(@"\[I logged into the home page successfully ]")]
        public void GivenILoggedIntoTheHomePageSuccessfully()
         {
             driver = new ChromeDriver();
            
            //Login page object initialization and definition
            loginObj.MarsLogin(driver);
         }
        
             
        [When(@"\[I click on skill tab]")]
        public void WhenIClickOnSkillTab()
        {
            //Click On Skill Tab
            profileObj.LocateSkillTab(driver);
        }


        [Then(@"\[Skill details should be added successfully]")]
        public void ThenSkillDetailsShouldBeAddedSuccessfully()
        {
            //Adding Skill details
            profileObj.AddNewSkill(driver);
            driver.Quit();
        }

        [When(@"\[I click on language tab]")]
        public void WhenIClickOnLanguageTab()
        {
            //Click On Language Tab
            profileObj.LocateLanguageTab(driver);
        }

        [Then(@"\[Language details should be added successfully]")]
        public void ThenLanguageDetailsShouldBeAddedSuccessfully()
        {
            //Adding New language details
            profileObj.AddNewLanguage(driver);
            driver.Quit();
        }

        [When(@"\[I click on Education tab]")]
        public void WhenIClickOnEducationTab()
        {
            //Click On Education Tab 
            profileObj.LocateEducationTab(driver);
        }

        [Then(@"\[Education details should be added successfully]")]
        public void ThenEducationDetailsShouldBeAddedSuccessfully()
        {
            //Adding Education Details
            profileObj.AddNewEducation(driver);
            driver.Quit();
        }


        [When(@"\[I click on Certification tab]")]
        public void WhenIClickOnCertificationTab()
        {
            //Click On Certification Tab
            profileObj.LocateCertificationTab(driver);
        }

        [Then(@"\[Certification details should be added successfully]")]
        public void ThenCertificationDetailsShouldBeAddedSuccessfully()
        {

            //Adding Certification Details
            profileObj.AddNewCertification(driver);
            driver.Quit();
        }


       
        
       
        //Adding Availability, Hours and Earn Target

        //[When(@"\[I add Availability, Hours and Earn Target]")]
        //public void WhenIAddAvailabilityHoursAndEarnTarget()
        // {
        //    profileObj.AvailabilityHoursTarget(driver);
        // }

        ////Updating Availability,Hours and Earn Target

        //[Then(@"\[Availability,Hours and Earn Target should be added successfully]")]
        //public void ThenAvailabilityHoursAndEarnTargetShouldBeAddedSuccessfully()
        // {
        //    string newAvailability = profileObj.GetNewAvailability(driver);
        //    string newHours = profileObj.GetNewHours(driver);
        //    string newEarnTarget = profileObj.GetNewEarnTarget(driver);

        //    //Assertion
        //    Assert.That(newAvailability == "Part Time", "Actual Availability and expected Availability do not match");
        //    Assert.That(newHours == "More than 30hours a week", "Actual Hours and expected Hours do not match");
        //    Assert.That(newEarnTarget == "Between $500 and $1000 per month", "Actual EarnTarget and expected EarnTarget do not match");
        // }

        [When(@"\[I click on Language,Skill,Education and Certification Tabs]")]
        public void WhenIClickOnLanguageSkillEducationAndCertificationTabs()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            
            //Click On Skill Tab
            profileObj.LocateSkillTab(driver);

            //Click On Language Tab
            profileObj.LocateLanguageTab(driver);

            //Click On Education Tab 
            profileObj.LocateEducationTab(driver);

            //Click On Certification Tab
            profileObj.LocateCertificationTab(driver);

        }

        [Then(@"\[All profile details should be able to view]")]
        public void ThenAllProfileDetailsShouldBeAbleToView()
        {
            
            //Gets skill details
            string newSkill = profileObj.GetNewSkill(driver);
            string newskillLevel = profileObj.GetNewSkillLevel(driver);

            //Assertion For Skill
            Assert.That(newSkill == "Painting", "Actual skill and expected skill do not match");
            Assert.That(newskillLevel == "Beginner", "Actual skill level and expected skill level do not match");

            //Gets langauge details
            string newLanguage = profileObj.getLanguage(driver);
            string newlangLevel = profileObj.getLangaugeLevel(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            //Assertion For Language
            Assert.That(newLanguage == "English", "Actual language and expected language do not match");
            Assert.That(newlangLevel == "Basic", "Actual level and expected level do not match");

            //Gets Education details
            string educCountry = profileObj.getCountry(driver);
            string educUniversity = profileObj.getUniversity(driver);
            string educTitle = profileObj.getTitle(driver);
            string educDegree = profileObj.getDegree(driver);
            string educYear = profileObj.getYear(driver);

            //Assertion For Education
            Assert.That(educCountry == "Australia", "Actual country and expected country do not match");
            Assert.That(educUniversity == "UQ", "Actual University and expected University do not match");
            Assert.That(educTitle == "M.Tech", "Actual title and expected title do not match");
            Assert.That(educDegree == "Computer", "Actual degree and expected degree do not match");
            Assert.That(educYear == "2010", "Actual year and expected year do not match");

            //Gets Certification details
            string certificationName = profileObj.getCertificate(driver);
            string certificationFrom = profileObj.getCertificateFrom(driver);
            string certificationYear = profileObj.getCertificationYear(driver);

            //Assertion For Certification
            Assert.That(certificationName == "ISTQB", "Actual certification name and expected certification name do not match");
            Assert.That(certificationFrom == "ITB", "Actual certification from and expected certification from do not match");
            Assert.That(certificationYear == "2010", "Actual certification year and expected certification year do not match");

        }

    }
}
