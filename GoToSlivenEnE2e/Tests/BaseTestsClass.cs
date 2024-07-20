using GoToSlivenEnE2e.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoToSlivenEnE2e.Tests;

public class BaseTestsClass
{
    protected IWebDriver driver;
    ChromeOptions options = new ChromeOptions();

    [SetUp]
    public void Setup()
    {
        //some options of the WebDriver we should be able to change when needed
        options.AddArgument("--start-maximized");
        options.AddUserProfilePreference("profile.password_manager_enabled", false);
        // Comment folowing to use normal browser
        //options.AddArgument("--headless");
        driver = new ChromeDriver(options);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }

[TearDown]
    public void TearDown()
    {
        if (driver != null)
        {
            driver.Quit();
            driver.Dispose();
        }

    }

    public void TestMainMenuLinks()
    {
        HomePageClass homePage = new HomePageClass(driver);
        homePage.GoToHomePage();
        Assert.IsTrue(homePage.AttractionsLinkIsProper(),
            "'Tourist Attractions' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.MapLinkIsProper(),
            "'Maps' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.EventsLinkIsProper(),
            "'Events' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.AccommodationLinkIsProper(),
            "'Accommodation' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.HotelsLinkIsProper(),
            "'Hotels' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.GuestHousesLinkIsProper(),
            "'Guest Houses' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.HolodayHomesLinkIsProper(),
            "'Holoday Homes' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.HutsinkIsProper(),
            "'Huts & Cabins' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.CampingsLinkIsProper(),
            "'Campings' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.RestaurantsLinkIsProper(),
            "'Restaurants' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.PizzeriasLinkIsProper(),
            "'Pizzerias' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.FastFoodLinkIsProper(),
            "'Fast Food Restaurants' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.UsefulLinkIsProper(),
            "'Useful' link does not work properly");
    }

    public void TestFooterLinks()
    {
        HomePageClass homePage = new HomePageClass(driver);

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.PrivacyPolicyLinkIsProper(),
            "'Privacy Policy' link does not work properly");

        homePage.GoToHomePage();
        Assert.IsTrue(homePage.TermsOfUseLinkIsProper(),
            "'Terms Of Use' link does not work properly");

        
    }


}
