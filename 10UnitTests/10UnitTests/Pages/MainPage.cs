using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
namespace _10UnitTests
{
    class MainPage
    {
        private const string URL = "http://avia.321.by/";
        private IWebDriver driver;

        #region Flight mode
        [FindsBy(How = How.XPath, Using = "//*[@id=\"page\"]/div[1]/div/div/div[1]/div[1]/ul/li[3]/div/ins")]
        private IWebElement complexFlight;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div/div[1]/div[1]/ul/li[2]/div/ins")]
        private IWebElement bothSides;
        #endregion

        #region Passengers
        [FindsBy(How = How.XPath, Using = "//*[@id=\"page\"]/div[1]/div/div/div[1]/div[2]/form/div[2]/div/div[2]/div[1]/div[1]/input")]
        private IWebElement passengerButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page\"]/div[1]/div/div/div[1]/div[2]/form/div[2]/div/div[2]/div[1]/div[2]/div/dl/dd[1]/ul/li[3]/span")]
        private IWebElement passengerAdult;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page\"]/div[1]/div/div/div[1]/div[2]/form/div[2]/div/div[2]/div[1]/div[2]/div/dl/dd[2]/ul/li[3]/span")]
        private IWebElement passengerChild;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page\"]/div[1]/div/div/div[1]/div[2]/form/div[2]/div/div[2]/div[1]/div[2]/div/dl/dd[3]/ul/li[3]/span")]
        private IWebElement passengerBaby;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page\"]/div[1]/div/div/div[1]/div[2]/form/div[2]/div/div[2]/div[1]/div[2]/div/dl/dd[3]/ul/li[2]/input")]
        private IWebElement countBaby;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page\"]/div[1]/div/div/div[1]/div[2]/form/div[2]/div/div[2]/div[1]/div[2]/div/dl/dd[1]/ul/li[2]/input")]
        private IWebElement countAdult;
        #endregion

        #region Cities
        [FindsBy(How = How.Id, Using = "from_name")]
        private IWebElement departureName_first;

      
        [FindsBy(How = How.Id, Using = "from_name1")]
        private IWebElement departureName_second;

        [FindsBy(How = How.Id, Using = "to_name")]
        private IWebElement destinationName_first;

        [FindsBy(How = How.Id, Using = "to_name1")]
        private IWebElement destinationName_second;
        #endregion

        #region Dates
        [FindsBy(How = How.Id, Using = "departure_date")]
        private IWebElement departureDate_first;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div[1]/table/tbody/tr[6]/td[1]/a")]
        private IWebElement calendar_datefirst;

        //for comlex flight mode
        [FindsBy(How = How.Id, Using = "departure_date1")]
        private IWebElement departureDate_second;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div[2]/table/tbody/tr[5]/td[4]/a")]
        private IWebElement calendar_datesecond;

        //for both sides flight mode
        [FindsBy(How = How.Id, Using = "departure_date_1")]
        private IWebElement departureDateForBothSides;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div[1]/table/tbody/tr[5]/td[7]/a")]
        private IWebElement dpartureDate_seocnd_30;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div[1]/table/tbody/tr[1]/td[6]/span")]
        private IWebElement departureDateInThePast;
        #endregion

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/p")]
        private IWebElement SearchError;

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
        }

        public void SelectComplexFlight()
        {

            complexFlight.Click();
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
          //  departureName_first.SendKeys(OpenQA.Selenium.Keys.Enter);
            destinationName_first.SendKeys(destination);
          //  destinationName_first.SendKeys(OpenQA.Selenium.Keys.Enter);
        }

        public void InsertSecondTrip(string departure, string destination)
        {
            departureName_second.Clear();
            destinationName_second.Clear();
            departureName_second.SendKeys(departure);
       //     departureName_second.SendKeys(OpenQA.Selenium.Keys.Enter);
            destinationName_second.SendKeys(destination);
        //    destinationName_second.SendKeys(OpenQA.Selenium.Keys.Enter);
        }



        public void ChooseFirstTripDate()
        {
            System.Threading.Thread.Sleep(1000);
            departureDate_first.Click();
            System.Threading.Thread.Sleep(1000);
            calendar_datefirst.Click();
        }

        public void ChooseSecondTripDate()
        {
            System.Threading.Thread.Sleep(1000);
            departureDate_second.Click();
            System.Threading.Thread.Sleep(1000);
            calendar_datesecond.Click();
        }
        
        public void ClickPassengersMenu()
        {
            passengerButton.Click();
        }
        public void SelectPassengerAdult()
        {
         //   System.Threading.Thread.Sleep(1000);
            passengerAdult.Click();
        }

        public void SelectPassengerChild()
        {
          //  System.Threading.Thread.Sleep(1000);
            passengerChild.Click();
        }

        public void SelectPassengerBaby()
        {
            System.Threading.Thread.Sleep(1000);
            passengerBaby.Click();
        }
           
        public string getCountBaby()
        {
            string count = countBaby.GetAttribute("value");
            return count;
        }

        public void SelectBothSides()
        {
            bothSides.Click();
        }

        public string getCountAdult()
        {
            string count = countAdult.GetAttribute("value");
            return count;
        }

       public bool SelectDatesForBothSides()
        {
            departureDate_first.Click();
            calendar_datefirst.Click();
            departureDateForBothSides.Click();
            try
            {
                dpartureDate_seocnd_30.Click();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool SelectDateInThePast()
        {
            departureDate_first.Click();
            try
            {
                departureDateInThePast.Click();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public string GetFirstCity()
        {
            return departureName_first.GetAttribute("value");
        }

        public string GetSecondCity()
        {
            return destinationName_first.GetAttribute("value");
        }
        public string GetErrorMessage()
        {
            return SearchError.Text.ToString();
        }
    }
}
