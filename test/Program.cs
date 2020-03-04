using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using project2.page;
using project2.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//types of anatations 
//[testfixture] 
//[setUp] it runs before test and i has common steps that test cases have. in this case, logon is common
//[test] it for test cases
//[tearDown] it runs after test cases. in our case close the drive
//[Parallelizable] is for running test cases parallel- TMTestSuits and CustomerTestSuits run parallel

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Define Driver
            //CommonDriver.driver = new ChromeDriver(@"C:\Users\krupa\Downloads\chromedriver_win32_sele\");

            ////Create page Object for LoginPage
            //LoginPage logobj = new LoginPage();
            //logobj.LoginSteps(CommonDriver.driver);

            ////page object for HomePage
            //HomePage homeobj = new HomePage();
            //homeobj.NavigateToTm(CommonDriver.driver);

            ////Create page Object for TMPage 
            //TMPage tmobj = new TMPage();
            //tmobj.AddTM(CommonDriver.driver);
            //tmobj.EditTM(CommonDriver.driver);
            //tmobj.DeleteTM(CommonDriver.driver);

            ////page object for navigatetocustomer home page
            //homeobj.NavigateToCustomer(CommonDriver.driver);

            ////Create page object for Customerpage
            //CustomerPage custobj = new CustomerPage();
            //custobj.AddCustomer(CommonDriver.driver);
            //custobj.EditCustomer(CommonDriver.driver);
            //custobj.DeleteCustomer(CommonDriver.driver);
        }
    }

    [TestFixture, Description("Time and Material test Cases are Add,Edit and Delet")]
    [Parallelizable]
    class TimeandMaterialTestSuite : CommonDriver
    {

        [Test]
        public void AddTMTest()
        {
            //page object for HomePage
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTm(driver);
            //Create page Object for TMPage 
            TMPage tmobj = new TMPage();
            //create new Add TM Test Case
            tmobj.AddTM(driver);

        }
        [Test]
        public void EditTMTest()
        {
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTm(driver);
            //Create page Object for TMPage 
            TMPage tmobj = new TMPage();
            //Edit TM Test Case
            tmobj.EditTM(driver);
        }
        [Test]
        public void DeleteTMTest()
        {
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTm(driver);
            //Create page Object for TMPage 
            TMPage tmobj = new TMPage();
            //Delete TM Test Case
            tmobj.DeleteTM(driver);
        }

    }
    [TestFixture, Description("Customer test Cases are Add,Edit and Delet")]
    [Parallelizable]
    class CustomerTestSuite : CommonDriver
    {

        [Test]
        public void AddCustomerTest()
        {
            //page object for HomePage
            HomePage homeobj = new HomePage();
            //navigate to CustomerPage
            homeobj.NavigateToCustomer(driver);
            //Create page object for CustomerPage
            CustomerPage custobj = new CustomerPage();
            //Create new Add Customer Test Case
            custobj.AddCustomer(driver);
        }
        [Test]
        public void EditCustomerTest()
        {
            //page object for HomePage
            HomePage homeobj = new HomePage();
            //navigate to CustomerPage
            homeobj.NavigateToCustomer(driver);
            //Create page object for CustomerPage
            CustomerPage custobj = new CustomerPage();
            //Create new Add Customer Test Case
            custobj.EditCustomer(driver);
        }
        [Test]
        public void DeleteCustomerTest()
        {
            //page object for HomePage
            HomePage homeobj = new HomePage();
            //navigate to CustomerPage
            homeobj.NavigateToCustomer(driver);
            //Create page object for CustomerPage
            CustomerPage custobj = new CustomerPage();
            //Create new Add Customer Test Case
            custobj.DeleteCustomer(driver);

        }
    }
}


