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

        /*[FindsBy(How = How.XPath, Using = "//input[@class='rz-header-search-input-text passive']")]
        private IWebElement SearchField;

        [FindsBy(How = How.CssSelector, Using = "#rz-search > form > span > span > button")]
        private IWebElement SearchSubmitButton;*/


        [FindsBy(How = How.XPath, Using = "//div[@class='g-i-tile-i-title clearfix']")]
        private IWebElement FirstItemInSearchResults;

        /*[FindsBy(How = How.XPath, Using = "//li[@name='characteristics']/a")]
        private IWebElement CharacteristicsTab;


        [FindsBy(How = How.XPath, Using = "//table[@class='chars-t']/tbody/*")]
        private IWebElement CharacteristicsTable;

        internal SearchResultsPage SearchItem (string query)
        {
            SearchField.SendKeys(query);
            SearchSubmitButton.Click();
            return this;
        }*/

        internal void OpenFirstItemInSearchResults()
        {
            FirstItemInSearchResults.Click();
        }

        /*internal SearchResultsPage OpenCharacteristicsTab()
        {
            CharacteristicsTab.Click();
            return new SearchResultsPage(_driver);
        }

        internal Dictionary<string, IReadOnlyCollection<IWebElement>> GetItemCharacteristics()
        {
            var ret = new Dictionary<string, IReadOnlyCollection<IWebElement>> { };

            var foo = CharacteristicsTable.FindElements(By.XPath("//tr"));

            foreach (var c in CharacteristicsTable.FindElements(By.XPath("//tr")))
            {
                try
                {
                    ret.Add(c.FindElement(By.XPath("td/div[@class='chars-title']")).Text, c.FindElements(By.XPath("td/div[@class='chars-value']")));
                }
                catch (Exception e)
                {
                    if (e is NoSuchElementException || e is System.ArgumentException) { continue; }
                    else { throw e.InnerException; }
                }
            }
            return ret;
        }*/




    }
}
