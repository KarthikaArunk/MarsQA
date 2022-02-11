using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Mars.PagesMars;
using Mars.UtilitiesMars;



namespace Mars
{
    [TestFixture]
    [Parallelizable]
    class MarsProfileTests:DriverMars
    {
        //MarsHomePage homeObj = new MarsHomePage();
        [Test, Order(1), Description("Check if seller is able to add new skill with valid data")]
        public void AddSkill_Test()
        {
            //MarsProfile object initialization and definition
            MarsProfile profileObj = new MarsProfile();
            profileObj.AddNewSkill(driver);
         }

        [Test, Order(2), Description("Check if seller is able to add a new language with valid data")]
        public void AddLanguage_Test()
         {
            // Mars Homepage object initialization and definition
            //homeObj.GoToProfile(driver);

            //MarsProfile object initialization and definition
            MarsProfile profileObj = new MarsProfile();
            profileObj.AddNewLanguage(driver);
         }

        

        [Test, Order(3), Description("Check if seller is able to add new education with valid data")]
        public void AddEducation_Test()
         {
            //MarsProfile object initialization and definition
            MarsProfile profileObj = new MarsProfile();
            profileObj.AddNewEducation(driver);
          }

        [Test, Order(4), Description("Check if seller is able to add new certification with valid data")]
        public void AddCertification_Test()
         {
            //MarsProfile object initialization and definition
            MarsProfile profileObj = new MarsProfile();
            profileObj.AddNewCertification(driver);
          }
    }
}
