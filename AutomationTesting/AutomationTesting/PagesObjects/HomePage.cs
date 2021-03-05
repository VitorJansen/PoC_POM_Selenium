using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTesting.PagesObjects
{
    class HomePage
    {
        protected static IWebDriver _driver;

        private By _btnSkipLogin = By.Id("btn2");

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SkipLogin()
        {
            _driver.FindElement(_btnSkipLogin).Click();
        }
        
    }
}
