using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Pages
{
    internal class SearchResultsPage : BasePage
    {
        private const string firstFoundItemSelector = "//div[@class='g-i-tile-i-title clearfix']";

        internal SearchResultsPage(IWebDriver driver): base(driver) { }

        [FindsBy(How = How.XPath, Using = firstFoundItemSelector)]
        private IWebElement FirstItemInSearchResults;

        internal void OpenFirstItemInSearchResults()
        {
            FirstItemInSearchResults.Click();
        }
    }
}
