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
    class ResultPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/strong[18]")]
        private IWebElement CostBYN;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/strong[2]")]
        private IWebElement CostUSD;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/div[1]/div[1]/ul/li[3]/label")]
        private IWebElement USDCostMode;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/div/div[1]/div[4]/ul/li[3]/a")]
        private IWebElement sortByTime;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/div[2]/div[2]/div[1]/section[3]/div[1]/ul/li/label/span/span/ul[3]/li[1]/strong")]
        private IWebElement firstFlightTime;


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/div[2]/div[2]/div[1]/section[4]/div[1]/ul/li/label/span/span/ul[3]/li[1]/strong")]
        private IWebElement secondFlightTime;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/div[2]/div[2]/div[1]/section[5]/div[1]/ul/li[1]/label/span/span/ul[3]/li[1]/strong")]
        private IWebElement thirdFlightTime;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div/div[2]/div[2]/div[1]/section[1]/div[2]/div[2]/input")]
        private IWebElement SelectTicket;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        public string getCostBYN()
        {
          return CostBYN.Text.ToString();
        }

        public string getCostUSD()
        {
            return CostUSD.Text.ToString();
        }

        public void SelectUSD()
        {
            USDCostMode.Click();
        }
        public void StartSort()
        {
            sortByTime.Click();
        }

        public string getFirstTime()
        {
            return firstFlightTime.Text.ToString();
        }

        public string getSecondTime()
        {
            return secondFlightTime.Text.ToString();
        }

        public string getThirdTime()
        {
            return thirdFlightTime.Text.ToString();
        }

        public void ClickTicket()
        {
            SelectTicket.Click();
        }

  
    }
}
