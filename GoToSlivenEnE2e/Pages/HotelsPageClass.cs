using GoToSlivenEnE2e.Globals;
using OpenQA.Selenium;

namespace GoToSlivenEnE2e.Pages
{
    public class HotelsPageClass : BasePageClass
    {
        private readonly string subUrl = "/hotels/";
        public HotelsPageClass(IWebDriver driver) : base(driver)
        {
        }

        private readonly By hotelsLinkElement = By.CssSelector(".col-xl-3 a");
        private readonly By hotelsElement = By.CssSelector(".col-xl-3 .cat_title");
  

        public void GoToHotelsPage()
        {
            driver.Navigate().GoToUrl(GlobalConstants.BASE_URL + subUrl);
        }

        public bool AreAnyHotels()
        {
            IWebElement[] linksHotels = GetWebElementArray(hotelsLinkElement);
            if (linksHotels.Length > 0) return true;
            else return false;
        }
        public Dictionary<string, By> GetAllHotels()
        {
            Dictionary<string, By> hotels = new Dictionary<string, By>();

            IWebElement[] linksHotels = GetWebElementArray(hotelsLinkElement);
            string[] namesHotels = GetWebElementTextArray(hotelsElement);

            for (int i = 0; i < linksHotels.Length; i++)
            {
                hotels.Add(namesHotels[i], By.XPath($"(//div[@class='card-img-container-filter']//a)[{i+1}]"));
            }

            return hotels;
        }







    }
}
