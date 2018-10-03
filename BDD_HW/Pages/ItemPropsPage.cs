using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace Pages
{
    internal class ItemPropsPage :BasePage
    {
        private const string propsTabSelector = "//table[@class='chars-t']/tbody";
        internal ItemPropsPage(IWebDriver driver) : base(driver)
        {
            //propsTabSelector = "//table[@class='chars-t']/tbody/*";
        }


        [FindsBy(How = How.XPath, Using = propsTabSelector)]
        private IWebElement CharacteristicsTable;


        internal Dictionary<string, IReadOnlyCollection<IWebElement>> GetItemCharacteristics()
        {
            var ret = new Dictionary<string, IReadOnlyCollection<IWebElement>> { };
            string propName;
            IReadOnlyCollection<IWebElement> propValue;

            var waiter = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            waiter.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='tab_content']/div/div/div[2]/h2")));

            var x = CharacteristicsTable.FindElements(By.XPath("//tr"));
            foreach (var c in CharacteristicsTable.FindElements(By.XPath("//tr")))
            {
                try
                {
                    propName = c.FindElement(By.XPath("td/div[@class='chars-title']")).Text;
                    propValue = c.FindElements(By.XPath("td/div[@class='chars-value']"));
                    ret.Add(propName, propValue);
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
