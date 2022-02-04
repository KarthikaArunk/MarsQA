using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Mars.UtilitiesMars;

namespace Mars.PagesMars
{
   public class MarsHomePage
    {
        public void GoToProfile(IWebDriver driver)
        {

            //Thread.Sleep(2000);
            ////IWebElement tabdetails = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]"));
            ////tabdetails.Click();
            //driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]")).Click();



            //Locate ProfileTab
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//a[@href='/Account/Profile']")).Click();

            driver.FindElement(By.LinkText("Profile")).Click();

            //IWebElement profileTab = driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();
            //profileTab.Click();

            //WaitMars.WaitToBeClickable(driver, "XPath", "//*[@id='listing-management-section']/section[1]/div/a[2]", 2);


            
        }
    }
}
