
using OpenQA.Selenium;

namespace Mars.PagesMars
{
    public class LanguageProfile
    {
        IWebDriver driver;
        public LanguageProfile(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        private IWebElement LanguageTab => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private IWebElement AddNewLanguageBtn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement LanguageTxt => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        private IWebElement LanguageLevel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        private IWebElement AddLanguageBtn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private IWebElement NewLanguage => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
        private IWebElement NewLanguageLevel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));

        public void LocateLanguageTab()
        {
            Thread.Sleep(4000);
            LanguageTab.Click();           
        }

        public void AddNewLanguage()
        {
            Thread.Sleep(2000);
            AddNewLanguageBtn.Click();

            LanguageTxt.SendKeys("English");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            LanguageLevel.SendKeys("Basic");
            AddLanguageBtn.Click();

          }

        public string getLanguage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            return NewLanguage.Text;
        }
        public string getLangaugeLevel()
        {
            return NewLanguageLevel.Text;
        }               
    }
}
