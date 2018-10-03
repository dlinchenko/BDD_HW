using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Pages
{
    internal class SearchResultsPage : BasePage
    { 

        internal SearchResultsPage(IWebDriver driver): base(driver) { }

        [FindsBy(How = How.XPath, Using = "//div[@class='g-i-tile-i-title clearfix']")]
        private IWebElement FirstItemInSearchResults;

        internal void OpenFirstItemInSearchResults()
        {
            FirstItemInSearchResults.Click();
        }
    }
}
