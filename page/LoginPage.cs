using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.page
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {

            //hit the URL
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            //// maximize the browser
            driver.Manage().Window.Maximize();
            // identify username and enter username value
            driver.FindElement(By.Id("UserName")).SendKeys("hari");
            // identify password and enter password
            driver.FindElement(By.Id("Password")).SendKeys("123123");
            // identify login button and click
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();
            // verify if the home page is displayed as expected
            if (driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text == "Hello hari!")
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }

    }
}
