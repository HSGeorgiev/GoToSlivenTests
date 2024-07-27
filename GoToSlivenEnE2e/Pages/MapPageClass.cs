using GoToSlivenEnE2e.Globals;
using OpenQA.Selenium;

namespace GoToSlivenEnE2e.Pages
{
    internal class MapPageClass : BasePageClass
    {

        public MapPageClass(IWebDriver driver) : base(driver)
        {
        }

        private readonly By mapSearchField = By.XPath("//input[@eapps-link='search']");
        private readonly By mapSearchButton = By.XPath("//div[@eapps-link='searchBtn']");
        private readonly By myLocationButton = By.XPath("//div[@eapps-link='myLocation']");
        private readonly By barToggle = By.XPath("//div[@eapps-link='barToggle']");

        private readonly string subUrl = "/interactive-map-of-sliven/";

        public void GoToMapPage()
        {
            driver.Navigate().GoToUrl(GlobalConstants.BASE_URL + subUrl);
        }

        public bool MapControlsAreVisible()
        {
            return (FindElement(mapSearchField).Displayed && 
                    FindElement(mapSearchButton).Displayed && 
                    FindElement(myLocationButton).Displayed && 
                    FindElement(barToggle).Displayed);
        }
        
        public string GetMapSearchResult(string searchQuery)
        {
            Type(mapSearchField, searchQuery);
            Click(mapSearchButton);
            By firstResult = By.XPath("(//div[@class='eapps-google-maps-bar-list-item-info'])[1]");
            return GetText(firstResult);
        }

    }
}
