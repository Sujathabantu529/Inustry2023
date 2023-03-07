using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industry2023.pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Create a new Time record

            // Navigate to Time and Material page
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
            Thread.Sleep(1000);

            // Click on Create New button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            Thread.Sleep(1000);

            // Select Time option from TypeCode dropdown list
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
            Thread.Sleep(1000);

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();


            // Input code into Code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("February2023");

            // Input description into Description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("February2023");

            // Input Price per Unit into price per unit textbox
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("12");

            // Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            // Check if new Time record has been created
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));


            if (newCode.Text == "February2023")
            {
                Console.WriteLine("New Time record created successful!");
            }
            else
            {
                Console.WriteLine("Record hasn't been created!");

            }
        }
        public void EditTM(IWebDriver driver)
        {
            // Click on edit button to edit record 
            IWebElement editbutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[5]/a[1]"));
            editbutton.Click();
            Thread.Sleep(5000);

            // Clear the code
            IWebElement codeedit = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codeedit.Clear();
            Thread.Sleep(5000);

            // input code into codetextbox 
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("sujatha1");
            Thread.Sleep(4000);

            // Click on Save button 
            IWebElement editsavebtn = driver.FindElement(By.Id("SaveButton"));
            editsavebtn.Click();
            Thread.Sleep(5000);

            // Go to lastpage edit record 
            IWebElement editlastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            editlastpage.Click();
            Thread.Sleep(6000);

            IWebElement Editedrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (Editedrecord.Text == "sujatha1")
            {
                Console.WriteLine("Record edited successfully");
            }
            else
            {
                Console.WriteLine("Record not edited");

            }
        }
        public void DeleteTM(IWebDriver driver)
        {
            //Click on Delete button 
            IWebElement deletebtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deletebtn.Click();
            Thread.Sleep(2000);

            // Click on OK button on popup box
            IAlert al = driver.SwitchTo().Alert();
            al.Accept();
            Thread.Sleep(2000);


            IWebElement deleterecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (deleterecord.Text == "sujatha1")
            {
                Console.WriteLine("Record has not been deleted successfully");
            }
            else
            {
                Console.WriteLine("Record is deleted successfully");
            }


            driver.Quit();
        }
    }
}
