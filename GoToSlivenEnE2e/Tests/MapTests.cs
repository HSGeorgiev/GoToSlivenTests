﻿using GoToSlivenEnE2e.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToSlivenEnE2e.Tests
{
    internal class MapTests : BaseTestsClass
    {
        private readonly string subUrl = "/interactive-map-of-sliven/";
        private MapPageClass mapPage;

        [Test]
        public void MapPage_MainMenu_ShouldBeVisible()
        {
            IsTopMenuViivble(subUrl);
        }

        [Test]
        public void MapPage_MainMenu_Links_Should_Works_Properly()
        {
            TestMainMenuLinks(subUrl);
        }

        [Test]
        public void MapPage_FooteMapPage_FooterLinks_ShouldBeVisible()
        {
            IsFooterLinksViivble(subUrl);
        }

        [Test]
        public void Map_Page_Footer_Links_Should_Works_Properly()
        {
            TestFooterLinks(subUrl);
        }

        [Test]
        public void MapPage_Map_Controls_ShouldBeVisible()
        {
            var mapPage = new MapPageClass(driver);
            mapPage.GoToMapPage();
            Assert.That(mapPage.MapControlsAreVisible(), Is.True,
                "Map controls are not displayed");
        }

        [Test]
        public void MapPage_MapSearch_Functionality_Should_Works_Properly()
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
