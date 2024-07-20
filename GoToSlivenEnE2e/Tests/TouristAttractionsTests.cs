using GoToSlivenEnE2e.Pages;

namespace GoToSlivenEnE2e.Tests
{
    internal class TouristAttractionsTests : BaseTestsClass
    {

        public void TestMainMenuLinks()
        {
            var atractionPage = new TouristAttractionsPageClass(driver);
            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.AttractionsLinkIsProper(),
                "'Tourist Attractions' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.MapLinkIsProper(),
                "'Maps' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.EventsLinkIsProper(),
                "'Events' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.AccommodationLinkIsProper(),
                "'Accommodation' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.HotelsLinkIsProper(),
                "'Hotels' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.GuestHousesLinkIsProper(),
                "'Guest Houses' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.HolodayHomesLinkIsProper(),
                "'Holoday Homes' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.HutsinkIsProper(),
                "'Huts & Cabins' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.CampingsLinkIsProper(),
                "'Campings' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.RestaurantsLinkIsProper(),
                "'Restaurants' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.PizzeriasLinkIsProper(),
                "'Pizzerias' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.FastFoodLinkIsProper(),
                "'Fast Food Restaurants' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.UsefulLinkIsProper(),
                "'Useful' link does not work properly");
        }

        public void TestFooterLinks()
        {
            var atractionPage = new TouristAttractionsPageClass(driver);

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.PrivacyPolicyLinkIsProper(),
                "'Privacy Policy' link does not work properly");

            atractionPage.GoToAttractionsPage();
            Assert.IsTrue(atractionPage.TermsOfUseLinkIsProper(),
                "'Terms Of Use' link does not work properly");


        }

        [Test]
        public void AttractionPage_MainMenu_ShouldBeVisible()
        {
            var attractionPage = new TouristAttractionsPageClass(driver);
            attractionPage.GoToAttractionsPage();
            Assert.That(attractionPage.IsTopMenuDiplayed(), Is.True,
                "Top menu is not displayed");
        }

        [Test]
        public void MainMenu_Links_Should_Works_Properly()
        {
            TestMainMenuLinks();
        }

        [Test]
        public void Footer_Links_Should_Works_Properly()
        {
            TestFooterLinks();
        }

    }
}
