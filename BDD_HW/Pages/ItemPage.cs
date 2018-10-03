using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Pages
{
    internal class ItemPage : BasePage
    {
        internal ItemPage (IWebDriver driver): base(driver) { }

        [FindsBy(How = How.XPath, Using = "//li[@name='characteristics']/a")]
        private IWebElement CharacteristicsTab;

        internal void OpenCharacteristicsTab()
        {
            CharacteristicsTab.Click();
        }
    }
}
