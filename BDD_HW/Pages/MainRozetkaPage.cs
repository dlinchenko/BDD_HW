using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Pages
{
    internal class MainRozetkaPage : BasePage
    {
        private const string searchFieldSelector = "//input[@class='rz-header-search-input-text passive']";
        private const string searchButtonSelector = "#rz-search > form > span > span > button";

        internal MainRozetkaPage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.XPath, Using = searchFieldSelector )]
        private IWebElement SearchField;

        [FindsBy(How = How.CssSelector, Using = searchButtonSelector)]
         private IWebElement SearchSubmitButton;

        internal void SearchItem(string query)
        {
            SearchField.SendKeys(query);
            SearchSubmitButton.Click();
        }
    }
}
