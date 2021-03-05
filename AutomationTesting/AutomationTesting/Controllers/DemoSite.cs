using AutomationTesting.PagesObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTesting.Controllers
{   

    class DemoSite
    {
        IWebDriver _driver;
        public string _url = "http://demo.automationtesting.in/Index.html";
        public HomePage _homePage;

        public DemoSite()
        {
            _driver = new ChromeDriver();
            _homePage = new HomePage(_driver);
        }

        public void Start()
        {
            _driver.Navigate().GoToUrl(_url);
            _homePage.SkipLogin();
        }
    }
}
