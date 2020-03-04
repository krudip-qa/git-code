using OpenQA.Selenium;
using project2.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project2.page
{
    class TMPage
    {
        public void AddTM(IWebDriver driver)
        {
            //click on create new button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            //type in Code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("456");
            //type in description
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("testing");
            //click on save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            Thread.Sleep(1000);
            //goto last page and check the added item 
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(1000);
            Console.WriteLine(driver.FindElement(By.XPath(".//tbody/tr[last()]/td[1]")).Text);
            if (driver.FindElement(By.XPath(".//tbody/tr[last()]/td[1]")).Text == "456")
            {
                Console.WriteLine("Text match");
            }
            else
            {
                Console.WriteLine("Text desen't match");
            }
        }
        public void EditTM(IWebDriver driver)
        {
            Thread.Sleep(1000);
            //Edit Functionality
            //click on Edit button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();
            //remove the record from field
            driver.FindElement(By.XPath("//*[@id='Code']")).Clear();
            //give input to Code text 
           driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("4567");
            //click on save button 
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            Thread.Sleep(1000);
            //Goto last page and check the edited test correct or not
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            //only for checking that which text printing and check in if loop
            Console.WriteLine(driver.FindElement(By.XPath(".//tbody/tr[last()]/td[1]")).Text);
            if (driver.FindElement(By.XPath(".//tbody/tr[last()]/td[1]")).Text == "4567")
            {
                Console.WriteLine("Edited text matched");
            }
            else
            {
                Console.WriteLine("Edited Text desen't match");
            }

        }
        public void DeleteTM(IWebDriver driver)
        {//wait for page load 
            Thread.Sleep(1000);
            //Delete Functionality
            //Click on Delete button
            //Always find an active row record to delete
            driver.FindElement(By.XPath(".//tbody/tr[last()]/td[5]/a[2]")).Click();
            //click on ok button when pop-up a window
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            //check that row deleted sucessfully 
            Console.WriteLine("Delete function working");

        }
    }
   
}
      