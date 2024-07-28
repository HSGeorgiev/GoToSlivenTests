using GoToSlivenEnE2e.Pages;

namespace GoToSlivenEnE2e.Tests
{
    internal class TouristAttractionsTests : BaseTestsClass
    {
        private readonly string subUrl = "/tourist-attractions/";

        // BaseTests Class general tests

        [Test]
        public void SiteLogo_Displayed_On_AttractionsPage()
        {
            IsLogoVisible(subUrl);
        }

        [Test]
        public void AttractionsPage_MainMenu_ShouldBeVisible()
        {
            IsTopMenuViivble(subUrl);
        }

        [Test]
        public void AttractionsPage_MainMenu_Links_Should_Works_Properly()
        {
            TestMainMenuLinks(subUrl);
        }

        [Test]
        public void AttractionsPage_FooteMapPage_FooterLinks_ShouldBeVisible()
        {
            IsFooterLinksViivble(subUrl);
        }

        [Test]
        public void Attractions_Page_Footer_Links_Should_Works_Properly()
        {
            TestFooterLinks(subUrl);
        }

        // MapPage Class specific tests

        // ToDo - To prepare tests for the elements on the Tourists Attractions page
    }
}
