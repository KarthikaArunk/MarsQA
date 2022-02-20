using OpenQA.Selenium;

namespace Mars.PagesMars
{
    public class SkillProfile
    {
        IWebDriver driver;
        public SkillProfile(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        private IWebElement SkillTab => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private IWebElement SkillAddNewBtn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement SkillTxt => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private IWebElement SkillLevel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        private IWebElement SkillAddBtn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private IWebElement NewSkill => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
        private IWebElement NewSkillLevel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));

        public void LocateSkillTab()
        {
            Thread.Sleep(4000);
            SkillTab.Click();
            //Thread.Sleep(2000);
        }

        public void AddNewSkill()
        {
            Thread.Sleep(4000);
            SkillAddNewBtn.Click();
            SkillTxt.SendKeys("Painting");
            SkillLevel.SendKeys("Beginner");
            SkillAddBtn.Click();
        }

        //Getting new skill
        public string GetNewSkill()
        {
            Thread.Sleep(2000);
            return NewSkill.Text;
        }

        //Getting new skill level
        public string GetNewSkillLevel()
        {
            Thread.Sleep(2000);
            return NewSkillLevel.Text;
        }                
    }
}
