using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project2.page
{
    class CustomerPage
    {
     
        public void AddCustomer(IWebDriver driver)
        {
            //click on a Create new Customer
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            //enter text into nameTextfield
            driver.FindElement(By.XPath("//*[@id='Name']")).SendKeys("Karl");
            //click on Edit Button
            driver.FindElement(By.XPath("//*[@id='EditContactButton']")).Click();
            //pop up window
            //to handle pop up need to swich on iframe first, 
            //so i have written xpath for frame
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='contactDetailWindow']/iframe")));
            //provide first name into FirstName TextField
            driver.FindElement(By.XPath(" //*[@id='FirstName']")).SendKeys("Karl");
            //Provide Last name into Last name TextFiels
            driver.FindElement(By.XPath(" //*[@id='LastName']")).SendKeys("parl");
            //provide phone numer into phone TextField 
            driver.FindElement(By.XPath(" //*[@id='Phone']")).SendKeys("0123456");
            //click on Save Contact button
            driver.FindElement(By.XPath(" //input[@value='Save Contact']")).Click();
            //the frame is finished, we swiching on browser from iframe
            driver.SwitchTo().DefaultContent();
            //click on check box 
            driver.FindElement(By.XPath("//*[@id='IsSameContact']")).Click();
            //provide GST into textField
            driver.FindElement(By.XPath("//*[@id='GST']")).SendKeys("012");
            //click on Save Button 
            driver.FindElement(By.XPath("//input[@value='Save']")).Click();
            
            //check the added item showing into table or not!
            //navigate to customer page Again
            //click on Administration
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            //click on customer 
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();

            //click on go to last pagination
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(".//*[@title='Go to the last page']/span")).Click();
            //check the last text with valid data
            Thread.Sleep(1000);
            Console.WriteLine(driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[2]")).Text);
            if (driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[2]")).Text == "Karl")
            {
                Console.WriteLine("Added new customer match");
            }
            else
            {
                Console.WriteLine("Add customer dosen't matched");
            }
        }

        public void EditCustomer(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //go to last page og pagination
            driver.FindElement(By.XPath("//*[@title='Go to the last page']")).Click();
            Thread.Sleep(1000);
            //click on Edit button
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[last()]/a[1]")).Click();
            //handle pop up - Navigate to frame
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='detailWindow']/iframe")));
            //clear TextField
            driver.FindElement(By.XPath("//*[@id='Name']")).Clear();
            //enter name into TextField
            driver.FindElement(By.XPath("//*[@id='Name']")).SendKeys("karma");
            //Click on Save button
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();
            //come out from pop up
            driver.SwitchTo().DefaultContent();
            //need to refresh the browser to update the edited item
            driver.Navigate().Refresh();
            Thread.Sleep(2000);
            //go to last page og pagination
            driver.FindElement(By.XPath("//*[@title='Go to the last page']")).Click();
            Thread.Sleep(1000);
            //checking that what ptinted as a text 
           // Console.WriteLine(driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[2]")).Text);

            //checked Edited Item chanded or not!
            if (driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[2]")).Text == "karma")
            {
                Console.WriteLine("Edited customer match");
            }
            else
            {
                Console.WriteLine("Edited customer dosen't matched");
            }
        }
        public void DeleteCustomer(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //go to last page og pagination
            driver.FindElement(By.XPath("//*[@title='Go to the last page']")).Click();
            Thread.Sleep(2000);
            //click on Delete button
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[4]/a[2]")).Click();
            //click on ok button when pop-up a window
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            // check that row deleted or not?
            Console.WriteLine("row Deleted");
            Thread.Sleep(1000);
            string rowCount = driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[4]/span[2]")).Text;
            Console.WriteLine(rowCount);
                     
         }

    }
}