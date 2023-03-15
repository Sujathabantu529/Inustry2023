using Industry2023.pages;
using Industry2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Industry2023.tests
{
    [TestFixture]
    public class TM_Tasts : CommonDriver
    {
       

        [SetUp]
        public void LoginSteps()
        {
         driver =   new ChromeDriver();
            //Login page object initialization and definition 
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginActions(driver);

            //Homepage object initilization and definition 
            HomePage homepageobj = new HomePage();
            homepageobj.GoToTMPage(driver);
        }
        [Test,Order(1), Description("Check if user is able to create Time record with valid data")]
        public void CreateTMTast()
        {
            //TMPage object initilization and definition
            TMPage tmpageobj = new TMPage();
            tmpageobj.CreateTM(driver);
        }
        [Test,Order(2), Description("Check if user is able Edit Time record with valid data")]
        public void EditTMTast()
        {
            //TM page object initialization and definition
            TMPage tmpageobj = new TMPage();
            //Edit TM 
            //tmpageobj.EditTM(driver);
        }
        [Test,Order(3), Description("Check if user is able to Delete Time record with valid data")]
        public void DeleteTMTast()
        {
            // Tmpage object initialization and definition
            TMPage tmpageobj = new TMPage();
            // Delete 
            tmpageobj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }

}
