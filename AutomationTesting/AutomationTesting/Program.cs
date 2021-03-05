using AutomationTesting.Controllers;
using System;

namespace AutomationTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoSite demoSite = new DemoSite();
            demoSite.Start();
            
        }
    }
}
