using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace Pages
{
    internal class ItemPropsPage :BasePage
    {
        private const string propsTabSelector = "//table[@class='chars-t']/tbody";
        private const string waiterCondition = "//*[@id='tab_content']/div/div/div[2]/h2";
        private const string propNameSelector = "td/div[@class='chars-title']";
        private const string propValueSelector = "td/div[@class='chars-value']";

        internal ItemPropsPage(IWebDriver driver) : base(driver)
        {}


        [FindsBy(How = How.XPath, Using = propsTabSelector)]
        private IWebElement CharacteristicsTable;


        internal Dictionary<string, List<string>> GetItemCharacteristics()
        {
            var ret = new Dictionary<string, List<string>> { };

            var waiter = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            waiter.Until(ExpectedConditions.ElementExists(By.XPath(waiterCondition)));

            foreach (var c in CharacteristicsTable.FindElements(By.XPath("//tr")))
            {
                try
                {
                    ret.Add(c.FindElement(By.XPath(propNameSelector)).Text, 
                        c.FindElements(By.XPath(propValueSelector))
                        .ToArray().Select(prop => prop.Text).ToList());
                }
                catch (Exception e)
                {
                    if (e is NoSuchElementException || e is System.ArgumentException) { continue; }
                    else { throw e.InnerException; }
                }   
            }
            return ret;
        }
    }
}
