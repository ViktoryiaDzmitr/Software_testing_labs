using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace LabPageFactory
{
    class ClassPageFactory
    {
        public ClassPageFactory()
        {
            PageFactory.InitElements(Program.browser, this);
        }

        [FindsBy(How = How.Id, Using = "from_name")]
        public IWebElement Place_from;

        [FindsBy(How = How.Id, Using = "to_name")]
        public IWebElement Place_to;

        [FindsBy(How = How.Id, Using = "departure_date")]
        public IWebElement DepartureDate_first;

        [FindsBy(How = How.ClassName, Using = "date_1548882000000")]
        public IWebElement Calendar_datefirst;

        [FindsBy(How = How.Id, Using = "departure_date_")]
        public IWebElement DepartureDate_second;

        [FindsBy(How = How.ClassName, Using = "date_1548795600000")]
        public IWebElement Calendar_datesecond;

        [FindsBy(How = How.ClassName, Using = "search_button")]
        public IWebElement SearchButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[1]")]
        public IWebElement WarningWindow;
    }
}
