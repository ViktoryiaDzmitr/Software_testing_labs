using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace FrameworkUnitTest
{
    [TestFixture]
    class Automation
    {
        private _10UnitTests.Steps steps = new _10UnitTests.Steps();
        private const string cityMinsk = "Минск";
        private const string cityMoscow = "Москва";
        private const string cityLondon = "Лондон";
        private const string cityTokio = "Токио";
        private bool status = false;
        private const double worstExchangeRate = 2.1020;
        private const double bestExchangeRate = 2.1220;

        private const string email = "example@mail.ru";
        private const string phone = "291231212";

        private const string adultFirstName = "Alex";
        private const string adultLastName = "Ivanova";
        private const string adultBDay = "21";
        private const string adultBMonth = "10";
        private const string adultBYear = "1990";
        private const string adultDoc = "QW123412";
        private const string adultExDay = "12";
        private const string adultExMonth = "12";
        private const string adultExYear = "2024";

        private const string babyFirstName = "Nastya";
        private const string babyLastName = "Ivanova";
        private const string babyBDay = "12";
        private const string babyBMonth = "11";
        private const string babyBYear = "1945";
        private const string babyDoc = "QW123412";
        private const string babyExDay = "25";
        private const string babyExMonth = "12";
        private const string babyExYear = "2024";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }
        // Test #1
        [Test]
        public void WhenDestinationEqualDeparture()
        {
            steps.SelectPage();
            steps.SelectComplexFlight();
            steps.SelectFirstTrip(cityMinsk, cityTokio);
            steps.SelectFirstTripDate();
            steps.SelectSecondTrip(cityLondon, cityMoscow);
            steps.SelectSecondTripDate();
            status = steps.StartSearchTickets();
            NUnit.Framework.Assert.AreEqual(true, status);
        }

        //Test #2
        [Test]
        public void WhenSecondFlightEarlierThenFirst()
        {
            steps.SelectPage();
            steps.SelectBothFlightTrip();
            steps.SelectFirstTrip(cityMinsk, cityMoscow);
            status = steps.SelectDatesForBothSides();

            //if set the date for second flight is impossible 
            NUnit.Framework.Assert.AreEqual(false, status);
        }

        //Test #3
        [Test]
        public void WhenBabyMoreThenAdult()
        {
            steps.SelectPage();
            steps.SelectOneSideFlight();
            steps.SelectFirstTrip(cityMinsk, cityTokio);
            status = steps.SelectPassengers();
            //if count of adults more or equal count if babies
            NUnit.Framework.Assert.AreEqual(true, status);
        }
        //Test #4
        [Test]
        public void CheckSortOfSearchResult()
        {
            steps.SelectPage();
            steps.SelectOneSideFlight();
            steps.SelectFirstTrip(cityLondon, cityTokio);
            steps.SelectFirstTripDate();
            status = steps.StartSearchTickets();
            System.Threading.Thread.Sleep(15000);
            steps.SelectSortByTime();
            System.Threading.Thread.Sleep(15000);
            status = steps.CheckSortByTime();

            NUnit.Framework.Assert.AreEqual(status, true);
        }

        //Test #5
        [Test]
        public void WhenBabyWithoutAnyAdult()
        {
            steps.SelectPage();
            steps.SelectOneSideFlight();
            steps.SelectFirstTrip(cityMinsk, cityMoscow);
            status = steps.SelectPassengersWithoutAdults();
            //if count of babies equal count of adults
            NUnit.Framework.Assert.AreEqual(false, status);
        }

        //Test #6
        [Test]
        public void WhenFlightDateYesterday()
        {
            steps.SelectPage();
            steps.SelectFirstTrip(cityMinsk, cityMoscow);             
            status = steps.SelectDepartureDateInThePast();
            status = steps.StartSearchTickets();
            NUnit.Framework.Assert.AreEqual(true, status);
        }

        //Test #7
        [Test]
        public void DistinationEqualOrigin()
        {
            steps.SelectPage();
            steps.SelectFirstTrip(cityMoscow, cityMoscow);
            status = steps.CheckEqualNames();
            steps.StartSearchTickets();
            NUnit.Framework.Assert.AreEqual(true, status);
        }

        //Test #8
        [Test]
        public void CheckConvertation()
        {
            steps.SelectPage();
            steps.SelectFirstTrip(cityMinsk, cityMoscow);
            steps.SelectFirstTripDate();
            status = steps.StartSearchTickets();
           // System.Threading.Thread.Sleep(10000);
            status = steps.CheckConvertation(bestExchangeRate, worstExchangeRate);
            NUnit.Framework.Assert.AreEqual(true, status);
        }

        //Test #9
        [Test]
        public void WhenBabyOlderThenAdult()
        {
            steps.SelectPage();
            steps.SelectOneSideFlight();
            steps.SelectFirstTrip(cityLondon, cityTokio);
            steps.SelectFirstTripDate();
            steps.PlusPassenerBaby();

            status = steps.StartSearchTickets();
            steps.SelectTicket();
            steps.InsertInfoIntoProfile(email, phone);
            steps.InsertNameAdult(adultFirstName, adultLastName);
            steps.InsertBDAdult(adultBDay, adultBMonth, adultBYear);
        //    steps.insertDocAdult(adultDoc, adultExDay, adultExMonth, adultExYear);
            steps.InsertNameBaby(babyFirstName, babyLastName);
            steps.InsertBDBaby(babyBDay, babyBMonth, babyBYear);
         //   steps.insertDocBaby(babyDoc, babyExDay, babyExMonth, babyExYear);
            status = steps.SubmitTicket();
            status = steps.ReturnBAbyAgeError();
            NUnit.Framework.Assert.AreEqual(true, status);
        }

        //Test #10
        [Test]
        public void WhenPassageersMoreThenSits()
        {
            steps.SelectPage();
            steps.SelectFirstTrip(cityMinsk, cityMoscow);
            status = steps.SelectMorePassengers();
            NUnit.Framework.Assert.AreEqual(false, status);
        }

    }

}
