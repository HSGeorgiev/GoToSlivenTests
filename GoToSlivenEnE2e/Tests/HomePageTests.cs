using GoToSlivenEnE2e.Pages;

namespace GoToSlivenEnE2e.Tests
{
    internal class HomePageTests : BaseTestsClass
    {

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

        [Test]
        public void HomePage_MainMenu_ShouldBeVisible()
        {
            HomePageClass homePage = new HomePageClass(driver);
            homePage.GoToHomePage();
            Assert.That(homePage.IsTopMenuDiplayed(), Is.True, 
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

    }
}
