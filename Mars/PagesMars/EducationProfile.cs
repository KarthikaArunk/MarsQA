
using OpenQA.Selenium;

namespace Mars.PagesMars
{
    public class EducationProfile
    {
        IWebDriver driver;
        public EducationProfile(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        private IWebElement EducationTab => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        private IWebElement AddNewEducationBtn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private IWebElement UniversityNameTxt => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        private IWebElement CountryDropBox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        private IWebElement TitleDropBox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private IWebElement DegreeTextBox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        private IWebElement YearDropBox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        private IWebElement AddEducButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        private IWebElement GetCountry => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
        private IWebElement GetUniversity => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
        private IWebElement GetTitle => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
        private IWebElement GetDegree => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
        private IWebElement GetYear => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));

        public void LocateEducationTab()
        {
            Thread.Sleep(4000);
            EducationTab.Click();
            //Thread.Sleep(1000);
        }

        public void AddNewEducation()
        {
            Thread.Sleep(2000);
            AddNewEducationBtn.Click();
            UniversityNameTxt.SendKeys("UQ");
            CountryDropBox.SendKeys("Australia");
            TitleDropBox.SendKeys("M.Tech");
            DegreeTextBox.SendKeys("Computer");
            YearDropBox.SendKeys("2010");
            AddEducButton.Click();
        }

       // Getting countryname
       public string getCountry()
        {
            Thread.Sleep(2000);
            return GetCountry.Text;
        }

        //Getting University
        public string getUniversity()
        {            
            return GetUniversity.Text;
        }

        //Getting Title
        public string getTitle()
        {
           return GetTitle.Text;
        }

        //Getting Degree
       public string getDegree()
       {
          return GetDegree.Text;
       }

        //Getting Year
       public string getYear()
       {
          return GetYear.Text;
       }   
    }
}
