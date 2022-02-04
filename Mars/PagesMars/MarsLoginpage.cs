using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Mars
{
  public class MarsLoginpage
    {
        //public IWebDriver driver = new ChromeDriver();
        public void MarsLogin(IWebDriver driver)   
        {
            //open chrome browser
            driver.Manage().Window.Maximize();

            //Launch MarsQA portal
            driver.Navigate().GoToUrl("http://localhost:5000");
            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signInButton.Click();
            Thread.Sleep(2000);
            
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("karthika9@gmail.com");
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("P@ssword");
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
        }
    }
}
