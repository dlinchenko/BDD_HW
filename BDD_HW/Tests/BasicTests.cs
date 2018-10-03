using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Pages;
using System.Threading;

namespace Selenium.Tests
{
    [TestFixture]
    public class BasicTests
    {
        [Test]
        public void TestSearchInput()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://rozetka.com.ua/";


            var mainPage = new MainRozetkaPage(driver);
            mainPage.SearchItem("apple iphone 7");
            var searchResultsPage = new SearchResultsPage(driver);
            searchResultsPage.OpenFirstItemInSearchResults();
            var itemPage = new ItemPage(driver);
            itemPage.OpenCharacteristicsTab();
            var itemPropsPage = new ItemPropsPage(driver);
            var itemProps = itemPropsPage.GetItemCharacteristics();

            driver.Close();
        }
    }
}
