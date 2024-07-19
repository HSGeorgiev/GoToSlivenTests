using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToSlivenEnE2e.Pages;

public class HomePageClass : BaseElementsClass
{
    public HomePageClass(IWebDriver driver) : base(driver)
    {
    }

    public void GoToHomePage()
    {
        driver.Navigate().GoToUrl(baseUrl);
    }






}
