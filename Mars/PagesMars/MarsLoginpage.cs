using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




namespace Mars.PagesMars
{
  public class MarsLoginpage
    {
        public void MarsLogin(IWebDriver driver)
         {
            //open chrome browser
            driver.Manage().Window.Maximize();

            //Launch MarsQA portal
            driver.Navigate().GoToUrl("http://localhost:5000");

            //Locate SignIn Button and Click on it
            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signInButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            //Identify Email textbox and enter valid eamil
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("karthika9@gmail.com");
            
            //Identify Password textbox and enter valid password
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("P@ssword");
            
            //Identify Login button and click on it
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
        }
    }
}
