using JS247Test.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace JS247Test.Test
{
    

    class JSLoginTest
    {
        IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://qa-jobsupports247.itsutra.com/");
        }

        [Test]

        public void VerifyLoginWithValidCredentials()
        {
            var loginpage = new JSLoginPage(Driver);
            loginpage.Login("mentoradmin", "Itsutra123@%");
            Assert.That(true, "Login Successs");
        }

    }
}
