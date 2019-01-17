using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace LabPageFactory
{
    class Program
    {
        public static IWebDriver browser;

        static void Main(string[] args)
        {
            bool passTest = false;
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("http://avia.321.by/");
            ClassPageFactory pageObject = new ClassPageFactory();

            pageObject.Place_from.Clear();
            pageObject.Place_from.SendKeys("Минск");
            System.Threading.Thread.Sleep(1000);
            pageObject.Place_from.SendKeys(OpenQA.Selenium.Keys.Enter);

            pageObject.DepartureDate_first.Click();
            System.Threading.Thread.Sleep(1000);
            pageObject.Calendar_datefirst.Click();

            try
            {
                pageObject.Place_to.Clear();
                pageObject.Place_to.SendKeys("Минск");
                System.Threading.Thread.Sleep(1000);
                pageObject.Place_to.SendKeys(OpenQA.Selenium.Keys.Enter);

                pageObject.DepartureDate_second.Click();
                System.Threading.Thread.Sleep(1000);
                pageObject.Calendar_datesecond.Click();
            }
            catch 
			{
                passTest = true;
                Console.WriteLine("Input City Error.");
            }
            pageObject.SearchButton.Click();
            System.Threading.Thread.Sleep(5000);
            try
            {
                passTest = pageObject.WarningWindow.Displayed;
                Assert.AreEqual(true, passTest);
            }
            catch
            {
                Console.WriteLine("Test did't pass.");
            }
        }
    }
}
