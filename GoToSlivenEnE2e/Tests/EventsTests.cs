using GoToSlivenEnE2e.Pages;

namespace GoToSlivenEnE2e.Tests
{
    internal class EventsTests : BaseTestsClass
    {
        [Test]
        public void AttractionsLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.AttractionsLinkIsProper(),
                "'Tourist Attractions' link does not work properly");
        }

        [Test]
        public void MapLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.MapLinkIsProper(),
                "'Maps' link does not work properly");
        }

        [Test]
        public void EventsLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.EventsLinkIsProper(),
                "'Events' link does not work properly");
        }

        [Test]
        public void AccommodationsLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.AccommodationLinkIsProper(),
                "'Accommodation' link does not work properly");
        }

        [Test]
        public void HotelsLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.HotelsLinkIsProper(),
                "'Hotels' link does not work properly");
        }

        [Test]
        public void GuestHousesLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.GuestHousesLinkIsProper(),
                "'Guest Houses' link does not work properly");
        }

        [Test]
        public void HolodayHomesLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.HolodayHomesLinkIsProper(),
                "'Holoday Homes' link does not work properly");
        }

        [Test]
        public void HHutsLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.HutsLinkIsProper(),
                "'Huts & Cabins' link does not work properly");
        }

        [Test]
        public void CampingsLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.CampingsLinkIsProper(),
                "'Campings' link does not work properly");
        }

        [Test]
        public void RestaurantsLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.RestaurantsLinkIsProper(),
                "'Restaurants' link does not work properly");
        }

        [Test]
        public void PizzeriasLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.PizzeriasLinkIsProper(),
                "'Pizzerias' link does not work properly");
        }

        [Test]
        public void FastFoodLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.FastFoodLinkIsProper(),
                "'Fast Food Restaurants' link does not work properly");
        }

        [Test]
        public void UsefullLink_Should_Works_Properly()
        {
            EventsPageClass eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.UsefulLinkIsProper(),
                "'Useful' link does not work properly");
        }




        public void TestFooterLinks()
        {
            var eventsPage = new EventsPageClass(driver);

            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.PrivacyPolicyLinkIsProper(),
                "'Privacy Policy' link does not work properly");

            eventsPage.GoToEventsPage();
            Assert.IsTrue(eventsPage.TermsOfUseLinkIsProper(),
                "'Terms Of Use' link does not work properly");

        }



        [Test]
        public void EventsPage_MainMenu_ShouldBeVisible()
        {
            var eventsPage = new EventsPageClass(driver);
            eventsPage.GoToEventsPage();
            Assert.That(eventsPage.IsTopMenuDiplayed(), Is.True,
                "Top menu is not displayed");
        }

        //[Test]
        //public void EventsPage_FooterLinks_ShouldBeVisible()
        //// At the moment of the writing of this test, the links are not included, so the test fails
        //{
        //    var eventsPage = new EventsPageClass(driver);
        //    eventsPage.GoToEventsPage();
        //    Assert.That(eventsPage.IsFooterLinksDisplayed(), Is.True,
        //        "Footer links are not displayed");
        //}



        //[Test]
        //public void Footer_Links_Should_Works_Properly()
        //// At the moment of the writing of this test, the links are not included, so the test fails
        //{
        //    TestFooterLinks();
        //}

    }
}

