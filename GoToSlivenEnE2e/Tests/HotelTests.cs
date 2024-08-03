using GoToSlivenEnE2e.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;

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

        //[Test]
        //public void HotelsPage_MainMenu_Links_Should_Works_Properly()
        //{
        //    TestMainMenuLinks(subUrl);
        //}

        //[Test]
        //public void HotelsPage_FooterLinks_ShouldBeVisible()
        //{
        //    IsFooterLinksViivble(subUrl);
        //}

        //[Test]
        //public void Hotels_Page_Footer_Links_Should_Works_Properly()
        //{
        //    TestFooterLinks(subUrl);
        //}

        //HotelsPage Class specific tests



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
                // GetNextPageH2 first to use explicite wait first
                string newPageTitle = hotelsPage.GetNextPageH2(hotel.Value);
                // Have to get it clear - should be names identical or they may vary in case of UpperKeys or LowerKeys!!!
                // The next assert will only work if we make strings case insensitive becouse of Family Hotel Kalina/Family hotel Kalina!
                //Assert.That(newPageTitle, Does.Contain(hotel.Key), $"Wrong H2 on next page: '{hotel.Key}' link does not work properly");
                Assert.That(newPageTitle.ToUpper(), Does.Contain(hotel.Key.ToUpper()), $"Wrong H2 heading tag on next page: '{hotel.Key}' link does not work properly");
                Assert.That(hotelsPage.GetCurrentTitle(driver), Does.Contain(hotel.Key), $"Wrong Title tag on next page:'{hotel.Key}' link does not work properly");
            }
        }
    }
}
