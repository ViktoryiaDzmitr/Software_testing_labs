﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestWebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Browser;
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("http://avia.321.by/");

            IWebElement InputFrom = Browser.FindElement(By.Id("from_name"));
            InputFrom.Clear();
            InputFrom.SendKeys("Лондон");
            System.Threading.Thread.Sleep(1000);
            InputFrom.SendKeys(OpenQA.Selenium.Keys.Enter);

            IWebElement InputTo = Browser.FindElement(By.Id("to_name"));
            InputTo.SendKeys("Минск");
            System.Threading.Thread.Sleep(1000);
            InputTo.SendKeys(OpenQA.Selenium.Keys.Enter);

            IWebElement DepatrureDate_first = Browser.FindElement(By.Id("departure_date"));
            DepatrureDate_first.Click();
            IWebElement Calendar_datefirst = Browser.FindElement(By.ClassName("date_1541970000000"));
            System.Threading.Thread.Sleep(1000);
            Calendar_datefirst.Click();

            IWebElement DepatrureDate_second = Browser.FindElement(By.Id("departure_date_1"));
            DepatrureDate_second.Click();
            try
            {
                IWebElement Calendar_datesecond = Browser.FindElement(By.ClassName("date_1541710800000"));
                System.Threading.Thread.Sleep(1000);
                Calendar_datesecond.Click();
            }
            catch
            {
                Console.WriteLine("Second date is earlear then first. Input Error.");
            }
            IWebElement SearchButton = Browser.FindElement(By.ClassName("search_button"));
            SearchButton.Click();
        }
    }
}
