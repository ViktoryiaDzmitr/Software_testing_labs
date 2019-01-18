using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace TestWebDriver
{
    [TestFixture]
    class Program
    {
        [Test]
        public void WhenSecondDateEarlierFirst()
        {

            bool passTest = false;
            bool isSelected = false;
            IWebDriver Browser;
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("http://avia.321.by/");

            IWebElement InputFrom = Browser.FindElement(By.Id("from_name"));
            InputFrom.Clear();
            InputFrom.SendKeys("Лондон");
            System.Threading.Thread.Sleep(1100);
            //   InputFrom.SendKeys(OpenQA.Selenium.Keys.Enter);

            IWebElement InputTo = Browser.FindElement(By.Id("to_name"));
            InputTo.SendKeys("Минск");
            System.Threading.Thread.Sleep(1000);
            InputTo.SendKeys(OpenQA.Selenium.Keys.Enter);

            IWebElement DepatrureDate_first = Browser.FindElement(By.Id("departure_date"));
            DepatrureDate_first.Click();
            IWebElement Calendar_datefirst = Browser.FindElement(By.ClassName("date_1548882000000"));
            System.Threading.Thread.Sleep(1000);
            Calendar_datefirst.Click();

            IWebElement DepatrureDate_second = Browser.FindElement(By.Id("departure_date_1"));
            DepatrureDate_second.Click();
            try
            {
                IWebElement Calendar_datesecond = Browser.FindElement(By.ClassName("date_1548795600000"));
                System.Threading.Thread.Sleep(1000);
                Calendar_datesecond.Click();
                isSelected = Calendar_datesecond.Selected;
            }
            catch
            {
                Console.WriteLine("Second date is earlear then first. Input Error.");
                passTest = true;
            }
            if (!isSelected)
                passTest = true;

            Assert.IsTrue(passTest);

        }

        public static void Main(string[] args)
        {
   
        }
    }
}
