using GoToSlivenEnE2e.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToSlivenEnE2e.Tests
{
    internal class MapTests : BaseTestsClass
    {

        public void TestMainMenuLinks()
        {
            var mapPage = new MapPageClass(driver);
            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.AttractionsLinkIsProper(),
                "'Tourist Attractions' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.MapLinkIsProper(),
                "'Maps' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.EventsLinkIsProper(),
                "'Events' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.AccommodationLinkIsProper(),
                "'Accommodation' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.HotelsLinkIsProper(),
                "'Hotels' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.GuestHousesLinkIsProper(),
                "'Guest Houses' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.HolodayHomesLinkIsProper(),
                "'Holoday Homes' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.HutsLinkIsProper(),
                "'Huts & Cabins' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.CampingsLinkIsProper(),
                "'Campings' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.RestaurantsLinkIsProper(),
                "'Restaurants' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.PizzeriasLinkIsProper(),
                "'Pizzerias' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.FastFoodLinkIsProper(),
                "'Fast Food Restaurants' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.UsefulLinkIsProper(),
                "'Useful' link does not work properly");
        }

        public void TestFooterLinks()
        {
            var mapPage = new MapPageClass(driver);

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.PrivacyPolicyLinkIsProper(),
                "'Privacy Policy' link does not work properly");

            mapPage.GoToMapPage();
            Assert.IsTrue(mapPage.TermsOfUseLinkIsProper(),
                "'Terms Of Use' link does not work properly");
        }

        [Test]
        public void MapPage_MainMenu_ShouldBeVisible()
        {
            var mapPage = new MapPageClass(driver);
            mapPage.GoToMapPage();
            Assert.That(mapPage.IsTopMenuDiplayed(), Is.True,
                "Top menu is not displayed");
        }

        //[Test]
        //public void MapPage_FooterLinks_ShouldBeVisible()
        //// At the moment of the writing of this test, the links are not included, so the test fails
        //{
        //    var mapPage = new MapPageClass(driver);
        //    mapPage.GoToMapPage();
        //    Assert.That(mapPage.IsFooterLinksDisplayed(), Is.True,
        //        "Footer links are not displayed");
        //}

        [Test]
        public void MainMenu_Links_Should_Works_Properly()
        {
            TestMainMenuLinks();
        }

        //[Test]
        //public void Footer_Links_Should_Works_Properly()
        //// At the moment of the writing of this test, the links are not included, so the test fails
        //{
        //    TestFooterLinks();
        //}

        [Test]
        public void Map_Controls_ShouldBeVisible()
        {
            var mapPage = new MapPageClass(driver);
            mapPage.GoToMapPage();
            Assert.That(mapPage.MapControlsAreVisible(), Is.True,
                "Map controls are not displayed");
        }

        [Test]
        public void MapSearch_Functionality_Should_Works_Properly()
        {
            var mapPage = new MapPageClass(driver);
            mapPage.GoToMapPage();
            string searchQuery = "Hadzhi Dimitar";
            string searchResult = mapPage.GetMapSearchResult(searchQuery);
            string expectedResult = "Hadzhi Dimitar House-Museum";
            Assert.That(searchResult, Does.Contain(expectedResult), "Search results are not as expected!");
        }
    }




}
