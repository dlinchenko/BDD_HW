using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Selenium.Pages
{
    internal class SearchResultsPage : BasePage
    {
        private IWebDriver _driver;

        internal SearchResultsPage(IWebDriver driver): base(driver) { _driver = driver; }

        [FindsBy(How = How.XPath, Using = "//input[@class='rz-header-search-input-text passive']")]
        private IWebElement SearchField;

        [FindsBy(How = How.CssSelector, Using = "#rz-search > form > span > span > button")]
        private IWebElement SearchSubmitButton;


        [FindsBy(How = How.XPath, Using = "//div[@class='g-i-tile-i-title clearfix']")]
        private IWebElement FirstItemInSearchResults;

        [FindsBy(How = How.XPath, Using = "//li[@name='characteristics']/a")]
        private IWebElement CharacteristicsTab;


        [FindsBy(How = How.XPath, Using = "//table[@class='chars-t']/tbody/*")]
        private IWebElement CharacteristicsTable;

        internal void SearchItem (string query)
        {
            SearchField.SendKeys(query);
            SearchSubmitButton.Click();
            //return this;
        }

        internal void OpenFirstItemInSearchResults()
        {
            FirstItemInSearchResults.Click();
            //return this;
        }

        internal void OpenCharacteristicsTab()
        {
            CharacteristicsTab.Click();
            //PageFactory.InitElements(_driver, this);
            //return this;
        }

        internal void GetItemCharacteristics()
        {
            var ret = new Dictionary<string, IReadOnlyCollection<IWebElement>> { };
            var z = CharacteristicsTab.FindElements(By.XPath("//tr/*/div[@class='chars-title']"));

            foreach (var c in CharacteristicsTable.FindElements(By.XPath("//tr")))
            {
                var x = c.FindElement(By.XPath("td/div[@class='chars-title']")).Text;
                ret.Add(c.FindElement(By.XPath("td/div[@class='chars-title']")).Text, c.FindElements(By.XPath("td/div[@class='chars-value']")));
            }
        }




    }
}
