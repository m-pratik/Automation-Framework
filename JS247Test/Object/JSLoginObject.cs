using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using UIAutomateFramework.Base;

namespace JS247Test.Object
{
    class JSLoginObject : BasePage
    {
        public JSLoginObject(IWebDriver driver): base(driver)
        {
        }


        protected IWebElement txtUserName => Driver.FindElement(By.Id("email"));

        protected IWebElement txtPassword => Driver.FindElement(By.Id("password"));

        protected IWebElement btnLogin => Driver.FindElement(By.CssSelector("div.css-mjid7s div.css-z7r9cu div.ant-row.css-9lvimv div.ant-col.css-1fqx0ur.ant-col-xs-23.ant-col-lg-10:nth-child(1) div.ant-col.css-1tgek5v div:nth-child(1) form.ant-form.ant-form-vertical.ant-form-hide-required-mark.ant-form-large.css-340ily:nth-child(4) div.ant-row.ant-row-center.ant-row-middle:nth-child(4) div.ant-col.ant-col-24 > button.ant-btn.ant-btn-primary.ant-btn-lg"));
    }
}
