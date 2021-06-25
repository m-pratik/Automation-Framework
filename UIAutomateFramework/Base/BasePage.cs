using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIAutomateFramework.Base
{
   public abstract class BasePage
    {
       

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

    }
}
