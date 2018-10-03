using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Selenium.Pages;
using OpenQA.Selenium.Support.UI;

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
            //new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            var page = new SearchResultsPage(driver);
            page.SearchItem("apple iphone");
            page.OpenFirstItemInSearchResults();
            page.OpenCharacteristicsTab();
            page.GetItemCharacteristics();

            driver.Close();
        }
    }
}
