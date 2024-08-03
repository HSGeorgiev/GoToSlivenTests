using GoToSlivenEnE2e.Pages;

namespace GoToSlivenEnE2e.Tests
{
    internal class HomePageTests : BaseTestsClass
    {

        private readonly string subUrl = "/";

        // BaseTests Class general tests

        [Test]
        public void SiteLogo_Displayed_On_HomePage()
        {
            IsLogoVisible(subUrl);
        }

        [Test]
        public void HomePage_MainMenu_ShouldBeVisible()
        {
            IsTopMenuViivble(subUrl);
        }

        [Test]
        public void HomePage_MainMenu_Links_Should_Works_Properly()
        {
            TestMainMenuLinks(subUrl);
        }

        [Test]
        public void HomePage_FooteMapPage_FooterLinks_ShouldBeVisible()
        {
            IsFooterLinksViivble(subUrl);
        }

        [Test]
        public void HomePage_Footer_Links_Should_Works_Properly()
        {
            TestFooterLinks(subUrl);
        }

     
        // HomePage Class specific tests

        [Test]
        public void Both_Buttons_in_TheHead_Should_Works_Properly()
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

        [Test]
        public void SubHeadings_Should_Be_Presented()
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

        //[Test]
        //public void H6_SubHeads_Should_Be_Presented()
        //{
        //    HomePageClass homePage = new HomePageClass(driver);

        //    homePage.GoToHomePage();
        //    Assert.IsTrue(homePage.AboutUsH6SubHeadingIsProper(),
        //        "'About Us' H6 sub-heading is missing or wrong");

        //    homePage.GoToHomePage();
        //    Assert.IsTrue(homePage.DestanationSlivenH6SubHeadingIsProper(),
        //        "'Destination Sliven' sub-heading is missing or wrong");

        //    homePage.GoToHomePage();
        //    Assert.IsTrue(homePage.WhyChooseUsH6SubHeadingIsProper(),
        //        "'Why Choose Us' H6 sub-heading is missing or wrong");

        //    homePage.GoToHomePage();
        //    Assert.IsTrue(homePage.NewsUsH6SubHeadingIsProper(),
        //        "'News' H6 sub-heading is missing or wrong");
        //}


        [Test]
        public void Map_Controls_ShouldBeVisible()
        {
            HomePageClass homePage = new HomePageClass(driver);
            homePage.GoToHomePage();
            Assert.That(homePage.MapControlsAreVisible(), Is.True,
                "Map controls are not displayed");
        }

        [Test]
        public void MapSearch_Functionality_Should_Works_Properly()
        {
            var homePage = new HomePageClass(driver);
            homePage.GoToHomePage();
            string searchQuery = "Hadzhi Dimitar";
            string searchResult = homePage.GetMapSearchResult(searchQuery);
            string expectedResult = "Hadzhi Dimitar House-Museum";
            Assert.That(searchResult, Does.Contain(expectedResult), "Search results are not as expected!");
        }

    }
}
