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

        MapPage Class specific tests

       [Test]
        public void AttractionPage_Categories_Attractions_Should_Be_Viseble()
        {
            var attractionsPage = new TouristAttractionsPageClass(driver);
            attractionsPage.GoToAttractionsPage();
            Assert.That(attractionsPage.AreAttractionCategoriesVisibleAndProper(), Is.True,
                "Attraction categories are not visible or are wrong!");
        }

        [Test]
        public void AttractionPage_Landmarks_SeeMore_Links_Landmarks_Should_Work_Properly()
        {
            var attractionsPage = new TouristAttractionsPageClass(driver);
            attractionsPage.GoToAttractionsPage();
            Assert.That(attractionsPage.LandmarksSeeMoreLinkWorksProper(), Is.True, 
                "Landmarks 'See more' links are not working properly!");
        }

        [Test]
        public void AttractionPage_Heritage_SeeMore_Links_Landmarks_Should_Work_Properly()
        {
            var attractionsPage = new TouristAttractionsPageClass(driver);
            attractionsPage.GoToAttractionsPage();
            Assert.That(attractionsPage.HeritageSeeMoreLinkWorksProper(), Is.True,
                "Heritage 'See more' links are not working properly!");
        }

        [Test]
        public void AttractionPage_Entertaiment_SeeMore_Links_Landmarks_Should_Work_Properly()
        {
            var attractionsPage = new TouristAttractionsPageClass(driver);
            attractionsPage.GoToAttractionsPage();
            Assert.That(attractionsPage.EntertainmentSeeMoreLinkWorksProper(), Is.True,
                "Entertainment 'See more' links are not working properly!");
        }
    }
}
