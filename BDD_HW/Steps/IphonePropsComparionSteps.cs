using System;
using TechTalk.SpecFlow;
using Pages;
using OpenQA.Selenium.Chrome;


namespace BDD_HW
{
    [Binding]
    internal class IphonePropsComparionSteps : BaseSetup
    {
        [Given(@"I am on Rozetka store page")]
        internal void GivenIAmOnRozetkaStorePage()
        {
        }
        
        [When(@"I get details of (.*)")]
        internal void WhenIGetDetailsOf(string item)
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://rozetka.com.ua/";

            var mainPage = new MainRozetkaPage(driver);
            mainPage.SearchItem(item);
            var searchResultsPage = new SearchResultsPage(driver);
            searchResultsPage.OpenFirstItemInSearchResults();
            var itemPage = new ItemPage(driver);
            itemPage.OpenCharacteristicsTab();
            var itemPropsPage = new ItemPropsPage(driver);
            var itemProps = itemPropsPage.GetItemCharacteristics();

            driver.Close();
            driver.Dispose();

            ScenarioContext.Current.Add(item, itemProps);
        }
        
        
        [Then(@"their details are compared and similar are printed to console")]
        internal void ThenTheirDetailsAreComparedAndSimilarArePrintedToConsole()
        {

        }
    }
}
