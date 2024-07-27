using GoToSlivenEnE2e.Globals;
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
        options.AddArgument("--disable-search-engine-choice-screen");
        // Comment following to use normal browser
        //options.AddArgument("--headless");
        driver = new ChromeDriver(options);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(GlobalConstants.DEFAULT_TIMESPAN);
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

    


}
