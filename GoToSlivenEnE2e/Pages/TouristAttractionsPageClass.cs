using GoToSlivenEnE2e.Globals;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToSlivenEnE2e.Pages
{
    internal class TouristAttractionsPageClass : BasePageClass
    {
        public TouristAttractionsPageClass(IWebDriver driver) : base(driver)
        {
        }

        private readonly string subUrl = "/tourist-attractions/";

        public void GoToAttractionsPage()
        {
            driver.Navigate().GoToUrl(GlobalConstants.BASE_URL + subUrl);
        }

        // ToDo - To map specific elements on the Tourists Attractions page

        // H2 subheadings mapped
        private readonly By landMarksH2Heading = By.XPath("(//h2)[1]");
        private readonly By heritageH2Heading = By.XPath("(//h2)[2]");
        private readonly By entertainmentH2Heading = By.XPath("(//h2)[3]");

        // See more links mapped
        private readonly By landmarksSeeMoreLink = By.XPath("//section[3]/div[2]/div[1]//a");
        private readonly By heritageSeeMoreLink = By.XPath("//section[3]/div[2]/div[2]//a");
        private readonly By entertainmentSeeMoreLink = By.XPath("//section[3]/div[2]/div[3]//a");

        public bool AreAttractionCategoriesVisibleAndProper()
        {
            return FindElement(landMarksH2Heading).Displayed &&
                    GetText(landMarksH2Heading) == "LANDMARKS" &&
                    FindElement(heritageH2Heading).Displayed &&
                    GetText(heritageH2Heading) == "CULTURAL & HISTORICAL HERITAGE" &&
                    FindElement(entertainmentH2Heading).Displayed &&
                    GetText(entertainmentH2Heading) == "PARKS & PLACES FOR ENTERTAINMENT";
        }

        public bool AreSeeMoreLinksVisible()
        {
            return FindElement(landmarksSeeMoreLink).Displayed &&
                    FindElement(heritageSeeMoreLink).Displayed &&
                    FindElement(entertainmentSeeMoreLink).Displayed;
        }

        public bool DoSeeMoreLinksWorkProperly()
        {
            Click(landmarksSeeMoreLink);
            Click(heritageSeeMoreLink);
            Click(entertainmentSeeMoreLink);
            return true;
        }

        public bool LandmarksSeeMoreLinkWorksProper()
        {
            Click(landmarksSeeMoreLink);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("landmarks") && currentPageTitle.Contains("Landmarks"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HeritageSeeMoreLinkWorksProper()
        {
            Click(heritageSeeMoreLink);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("cultural-historical-heritage") && currentPageTitle.Contains("Cultural & Historical Heritage"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EntertainmentSeeMoreLinkWorksProper()
        {
            Click(entertainmentSeeMoreLink);
            string currentUrl = driver.Url;
            string currentPageTitle = driver.Title;
            if (currentUrl.Contains("parks-places-for-entertainment") && currentPageTitle.Contains("Parks, Places for Entertainment"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
