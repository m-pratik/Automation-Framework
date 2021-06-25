using JS247Test.Object;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace JS247Test.Page
{
    internal class JSLoginPage: JSLoginObject
    {
        public JSLoginPage(IWebDriver driver) : base(driver)
        {
        }

       

        public void Login(string username, string password)
        {
            
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            btnLogin.Click();

        }

    }
}
