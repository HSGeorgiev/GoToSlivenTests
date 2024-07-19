using OpenQA.Selenium;

namespace GoToSlivenEnE2e.Pages
{
    internal class BaseElementsClass : BaseClass
    {
        public BaseElementsClass(IWebDriver driver) : base(driver)
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
        private readonly By guestHouseLinkElement = By.XPath("//a[text()='Guest House']");
        private readonly By holodayHomesLinkElement = By.XPath("//a[text()='Holiday Homes']");
        private readonly By hutsHomesLinkElement = By.XPath("//a[text()='Hut & Cabins']");
        private readonly By campingsLinkElement = By.XPath("//a[text()='Campings']");
        private readonly By restaurantsLinkElement = By.XPath("//a[text()='Restaurants']");
        private readonly By pizzeriasLinkElement = By.XPath("//a[text()='Pizzerias']");
        private readonly By fastfoodLinkElement = By.XPath("//a[text()='Fast Food Restaurants']");
        private readonly By usefullLinkElement = By.XPath("//a[text()='Useful']");

        // Locate the logo of the site
        private readonly By logoElement =By.XPath("//a[@href='https://gotosliven.com']//img");

        // On the footer of a base page

    }
}
