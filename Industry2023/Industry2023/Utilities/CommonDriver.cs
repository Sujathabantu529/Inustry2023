using Industry2023.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industry2023.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        public void LoginSteps()
        {
            driver = new ChromeDriver();
            //Login page object initialization and definition 
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginActions(driver);
        }
   

    }
}
