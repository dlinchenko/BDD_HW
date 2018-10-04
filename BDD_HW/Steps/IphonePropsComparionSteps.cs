using System;
using TechTalk.SpecFlow;
using Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace BDD_HW
{
    [Binding]
    internal class IphonePropsComparionSteps : BaseSetup
    {
        [Given(@"I am on Rozetka store page")]
        internal void GivenIAmOnRozetkaStorePage()
        {
            //this is dummy
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
        
        
        [Then(@"details of (.*) and (.*) are compared and similar are printed to console")]
        internal void ThenDetailsAreComparedAndSimilarArePrintedToConsole(string item1, string item2)
        {
            ScenarioContext.Current.TryGetValue(item1, out Dictionary<string, List<string>> item1Props);
            ScenarioContext.Current.TryGetValue(item2, out Dictionary<string, List<string>> item2Props);
            foreach(var k in item1Props.Keys)
            {
                if (item2Props.ContainsKey(k))
                {
                    if (item1Props[k].SequenceEqual(item2Props[k]))
                    {
                        item1Props[k].ToList().ForEach(x => Console.WriteLine($"{k}: {x}"));
                            }
                            
                        }
                            
                    }
                }
            }
        }
