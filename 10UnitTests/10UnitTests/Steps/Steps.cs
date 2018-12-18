using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Security.Policy;
using System.Threading;

namespace _10UnitTests
{
    class Steps
    {
        IWebDriver driver;
        public void InitBrowser()
        {
            driver = _10UnitTests.Driver.GetInstance();
        }

        public void CloseBrowser()
        {
            _10UnitTests.Driver.CloseBrowser();
        }

        public bool SelectFirstTrip(string departureName, string destinationName)
        {
            _10UnitTests.MainPage mainPage = new _10UnitTests.MainPage(driver);
            mainPage.InsertFirstTrip(departureName, destinationName);
          
            return true;
        }

        public bool SelectFirstTripDate()
        {
            _10UnitTests.MainPage mainPage = new _10UnitTests.MainPage(driver);
            mainPage.ChooseFirstTripDate();
            return true;
        }

        public bool SelectSecondTrip(string departureName, string destinationName)
        {
            _10UnitTests.MainPage mainPage = new _10UnitTests.MainPage(driver);
            mainPage.InsertSecondTrip(destinationName, departureName);
          
            return true;
        }

        public bool SelectSecondTripDate()
        {
            _10UnitTests.MainPage mainPage = new _10UnitTests.MainPage(driver);
            mainPage.ChooseSecondTripDate();
            return true;
        }

