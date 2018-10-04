using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Pages
{
    internal class ItemPage : BasePage
    {
        private const string charTabSelector = "//li[@name='characteristics']/a";

        internal ItemPage (IWebDriver driver): base(driver) { }

        [FindsBy(How = How.XPath, Using = charTabSelector)]
        private IWebElement CharacteristicsTab;

        internal void OpenCharacteristicsTab()
        {
            CharacteristicsTab.Click();
        }
    }
}
