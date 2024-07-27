using GoToSlivenEnE2e.Globals;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToSlivenEnE2e.Pages
{
    internal class EventsPageClass : BasePageClass
    {
        public EventsPageClass(IWebDriver driver) : base(driver)
        {
        }

        private readonly string subUrl = "/event-directory/";

        public void GoToEventsPage()
        {
            driver.Navigate().GoToUrl(GlobalConstants.BASE_URL + subUrl);
        }

    }
}
