using GoToSlivenEnE2e.Pages;

namespace GoToSlivenEnE2e.Tests
{
    internal class EventsTests : BaseTestsClass
    {

        private readonly string subUrl = "/event-directory/";

        // BaseTests Class general tests

        [Test]
        public void SiteLogo_Displayed_On_EventsPage()
        {
            IsLogoVisible(subUrl);
        }

        //[Test]
        //public void EventsPage_MainMenu_ShouldBeVisible()
        //{
        //    IsTopMenuViivble(subUrl);
        //}

        //[Test]
        //public void EventsPage_MainMenu_Links_Should_Works_Properly()
        //{
        //    TestMainMenuLinks(subUrl);
        //}

        //[Test]
        //public void EventsPage_FooteMapPage_FooterLinks_ShouldBeVisible()
        //{
        //    IsFooterLinksViivble(subUrl);
        //}

        //[Test]
        //public void EventsPage_Footer_Links_Should_Works_Properly()
        //{
        //    TestFooterLinks(subUrl);
        //}


        // EventsPage Class specific tests

        // The Events directory is not developed ...

    }
}

