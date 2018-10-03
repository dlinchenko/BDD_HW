using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Pages
{
    internal class MainRozetkaPage : BasePage
    {
        internal MainRozetkaPage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.XPath, Using = "//input[@class='rz-header-search-input-text passive']")]
        private IWebElement SearchField;

        [FindsBy(How = How.CssSelector, Using = "#rz-search > form > span > span > button")]
         private IWebElement SearchSubmitButton;

        internal void SearchItem(string query)
        {
            SearchField.SendKeys(query);
            SearchSubmitButton.Click();
        }
    }
}
