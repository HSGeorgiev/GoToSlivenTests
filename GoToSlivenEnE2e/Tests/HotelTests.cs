using GoToSlivenEnE2e.Pages;

namespace GoToSlivenEnE2e.Tests
{
    internal class HotelTests : BaseTestsClass
    {

        private readonly string subUrl = "/hotels/";

        // BaseTests Class general tests

        [Test]
        public void SiteLogo_Displayed_On_HotelsPage()
        {
            IsLogoVisible(subUrl);
        }

        [Test]
        public void HotelsPage_MainMenu_ShouldBeVisible()
        {
            IsTopMenuViivble(subUrl);
        }

        [Test]
        public void HotelsPage_MainMenu_Links_Should_Works_Properly()
        {
            TestMainMenuLinks(subUrl);
        }

        [Test]
        public void HotelsPage_FooterLinks_ShouldBeVisible()
        {
            IsFooterLinksViivble(subUrl);
        }

        [Test]
        public void Hotels_Page_Footer_Links_Should_Works_Properly()
        {
            TestFooterLinks(subUrl);
        }

        // HotelsPage Class specific tests



        [Test]
        public void HotelsPage_There_Should_Be_Hotels()
        {
            var hotelsPage = new HotelsPageClass(driver);
            hotelsPage.GoToHotelsPage();
            Assert.That(hotelsPage.AreAnyHotels(), Is.True,
                "There are no hotels in the directory");
        }

        [Test]
        public void Does_HotelsLinks_Work_Properly()
        {
            var hotelsPage = new HotelsPageClass(driver);
            hotelsPage.GoToHotelsPage();
            var hotels = hotelsPage.GetAllHotels();

            foreach (var hotel in hotels)
            {
                hotelsPage.GoToHotelsPage();
                hotelsPage.Click(hotel.Value);
                Assert.That(driver.Title, Does.Contain(hotel.Key), $"'{hotel.Key}' link does not work properly");
            }
        }
    }
}
