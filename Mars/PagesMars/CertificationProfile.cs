using OpenQA.Selenium;

namespace Mars.PagesMars
{
    public class CertificationProfile
    {
        IWebDriver driver;
        public CertificationProfile(IWebDriver webDriver)
            {
               driver = webDriver;
            }
        private IWebElement CertificationTab => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        private IWebElement CertifAddNewBtn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private IWebElement CertificateName => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
        private IWebElement CertificateFrom => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
        private IWebElement CertificationYear => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
        private IWebElement AddCertificButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
        private IWebElement GetCertiname => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
        private IWebElement GetCertifrom => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
        private IWebElement GetCertiYear => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
        
        public void LocateCertificationTab()
        {
            Thread.Sleep(5000);
            CertificationTab.Click();
            //Thread.Sleep(2000);
        }

        public void AddNewCertification()
        {
            Thread.Sleep(3000);
            CertifAddNewBtn.Click();
            CertificateName.SendKeys("ISTQB");
            CertificateFrom.SendKeys("ITB");
            CertificationYear.SendKeys("2010");
            AddCertificButton.Click();
        }

        //Getting Certificate Name
       public string getCertificate()
        {
            Thread.Sleep(2000);
            return GetCertiname.Text;
            
        }

        //Getting Certificate From
        public string getCertificateFrom()
        {
            return GetCertifrom.Text;
        }

        //Getting Certificate Year
        public string getCertificationYear()
        {
            return GetCertiYear.Text;
        }          
    }
}
