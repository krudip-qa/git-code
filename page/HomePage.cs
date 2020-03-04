using OpenQA.Selenium;
using project2.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.page
{
    class HomePage
    {
        public void NavigateToTm(IWebDriver driver)
        {  //Create new Time and material 
            //click on Administration
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            //click on time and material 
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

        }

        public void NavigateToCustomer(IWebDriver driver)
        {
            //Create new Customer 
            //Click on Administation 
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            //Click on Customer 
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();

        }
    }
}
