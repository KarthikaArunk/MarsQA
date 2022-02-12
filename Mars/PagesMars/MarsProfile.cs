using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Mars.PagesMars
{
    public class MarsProfile
    {
        //Locate Skill Tab
        public void LocateSkillTab(IWebDriver driver)
        {
            //Locate Skill tab
           
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")));
            
            IWebElement skillTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        //Adding New Skill
        public void AddNewSkill(IWebDriver driver)
        {
            //Locate Add New Button in Skill tab and click on it
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //Locate Skill Textbox
            IWebElement skillTextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillTextbox.SendKeys("Painting");

            //Locate Skill Level
            IWebElement skillLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevel.SendKeys("Beginner");

            //Locate Add Button In Skill Tab
            IWebElement skillAddButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            skillAddButton.Click();

            var popup = driver.FindElement(By.XPath("/html/body/div[1]/a"));
            popup.Click();


        }

        //Getting new skill
        public string GetNewSkill(IWebDriver driver)
        {
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newSkill.Text;
        }

        //Getting new skill level
        public string GetNewSkillLevel(IWebDriver driver)
        {
            IWebElement newSkillLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return newSkillLevel.Text;
        }

        //Locate Language Tab 
        public void LocateLanguageTab(IWebDriver driver)
         {
            //Locate Language Tab and click on it
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")));

            IWebElement languageTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageTab.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
         }

         //Adding New Language
        public void AddNewLanguage(IWebDriver driver)
         {
            //Locate Add New button and click on it
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            IWebElement addNewLanguageButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguageButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")));

            //Locate Language textbox
            IWebElement languageTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languageTextBox.SendKeys("English");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            //Locate dropdown textbox
            IWebElement languageLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevel.SendKeys("Basic");

            //Click on Add button
            IWebElement addlanguageButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addlanguageButton.Click();

            var popup = driver.FindElement(By.XPath("/html/body/div[1]/a"));
            popup.Click();
        }

        //Getting new language
        public string getLanguage(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            IWebElement language = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return language.Text;
        }
        
        //Getting language level
        public string getLangaugeLevel(IWebDriver driver)
        {
            IWebElement langLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return langLevel.Text;
        }
        
        //Locate Education Tab                 
        public void LocateEducationTab(IWebDriver driver)
         {
            //Locate Education Tab
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")));
            IWebElement educationTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();
         }

        //Adding New Education

        public void AddNewEducation(IWebDriver driver)
         {
            //Locate Add New Button in Education Tab and Click on it
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();

            //Locate University Name TextBox
            IWebElement universityNameTxt = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            universityNameTxt.SendKeys("UQ");

            //Locate Country Dropdown Box
            IWebElement countryDropBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countryDropBox.SendKeys("Australia");

            //Locate Title Dropdown Box
            IWebElement titleDropBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropBox.SendKeys("M.Tech");

            //Locate Degree TextBox
            IWebElement degreeTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreeTextBox.SendKeys("Computer");

            //Locate Year Of Graduation Dropdown Box
            IWebElement yearDropBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearDropBox.SendKeys("2010");

            //Locate Add Button in Education Tab
            IWebElement addEducButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addEducButton.Click();

            var popup = driver.FindElement(By.XPath("/html/body/div[1]/a"));
            popup.Click();
        }

        //Getting countryname
        public string getCountry(IWebDriver driver)
         {
            IWebElement getCountry = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return getCountry.Text;
         }
          
        //Getting University
        public string getUniversity(IWebDriver driver)
         {
            IWebElement getUniversity = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return getUniversity.Text;
         }
          
        //Getting Title
        public string getTitle(IWebDriver driver)
         {
            IWebElement getTitle = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return getTitle.Text;
         }

        //Getting Degree
        public string getDegree(IWebDriver driver)
         {
            IWebElement getDegree = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return getDegree.Text;
         }
        
        //Getting Year
        public string getYear(IWebDriver driver)
         {
            IWebElement getYear = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return getYear.Text;
         }

        //Locate Certification Tab
        public void LocateCertificationTab(IWebDriver driver)
         {
            //Locate Certification Tab
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")));
            IWebElement certificationTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationTab.Click();
         }

        //Add New Certification
        public void AddNewCertification(IWebDriver driver)
         {
            
            //Locate Add New Button In Certification Tab
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();
           
            //Locate CertificationName TextBox
            IWebElement certificateName = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateName.SendKeys("ISTQB");

            //Locate CertificationFrom Textbox
            IWebElement certificateFrom = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certificateFrom.SendKeys("ITB");

            //Locate Certification Year
            IWebElement certificationYear = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            certificationYear.SendKeys("2010");

            //Locate Add Button In Certification Tab
            IWebElement addCertificButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addCertificButton.Click();

            var popup = driver.FindElement(By.XPath("/html/body/div[1]/a"));
            popup.Click();
        }

        //Getting Certificate Name
        public string getCertificate(IWebDriver driver)
         {
            IWebElement getCertiname = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return getCertiname.Text;
         }

        //Getting Certificate From
        public string getCertificateFrom(IWebDriver driver)
         {
            IWebElement getCertifrom = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return getCertifrom.Text;
         }

        //Getting Certificate Year
        public string getCertificationYear(IWebDriver driver)
         {
            IWebElement getCertiYear = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return getCertiYear.Text;
         }

        //Adding Availability,Hours and EarnTarget
        public void AvailabilityHoursTarget(IWebDriver driver)
         {
            //Identify Availability Icon
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement availabilityIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            availabilityIcon.Click();

            //Identify Availability dropdown box
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement availabilityDropdownBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            availabilityDropdownBox.Click();
               
            //Select availabilty option
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement availabilityOptionSelect = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]"));
            availabilityOptionSelect.Click();
            
            //Identify Hours Icon
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement hoursIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            hoursIcon.Click();

            //Identify Hours dropdown box
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement hoursDropdownBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
            hoursDropdownBox.Click();

            //Select Hours Option
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement hoursOptionSelect = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[3]"));
            hoursOptionSelect.Click();

            //Identify EarnTargetIcon
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement EarnTargetIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            EarnTargetIcon.Click();

            //Identify EarnTarget Dropdown box
            IWebElement earnTargetDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
            earnTargetDropdown.Click();

            //Select EarnTarget Option
            IWebElement earnTargetOptionSelect = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[3]"));
            earnTargetOptionSelect.Click();
         }

        //Gets New Availability
        public string GetNewAvailability(IWebDriver driver)
         {
            IWebElement getNewAvailability = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            return getNewAvailability.Text;
         }
        //Gets New Hours
        public string GetNewHours(IWebDriver driver)
         {
            IWebElement getNewHours = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
            return getNewHours.Text;
         }

        //Gets New EarnTarget
        public string GetNewEarnTarget(IWebDriver driver)
         {
            IWebElement getNewEarnTarget = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));
            return getNewEarnTarget.Text;
         }
    }
}
