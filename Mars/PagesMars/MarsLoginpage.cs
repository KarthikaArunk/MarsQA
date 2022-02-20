
using OpenQA.Selenium;


namespace Mars.PagesMars
{
    public class MarsLoginpage
    {
        IWebDriver driver;
        public MarsLoginpage(IWebDriver webDriver)
        {
            driver= webDriver;
        }
              
         
        private IWebElement SignInBtn => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));

        private IWebElement EmailTxt => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));

        private IWebElement PasswordTxt => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));

        private IWebElement LoginBtn => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

        public void MarsLogin()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000");
            SignInBtn.Click();

            EmailTxt.SendKeys("karthika9@gmail.com");

            PasswordTxt.SendKeys("P@ssword");
            
            LoginBtn.Click();
        }

    }

}