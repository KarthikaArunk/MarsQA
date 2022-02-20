using OpenQA.Selenium;

namespace Mars.PagesMars
{
    public class AvailabilityHoursEarnTarget
    {
        IWebDriver driver;

       public AvailabilityHoursEarnTarget(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        private IWebElement AvailabilityIcon => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        private IWebElement AvailabilityDropdownBox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
        private IWebElement AvailabilityOptionSelect => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]"));
        private IWebElement HoursIcon => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private IWebElement HoursDropdownBox => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
        private IWebElement HoursOptionSelect => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[3]"));
        private IWebElement EarnTargetIcon => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        private IWebElement EarnTargetDropdown => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
        private IWebElement EarnTargetOptionSelect => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[3]"));
        private IWebElement GetNewAvailability => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
        private IWebElement GetNewHours => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
        private IWebElement GetNewEarnTarget => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));

        public void AvailabilityHoursTarget()
        {
            Thread.Sleep(5000);
            AvailabilityIcon.Click();
            AvailabilityDropdownBox.Click();
            AvailabilityOptionSelect.Click();
            HoursIcon.Click();
            HoursDropdownBox.Click();
            HoursOptionSelect.Click();
            EarnTargetIcon.Click();
            EarnTargetDropdown.Click();
            EarnTargetOptionSelect.Click();
        }

        //Gets New Availability
        public string getNewAvailability()
        {
            Thread.Sleep(2000);
            return GetNewAvailability.Text;
        }
        //Gets New Hours
        public string getNewHours()
        {
            Thread.Sleep(2000);
            return GetNewHours.Text;
        }

        //Gets New EarnTarget
        public string getNewEarnTarget()
        {
            Thread.Sleep(2000);
            return GetNewEarnTarget.Text;
        }
    }
}
