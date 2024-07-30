using GoToSlivenEnE2e.Globals;
using GoToSlivenEnE2e.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace GoToSlivenEnE2e.Pages
{
    public class BasePageClass : DriverHelper
    {
        public BasePageClass(IWebDriver driver) : base(driver)
        {
        }




        // On the head of a base page

        // Locate the links in the main menu
        // Actually they are a number of li elements -> //ul[@id="menu-primary-eng"]//li

        private readonly By touristAttractionsLinkElement = By.XPath("//a[text()='Tourist Attractions']");
        private readonly By mapLinkElement = By.XPath("//a[text()='Map']");
        private readonly By eventsLinkElement = By.XPath("//a[text()='Events']");
        private readonly By accommodationLinkElement = By.XPath("//a[text()='Accommodation']");
        private readonly By hotelsLinkElement = By.XPath("//a[text()='Hotels']");
        private readonly By guestHousesLinkElement = By.XPath("//a[text()='Guest House']");
        private readonly By holodayHomesLinkElement = By.XPath("//a[text()='Holiday Homes']");
        private readonly By hutsLinkElement = By.XPath("//a[text()='Hut & Cabins']");
        private readonly By campingsLinkElement = By.XPath("//a[text()='Campings']");
        private readonly By restaurantsLinkElement = By.XPath("//a[text()='Restaurants']");
        private readonly By pizzeriasLinkElement = By.XPath("//a[text()='Pizzerias']");
        private readonly By fastfoodLinkElement = By.XPath("//a[text()='Fast Food Restaurants']");
        private readonly By usefullLinkElement = By.XPath("//a[text()='Useful']");

        // Or we can map them by parent element - li tag with id

        //private readonly By touristAttractionsLinkElement = By.XPath("//li[@id='menu-item-261']//a");
        //private readonly By mapLinkElement = By.XPath("//li[@id='menu-item-1216']//a");
        //private readonly By eventsLinkElement = By.XPath("//li[@id='menu-item-1963']//a");
        //private readonly By accommodationLinkElement = By.XPath("//li[@id='menu-item-3350']//a");
        //private readonly By hotelsLinkElement = By.XPath("//li[@id='menu-item-3347']//a");
        //private readonly By guestHousesLinkElement = By.XPath("//li[@id='menu-item-3360']//a");
        //private readonly By holodayHomesLinkElement = By.XPath("//li[@id='menu-item-3366']//a");
        //private readonly By hutsLinkElement = By.XPath("//li[@id='menu-item-3378']//a");
        //private readonly By campingsLinkElement = By.XPath("//li[@id='menu-item-3372']//a");
        //private readonly By restaurantsLinkElement = By.XPath("//li[@id='menu-item-3394']//a");
        //private readonly By pizzeriasLinkElement = By.XPath("//li[@id='menu-item-3442']//a");
        //private readonly By fastfoodLinkElement = By.XPath("//li[@id='menu-item-3526']//a");
        //private readonly By usefullLinkElement = By.XPath("//li[@id='menu-item-3199']//a");

        // Locate the logo of the site
        private readonly By logoElement =By.XPath("(//a[@href='https://gotosliven.com/']//img)[1]");

        // On the footer of a base page
        private readonly By privacyPolicyLinkElement = By.XPath("//span[text()='Privacy Policy']");
        private readonly By termsOfUseLinkElement = By.XPath("//span[text()='Terms of use']");

        // Check if main menu top-level items are displayed
        
        public void GoToUrl(string subUrl)
        {
            driver.Navigate().GoToUrl(GlobalConstants.BASE_URL + subUrl);
        }

        public bool IsLogoDisplayedOnPage()
        {
            return (FindElement(logoElement).Displayed);
        }
        
        public bool IsTopMenuDiplayed()
        {
            return (FindElement(touristAttractionsLinkElement).Displayed
                && FindElement(mapLinkElement).Displayed
                && FindElement(eventsLinkElement).Displayed
                && FindElement(accommodationLinkElement).Displayed
                && FindElement(restaurantsLinkElement).Displayed
                && FindElement(usefullLinkElement).Displayed);
        }

        // Check if footer links are displayed
        public bool IsFooterLinksDisplayed()
        {
            return (FindElement(privacyPolicyLinkElement).Displayed
                && FindElement(termsOfUseLinkElement).Displayed);
        }

        // Check if all main menu links work properly
        public bool AttractionsLinkIsProper()
        {
            Click(touristAttractionsLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("tourist-attractions") &&
                currentPageTitle.Contains("Tourist Attractions"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool MapLinkIsProper()
        {
            Click(mapLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("interactive-map-of-sliven") &&
                currentPageTitle.Contains("Interactive Map of Sliven"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EventsLinkIsProper()
        {
            Click(eventsLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("event-directory") &&
                currentPageTitle.Contains("Events"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AccommodationLinkIsProper()
        {
            Click(accommodationLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("accommodation") &&
                currentPageTitle.Contains("Accommodation"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HotelsLinkIsProper()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Accommodation']"))).Perform();
            Click(hotelsLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("hotels") &&
                currentPageTitle.Contains("Hotels"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GuestHousesLinkIsProper()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Accommodation']"))).Perform();
            Click(guestHousesLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("guest-house") &&
                currentPageTitle.Contains("Guest House"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HolodayHomesLinkIsProper()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Accommodation']"))).Perform();
            Click(holodayHomesLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("holiday-homes") &&
                currentPageTitle.Contains("Holiday Homes"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool HutsLinkIsProper()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Accommodation']"))).Perform();
            Click(hutsLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("hut-cabins") &&
                currentPageTitle.Contains("Hut & Cabins"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CampingsLinkIsProper()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Accommodation']"))).Perform();
            Click(campingsLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("campings") &&
                currentPageTitle.Contains("Campings"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RestaurantsLinkIsProper()
        {
            Click(restaurantsLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("restaurants") &&
                currentPageTitle.Contains("Restaurants"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PizzeriasLinkIsProper()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Restaurants']"))).Perform();
            Click(pizzeriasLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("pizzerias") &&
                currentPageTitle.Contains("Pizzerias"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FastFoodLinkIsProper()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Restaurants']"))).Perform();
            Click(fastfoodLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("fast-food-restaurants") &&
                currentPageTitle.Contains("Fast Food Restaurants"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UsefulLinkIsProper()
        {
            Click(usefullLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("useful") &&
                currentPageTitle.Contains("Useful"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TermsOfUseLinkIsProper()
        {
            // This link is # currently - has to be fixed
            Click(termsOfUseLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("#") &&
                currentPageTitle.Contains("gotosliven"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PrivacyPolicyLinkIsProper()
        {
            // This link is # currently - has to be fixed
            Click(privacyPolicyLinkElement);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("#") &&
                currentPageTitle.Contains("gotosliven"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetNextPageH2(By by)
        {
            Click(by);
            return GetText(By.XPath("(//h2)[1]"));
        }
    }
}
