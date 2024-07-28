using GoToSlivenEnE2e.Globals;
using GoToSlivenEnE2e.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoToSlivenEnE2e.Tests;

public class BaseTestsClass
{
    protected IWebDriver driver;
    ChromeOptions options = new ChromeOptions();
    BasePageClass basePage;

    

    [SetUp]
    public void Setup()
    {
        //some options of the WebDriver we should be able to change when needed
        options.AddArgument("--start-maximized");
        options.AddUserProfilePreference("profile.password_manager_enabled", false);
        options.AddArgument("--disable-search-engine-choice-screen");
        // Comment following to use normal browser
        //options.AddArgument("--headless");
        driver = new ChromeDriver(options);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(GlobalConstants.DEFAULT_TIMESPAN);
        basePage = new BasePageClass(driver);
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

    public void IsTopMenuViivble(string subUrl)
    {
        var basePage = new BasePageClass(driver);
        basePage.GoToUrl(subUrl);

        Assert.That(basePage.IsTopMenuDiplayed(), Is.True, "Main menu is not visible");

    }

    public void TestMainMenuLinks(string subUrl)
    {
        var basePage = new BasePageClass(driver);
        
        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.AttractionsLinkIsProper(),
            "'Tourist Attractions' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.MapLinkIsProper(),
            "'Maps' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.EventsLinkIsProper(),
            "'Events' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.AccommodationLinkIsProper(),
            "'Accommodation' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.HotelsLinkIsProper(),
            "'Hotels' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.GuestHousesLinkIsProper(),
            "'Guest Houses' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.HolodayHomesLinkIsProper(),
            "'Holoday Homes' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.HutsLinkIsProper(),
            "'Huts & Cabins' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.CampingsLinkIsProper(),
            "'Campings' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.RestaurantsLinkIsProper(),
            "'Restaurants' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.PizzeriasLinkIsProper(),
            "'Pizzerias' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.FastFoodLinkIsProper(),
            "'Fast Food Restaurants' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.UsefulLinkIsProper(),
            "'Useful' link does not work properly");
    }

    public void IsFooterLinksViivble(string subUrl)
    {
        var basePage = new BasePageClass(driver);
        basePage.GoToUrl(subUrl);

        Assert.That(basePage.IsFooterLinksDisplayed(), Is.True, "Footer Links are not visible");

    }

    public void TestFooterLinks(string subUrl)
    {
        var basePage = new BasePageClass(driver);

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.PrivacyPolicyLinkIsProper(),
            "'Privacy Policy' link does not work properly");

        basePage.GoToUrl(subUrl);
        Assert.IsTrue(basePage.TermsOfUseLinkIsProper(),
            "'Terms Of Use' link does not work properly");
    }
}
