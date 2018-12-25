using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace _10UnitTests
{
    class PassengerProfile
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"email\"]")]
        private IWebElement Email;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"name\"]")]
        private IWebElement Name;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"phone_number_field\"]")]
        private IWebElement PhoneNumber;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/form/section/div/div[3]/div[3]/div[2]/div[3]/div/samp")]
        private IWebElement BabyAgeErrorMessage;

        #region Information about Adult
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/form/section/div/div[3]/div[2]/div[1]/div/ul/li[2]/div/ins")]
        private IWebElement AdultIdFemale;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"lastname_0\"]")]
        private IWebElement AdultLastName;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"firstname_0\"]")]
        private IWebElement AdultFirstName;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"birthday_day_0\"]")]
        private IWebElement AdultBDay;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"birthday_month_0\"]")]
        private IWebElement AdultBMonth;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"birthday_year_0\"]")]
        private IWebElement AdultBYear;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"docnum_0\"]")]
        private IWebElement AdultDocument;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"doc_expire_date_day_0\"]")]
        private IWebElement AdultExpireDay;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"doc_expire_date_month_0\"]")]
        private IWebElement AdultExpireMonth;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"doc_expire_date_year_0\"]")]
        private IWebElement AdultExpireYear;
        #endregion

        #region Information about Baby
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/form/section/div/div[3]/div[3]/div[1]/div/ul/li[2]/div/ins")]
        private IWebElement BabyIsFemale;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"lastname_1\"]")]
        private IWebElement BabyFirstName;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"firstname_1\"]")]
        private IWebElement BabyLastName;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"birthday_day_1\"]")]
        private IWebElement BabyBDay;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"birthday_month_1\"]")]
        private IWebElement BabyBMonth;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"birthday_year_1\"]")]
        private IWebElement BabyBYear;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"docnum_1\"]")]
        private IWebElement BabyDocument;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"doc_expire_date_day_1\"]")]
        private IWebElement BabyExpireDay;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"doc_expire_date_month_1\"]")]
        private IWebElement BabyExpireMonth;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"doc_expire_date_year_1\"]")]
        private IWebElement BabyExpireYear;
        #endregion

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/form/section/div/div[4]/div/input")]
        private IWebElement SubmitTicket;

        public PassengerProfile(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/main/div/form/section/div/div[4]/div/input")));
        }

        public void InsertNameAdult(string firstName, string lastName)
        {
            AdultFirstName.Clear();
            AdultLastName.Clear();
            AdultFirstName.SendKeys(firstName);
            AdultLastName.SendKeys(lastName);
            AdultIdFemale.Click();
        }

        public void InsertNameBaby(string firstName, string lastName)
        {
            BabyFirstName.Clear();
            BabyLastName.Clear();
            BabyFirstName.SendKeys(firstName);
            BabyLastName.SendKeys(lastName);
            BabyIsFemale.Click();
        }


        public void InsertBDAdult(string bDay, string bMonth, string bYear)
        {
            AdultBDay.Clear();
            AdultBMonth.Clear();
            AdultBYear.Clear();

            AdultBDay.SendKeys(bDay);
            AdultBMonth.SendKeys(bMonth);
            AdultBYear.SendKeys(bYear);
         
        }

        public void InsertBDBaby(string bDay, string bMonth, string bYear)
        {
            BabyBDay.Clear();
            BabyBMonth.Clear();
            BabyBYear.Clear();

            BabyBDay.SendKeys(bDay);
            BabyBMonth.SendKeys(bMonth);
            BabyBYear.SendKeys(bYear);

        }

        public void InsertDocBaby(string num, string exDay, string exMonth, string exYear)
        {
            System.Threading.Thread.Sleep(1000);
            BabyDocument.Clear();
            BabyExpireDay.Clear();
            BabyExpireMonth.Clear();
            BabyExpireYear.Clear();

            BabyDocument.SendKeys(num);
            BabyExpireDay.SendKeys(exDay);
            BabyExpireMonth.SendKeys(exMonth);
            BabyExpireYear.SendKeys(exYear);
        }

        public void InsertDocAdult(string num, string exDay, string exMonth, string exYear)
        {
            System.Threading.Thread.Sleep(1000);
            AdultDocument.Clear();
            AdultExpireDay.Clear();
            AdultExpireMonth.Clear();
            AdultExpireYear.Clear();

            AdultDocument.SendKeys(num);
            AdultExpireDay.SendKeys(exDay);
            AdultExpireMonth.SendKeys(exMonth);
            AdultExpireYear.SendKeys(exYear);
        }

        public void InsertInfo(string email, string phone)
        {
            Email.Clear();
            PhoneNumber.Clear();

            Email.SendKeys(email);
            PhoneNumber.SendKeys(phone);
        }

        public bool Submit()
        {
            SubmitTicket.Click();
            return true;
        }

        public void ScrollPage()
        {
            this.ScrollPage();
        }
        public bool CheckErrorMessage()
        {
            string message;
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/main/div/form/section/div/div[3]/div[3]/div[2]/div[3]/div/samp")));
            try
            {
            message = BabyAgeErrorMessage.Text;
            }
            catch
            {
                return false;
            }
            if (message.Length > 0)
                return true;
            else
                return false;
      
          
        }
    }
}
