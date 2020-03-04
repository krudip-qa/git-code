using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using project2.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//after moving [setUp] and [TearDown] to commonDriver we dont want every test case run to login ,teat and close
//it can be login once and run all 6 test case and close- Save time
//we are changin anatation from[SetUp]to[OneTimeSetUp]and [Tearown]to [OneTimeTearDown]

namespace project2.utilities
{
    class CommonDriver
    {
        public IWebDriver driver { set; get;}

        [OneTimeSetUp]
        public void StartUpSteps()
        {
            //Define Driver
            driver = new ChromeDriver(@"C:\Users\krupa\Downloads\chromedriver_win32_sele\");

            //Create page Object for LoginPage
            LoginPage logobj = new LoginPage();
            logobj.LoginSteps(driver);
        }
        [OneTimeTearDown]
        public void FinishTest()
        {
            driver.Close();
        }
    }
}