        public bool StartSearchTickets()
        {
            _10UnitTests.MainPage mainPage = new _10UnitTests.MainPage(driver);
            try
            {
                mainPage.ClickOnSearchTickets();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void SelectPage()
        {
            _10UnitTests.MainPage selectPage = new _10UnitTests.MainPage(driver);
            selectPage.OpenPage();
          
        }

        public void SelectComplexFlight()
        {
            _10UnitTests.MainPage selectPage = new _10UnitTests.MainPage(driver);
            selectPage.SelectComplexFlight();

        }


        public void SelectBothFlightTrip()
        {
            _10UnitTests.MainPage selectPage = new _10UnitTests.MainPage(driver);
            selectPage.SelectBothSides();

        }

        public bool SelectDatesForBothSides()
        {
            _10UnitTests.MainPage selectPage = new _10UnitTests.MainPage(driver);
             return selectPage.SelectDatesForBothSides(); ;
        }

        public bool selectPassengers()
        {
            _10UnitTests.MainPage mainPage = new _10UnitTests.MainPage(driver);
            mainPage.ClickPassengersMenu();
            mainPage.SelectPassengerAdult();
            for(int i=0;i<2;i++)
            mainPage.SelectPassengerBaby();
            if (Int32.Parse(mainPage.getCountBaby()) <= Int32.Parse(mainPage.getCountAdult()))
            {
                return true;
            }
            else
            return false;
        }
        public bool selectPassengersWithoutAdults()
        {
            _10UnitTests.MainPage mainPage = new _10UnitTests.MainPage(driver);
            mainPage.ClickPassengersMenu();
            mainPage.SelectPassengerBaby();
            if (Int32.Parse(mainPage.getCountBaby()) > 0 && Int32.Parse(mainPage.getCountAdult()) == 0)
                return true;
            else return false;
        }

        public bool SelectDepartureDateInThePast()
        {
            _10UnitTests.MainPage selectPage = new _10UnitTests.MainPage(driver);
            return selectPage.SelectDateInThePast();
        }
        public bool CheckEqualNames()
        {
            _10UnitTests.MainPage selectPage = new _10UnitTests.MainPage(driver);
            if (selectPage.GetFirstCity() == selectPage.GetSecondCity())
                return true;
            else
                return false;
        }

        public bool SelectMorePassengers()
        {
            _10UnitTests.MainPage selectPage = new _10UnitTests.MainPage(driver);
            selectPage.ClickPassengersMenu();
            for(int i = 0; i< 10; i++)
            selectPage.SelectPassengerAdult();
            if (Int32.Parse(selectPage.getCountAdult()) >= 10)
                return true;
            else
                return false;
        }

        public bool CheckConvertation(double bestExchangeRate, double worstExchangeRate)
        {
    
            _10UnitTests.ResultPage selectPage = new _10UnitTests.ResultPage(driver);
            string costBYN = selectPage.getCostBYN().Trim(new char[] { 'B','Y','N' });
            selectPage.SelectUSD();
            string costUSD = selectPage.getCostUSD().Trim(new char[] { 'U', 'S', 'D' });
            double resultRate = Double.Parse(costBYN) / Double.Parse(costUSD);
            if (resultRate >= worstExchangeRate && resultRate <= bestExchangeRate)
                return true;
            else
                return false;

        }

        public bool CheckSortByTime()
        {
            _10UnitTests.ResultPage selectPage = new _10UnitTests.ResultPage(driver);

            string[] first = selectPage.getFirstTime().Split(new char[] { ' ' });
            string[] second = selectPage.getSecondTime().Split(new char[] { ' ' });
            string[] third = selectPage.getSecondTime().Split(new char[] { ' ' });
            double firstTimeMinutes = Double.Parse(first[0]) * 60 + Double.Parse(first[2]);
            double secondTimeMinutes = Double.Parse(second[0]) * 60 + Double.Parse(second[2]);
            double thirdTimeMinutes = Double.Parse(third[0]) * 60 + Double.Parse(third[2]);
            if (firstTimeMinutes <= secondTimeMinutes && secondTimeMinutes <= thirdTimeMinutes)
                return true;
            else
            return false;
        }
        public void SelectSortByTime()
        {
            _10UnitTests.ResultPage selectPage = new _10UnitTests.ResultPage(driver);
            selectPage.StartSort();
        }
        public void PlusPassenerBaby()
        {
            _10UnitTests.MainPage selectPage = new _10UnitTests.MainPage(driver);
            selectPage.ClickPassengersMenu();
            selectPage.SelectPassengerBaby();
        }
        public void SelectTicket()
        {
            _10UnitTests.ResultPage selectPage = new _10UnitTests.ResultPage(driver);
            selectPage.ClickTicket();
        }

        public void insertNameAdult(string firstName, string lastName)
        {
            _10UnitTests.PassengerProfile selectPage = new _10UnitTests.PassengerProfile(driver);
            selectPage.InsertNameAdult(firstName, lastName);
        }

        public void insertBDAdult(string bDay, string bMonth, string bYear)
        {
            _10UnitTests.PassengerProfile selectPage = new _10UnitTests.PassengerProfile(driver);
            selectPage.InsertBDAdult(bDay, bMonth, bYear);
        }

        public void insertDocAdult(string num, string exDay, string exMonth, string exYear)
        {
            _10UnitTests.PassengerProfile selectPage = new _10UnitTests.PassengerProfile(driver);
            selectPage.InsertDocAdult(num, exDay, exMonth, exYear);
        }

        public void insertNameBaby(string firstName, string lastName)
        {
            _10UnitTests.PassengerProfile selectPage = new _10UnitTests.PassengerProfile(driver);
            selectPage.InsertNameBaby(firstName, lastName);
        }

        public void insertBDBaby(string bDay, string bMonth, string bYear)
        {
            _10UnitTests.PassengerProfile selectPage = new _10UnitTests.PassengerProfile(driver);
            selectPage.InsertBDBaby(bDay, bMonth, bYear);
        }

        public void insertDocBaby(string num, string exDay, string exMonth, string exYear)
        {
            _10UnitTests.PassengerProfile selectPage = new _10UnitTests.PassengerProfile(driver);
            selectPage.InsertDocBaby(num, exDay, exMonth, exYear);
       }
        public bool submitTicket()
        {
            _10UnitTests.PassengerProfile selectPage = new _10UnitTests.PassengerProfile(driver);
            return selectPage.Submit();
        }

        public void ScrollProfilePAge()
        {
            _10UnitTests.PassengerProfile selectPage = new _10UnitTests.PassengerProfile(driver);
            selectPage.ScrollPage();
        }
        public void InsertInfoIntoProfile(string email, string phone)
        {
            _10UnitTests.PassengerProfile selectPage = new _10UnitTests.PassengerProfile(driver);
            selectPage.InsertInfo( email,  phone);
        }
        public bool ReturnBAbyAgeError()
        {
         _10UnitTests.PassengerProfile selectPage = new _10UnitTests.PassengerProfile(driver);
         return   selectPage.CheckErrorMessage();
        }
        public bool CheckErrorMessage()
        {
            _10UnitTests.MainPage selectPage = new _10UnitTests.MainPage(driver);
            string message;
            try
            {
                message = selectPage.GetErrorMessage();
            }
            catch
            {
                return true;
            }
            if (message.Length == 0)
                return true;
            else return false;
        }
    }
}
