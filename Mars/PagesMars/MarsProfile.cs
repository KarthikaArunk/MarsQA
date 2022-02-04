using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mars.PagesMars
{
    public class MarsProfile
    {
        public void AddNewLanguage(IWebDriver driver)
        {

            //Locate Language Tab and click on it

            //Thread.Sleep(3000);
            IWebElement languageTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageTab.Click();
            Thread.Sleep(2000);

            //Locate Add New button and click on it
            Thread.Sleep(3000);
            IWebElement addNewLanguageButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguageButton.Click();
            Thread.Sleep(3000);

            //Locate Language textbox

            IWebElement languageTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languageTextBox.SendKeys("Malayalam");
            Thread.Sleep(3000);

            //Locate dropdown textbox
            IWebElement languageLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevel.SendKeys("Fluent");

            //Click on Add button

            IWebElement addlanguageButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addlanguageButton.Click();

        }

        public string getLanguage(IWebDriver driver)
        {
            IWebElement language = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return language.Text;
        }

        public string getLangaugeLevel(IWebDriver driver)
        {
            IWebElement langLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return langLevel.Text;
        }

        public void AddNewSkill(IWebDriver driver)
        {
            //Locate Skill tab
            Thread.Sleep(3000);
            IWebElement skillTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();
            Thread.Sleep(3000);
            //WaitMars.WaitToBeClickable(driver, "XPath", "//*[@id='listing - management - section']/section[1]/div/a[2]", 2);

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
        }
        //Getting new skill
        public string GetNewSkill(IWebDriver driver)
        {
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newSkill.Text;
        }

        public string GetNewSkillLevel(IWebDriver driver)
        {
            IWebElement newSkillLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return newSkillLevel.Text;
        }

        public void AddNewEducation(IWebDriver driver)
        {
            //Locate Education Tab
            Thread.Sleep(3000);
            IWebElement educationTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();

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

        }
           public string getCountry(IWebDriver driver)
           {
            IWebElement getCountry = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return getCountry.Text;
           }
          
           public string getUniversity(IWebDriver driver)
           {
            IWebElement getUniversity = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return getUniversity.Text;
           }
           
           public string getTitle(IWebDriver driver)
          {
            IWebElement getTitle = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return getTitle.Text;
          }

           public string getDegree(IWebDriver driver)
           {
            IWebElement getDegree = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return getDegree.Text;
            }
           public string getYear(IWebDriver driver)
           {
            IWebElement getYear = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return getYear.Text;
           }
       }
}
