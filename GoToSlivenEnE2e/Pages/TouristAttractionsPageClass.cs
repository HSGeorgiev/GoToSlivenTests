﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToSlivenEnE2e.Pages
{
    internal class TouristAttractionsPageClass : BaseElementsClass
    {
        public TouristAttractionsPageClass(IWebDriver driver) : base(driver)
        {
        }

        private readonly string subUrl = "/tourist-attractions/";

        public void GoToAttractionsPage()
        {
            driver.Navigate().GoToUrl(baseUrl + subUrl);
        }


    }
}
