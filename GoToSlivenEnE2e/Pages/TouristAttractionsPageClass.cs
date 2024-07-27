using GoToSlivenEnE2e.Globals;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToSlivenEnE2e.Pages
{
    internal class TouristAttractionsPageClass : BasePageClass
    {
        public TouristAttractionsPageClass(IWebDriver driver) : base(driver)
        {
        }

        private readonly string subUrl = "/tourist-attractions/";

        public void GoToAttractionsPage()
        {
            driver.Navigate().GoToUrl(GlobalConstants.BASE_URL + subUrl);
        }


    }
}
