using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industry2023.wait
{
  public class Wait
    {
        public static void WaitToBeClickable(IWebDriver driver, string locatortype, string locatorvalue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (locatortype == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }
            if(locatortype == "Id")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));
            }
        if(locatortype == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));
            }
        }
    }
}
