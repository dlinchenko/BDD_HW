using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Selenium.Pages
{
    internal class BasePage
    {
        protected IWebDriver _driver;

        internal BasePage (IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

    }
}
