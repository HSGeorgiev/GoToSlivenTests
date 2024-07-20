using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V125.CSS;
using System.Collections.ObjectModel;

namespace GoToSlivenEnE2e.Pages;

public class HomePageClass : BaseElementsClass
{
    public HomePageClass(IWebDriver driver) : base(driver)
    {
    }

    // Buttons
    private readonly By exploreMoreButton = By.CssSelector(".elementor-button-text");
    private readonly By eventsButton = By.XPath("//a[text()='Events']");
    private readonly By readMoreButton = By.XPath("//span[text()='read more']");
    // H2 headings
    private readonly By welcomeSubHeading = By.XPath("(//h2)[1]");
    private readonly By touristCenterSubHeaging = By.XPath("(//h2)[2]");
    private readonly By exploreSubHeaging = By.XPath("(//h2)[3]");
    private readonly By eventsSubHeaging = By.XPath("(//h2)[4]");
    private readonly By exploreOnTheMapSubHeaging = By.XPath("(//h2)[5]");
    private readonly By blogArticleSubHeaging = By.XPath("(//h2)[7]");
    // H6 headings
    private readonly By aboutUsH6Heading = By.XPath("(//h6)[1]");
    private readonly By destanationSlivenH6Heading = By.XPath("(//h6)[2]");
    private readonly By whyChooseUsH6Heading = By.XPath("(//h6)[3]");
    private readonly By newsH6Heading = By.XPath("(//h6)[4]");

    public void GoToHomePage()
    {
        driver.Navigate().GoToUrl(baseUrl);
    }

    public void ClickExploreMoreButton()
    {
        Click(exploreMoreButton);
    }

    public bool EventsButtonWorksProper()
    {
        Click(eventsButton);
        string currentUrl = driver.Url;
        string currentPageTitle = driver.Title;
        if (currentUrl.Contains("event-directory") && currentPageTitle.Contains("Events"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ExploreMoreButtonWorksProper()
    {
        Click(exploreMoreButton);
        string currentUrl = driver.Url;
        string currentPageTitle = driver.Title;
        if (currentUrl.Contains("tourist-attractions") && currentPageTitle.Contains("Tourist Attractions"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ReadMoreButtonWorksProper()
    {
        Click(readMoreButton);
        string currentUrl = driver.Url;
        string currentPageTitle = driver.Title;
        if (currentUrl.Contains("about-us") && currentPageTitle.Contains("About us"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool WelcomeSubHeadingIsProper()
    {
        string currentElementText = GetText(welcomeSubHeading);
        if (currentElementText == "Welcome To Sliven")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool TouristCentereSubHeadingIsProper()
    {
        string currentElementText = GetText(touristCenterSubHeaging);
        if (currentElementText == "Tourist Cultural- Information Center")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ExploreSubHeadingIsProper()
    {
        string currentElementText = GetText(exploreSubHeaging);
        if (currentElementText == "Explore")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool EventsSubHeadingIsProper()
    {
        string currentElementText = GetText(eventsSubHeaging);
        if (currentElementText == "Events")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ExploreOnTheMapsSubHeadingIsProper()
    {
        // This method doesn't work properly if headless browser options is used!
        // Either do not use headless browser or do not execute this method in the tests
        string currentElementText = GetText(exploreOnTheMapSubHeaging);
        if (currentElementText == "Explore On The Map")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool BlogArticleSubHeadingIsProper()
    {
        string currentElementText = GetText(blogArticleSubHeaging);

        if (currentElementText == "Blog & Article")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool AboutUsH6SubHeadingIsProper()
    {
        string currentElementText = GetText(aboutUsH6Heading);

        if (currentElementText == "ABOUT US")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool DestanationSlivenH6SubHeadingIsProper()
    {
        string currentElementText = GetText(destanationSlivenH6Heading);

        if (currentElementText == "DESTINATION SLIVEN")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool WhyChooseUsH6SubHeadingIsProper()
    {
        string currentElementText = GetText(whyChooseUsH6Heading);

        if (currentElementText == "WHY CHOOSE US")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool NewsUsH6SubHeadingIsProper()
    {
        string currentElementText = GetText(newsH6Heading);

        if (currentElementText == "NEWS")
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}
