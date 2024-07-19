using GoToSlivenEnE2e.Pages;

namespace GoToSlivenEnE2e.Tests
{
    internal class HomePageTests : BaseTestsClass
    {
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



    }
}
