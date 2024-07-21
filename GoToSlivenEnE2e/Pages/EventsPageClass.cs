using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToSlivenEnE2e.Pages
{
    internal class EventsPageClass : BaseElementsClass
    {
        public EventsPageClass(IWebDriver driver) : base(driver)
        {
        }

        private readonly string subUrl = "/event-directory/";

        public void GoToEventsPage()
        {
            driver.Navigate().GoToUrl(baseUrl + subUrl);
        }

    }
}
