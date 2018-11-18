using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Security.Policy;
using System.Threading;

namespace FrameworkUnitTest
{
    class MainPage
    {
        private const string URL = "http://avia.321.by/";
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using ="//*[@id=\"page\"]/div[1]/div/div/div[1]/div[1]/ul/li[3]/div/ins")]
        private IWebElement complexFlight;

        [FindsBy(How = How.Id, Using = "from_name")]
        private IWebElement departureName_first;

        [FindsBy(How = How.Id, Using = "from_name1")]
        private IWebElement departureName_second;

        [FindsBy(How = How.Id, Using = "to_name")]
        private IWebElement destinationName_first;

        [FindsBy(How = How.Id, Using = "to_name1")]
        private IWebElement destinationName_second;

        [FindsBy(How = How.Id, Using = "departure_date")]
        private IWebElement departureDate_first;

        [FindsBy(How = How.ClassName, Using = "date_1544821200000")]
        private IWebElement calendar_datefirst;

        [FindsBy(How = How.Id, Using = "departure_date1")]
        private IWebElement departureDate_second;

        [FindsBy(How = How.ClassName, Using = "date_1548190800000")]
        private IWebElement calendar_datesecond;

        [FindsBy(How = How.ClassName, Using = "search_button")]
        private IWebElement searchButton;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
            complexFlight.Click(); 
            System.Threading.Thread.Sleep(1000);
        }

        public void ClickOnSearchTickets()
        {
            searchButton.Click();
        }

        public void InsertFirstTrip(string departure, string destination)
        {
            departureName_first.Clear();
            destinationName_first.Clear();
            departureName_first.SendKeys(departure);
            System.Threading.Thread.Sleep(1000);
            departureName_first.SendKeys(OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(1000);
            destinationName_first.SendKeys(destination);
            System.Threading.Thread.Sleep(1000);
            destinationName_first.SendKeys(OpenQA.Selenium.Keys.Enter);
        }

        public void InsertSecondTrip(string departure, string destination)
        {
            departureName_second.Clear();
            destinationName_second.Clear();
            departureName_second.SendKeys(departure);
            System.Threading.Thread.Sleep(1000);
            departureName_second.SendKeys(OpenQA.Selenium.Keys.Enter);
            System.Threading.Thread.Sleep(1000);
            destinationName_second.SendKeys(destination);
            System.Threading.Thread.Sleep(1000);
            destinationName_second.SendKeys(OpenQA.Selenium.Keys.Enter);
        }

   

        public void ChooseFirstTripDate()
        {
            departureDate_first.Click();
            calendar_datefirst.Click();
        }

        public void ChooseSecondTripDate()
        {
            departureDate_second.Click();
            calendar_datesecond.Click();
        }
    }
}
