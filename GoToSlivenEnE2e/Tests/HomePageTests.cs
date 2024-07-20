using GoToSlivenEnE2e.Pages;

namespace GoToSlivenEnE2e.Tests
{
    internal class HomePageTests : BaseTestsClass
    {

        public void TestMainMenuLinks()
        {
            HomePageClass homePage = new HomePageClass(driver);
            homePage.GoToHomePage();
            Assert.IsTrue(homePage.AttractionsLinkIsProper(),
                "'Tourist Attractions' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.MapLinkIsProper(),
                "'Maps' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.EventsLinkIsProper(),
                "'Events' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.AccommodationLinkIsProper(),
                "'Accommodation' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.HotelsLinkIsProper(),
                "'Hotels' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.GuestHousesLinkIsProper(),
                "'Guest Houses' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.HolodayHomesLinkIsProper(),
                "'Holoday Homes' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.HutsinkIsProper(),
                "'Huts & Cabins' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.CampingsLinkIsProper(),
                "'Campings' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.RestaurantsLinkIsProper(),
                "'Restaurants' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.PizzeriasLinkIsProper(),
                "'Pizzerias' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.FastFoodLinkIsProper(),
                "'Fast Food Restaurants' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.UsefulLinkIsProper(),
                "'Useful' link does not work properly");
        }

        public void TestFooterLinks()
        {
            HomePageClass homePage = new HomePageClass(driver);

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.PrivacyPolicyLinkIsProper(),
                "'Privacy Policy' link does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.TermsOfUseLinkIsProper(),
                "'Terms Of Use' link does not work properly");


        }

        private void TestHomePageButtons()
        {
            HomePageClass homePage = new HomePageClass(driver);

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.EventsButtonWorksProper(),
                "'Events' button on The Home page does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.ExploreMoreButtonWorksProper(),
                "'Explore more' button on The Home page does not work properly");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.ReadMoreButtonWorksProper(),
                "'Read more' button on The Home page does not work properly");
        }

        private void TestSubHeadings()
        {
            HomePageClass homePage = new HomePageClass(driver);

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.WelcomeSubHeadingIsProper(),
                "'Welcome to Sliven' sub-heading is missing or wrong");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.TouristCentereSubHeadingIsProper(),
                "'Tourist Centere' sub-heading is missing or wrong");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.ExploreSubHeadingIsProper(),
                "'Explore' sub-heading is missing or wrong");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.EventsSubHeadingIsProper(),
                "'Events' sub-heading is missing or wrong");

            // ExploreOnTheMapsSubHeadingIsProper method doesn't work properly if
            // headless browser options is used!
            // Either do not use headless browser or do not execute tne next Assert
            homePage.GoToHomePage();
            Assert.IsTrue(homePage.ExploreOnTheMapsSubHeadingIsProper(),
                "'Explore On The Map' sub-heading is missing or wrong");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.BlogArticleSubHeadingIsProper(),
                "'Blog and Articles' sub-heading is missing or wrong");

        }

        private void TestH6SubHeads()
        {
            HomePageClass homePage = new HomePageClass(driver);

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.AboutUsH6SubHeadingIsProper(),
                "'About Us' H6 sub-heading is missing or wrong");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.DestanationSlivenH6SubHeadingIsProper(),
                "'Destination Sliven' sub-heading is missing or wrong");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.WhyChooseUsH6SubHeadingIsProper(),
                "'Why Choose Us' H6 sub-heading is missing or wrong");

            homePage.GoToHomePage();
            Assert.IsTrue(homePage.NewsUsH6SubHeadingIsProper(),
                "'News' H6 sub-heading is missing or wrong");
        }

        [Test]
        public void HomePage_MainMenu_ShouldBeVisible()
        {
            HomePageClass homePage = new HomePageClass(driver);
            homePage.GoToHomePage();
            Assert.That(homePage.IsTopMenuDiplayed(), Is.True, 
                "Top menu is not displayed");
        }

        [Test]
        public void HomePage_FooterLinks_ShouldBeVisible()
        {
            HomePageClass homePage = new HomePageClass(driver);
            homePage.GoToHomePage();
            Assert.That(homePage.IsFooterLinksDisplayed(), Is.True,
                "Footer links are not displayed");
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

        [Test]
        public void Both_Buttons_in_TheHead_Should_Works_Properly()
        {
            TestHomePageButtons();
            // That is about both buttons/links on the head and the
            // 'Read more' button on Tourist Center part
        }

        [Test]
        public void SubHeadings_Should_Be_Presented()
        {
            TestSubHeadings();
        }

        [Test]
        public void H6_SubHeads_Should_Be_Presented()
        {
            TestH6SubHeads();
        }

    }
}
