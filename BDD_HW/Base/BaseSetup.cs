using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace BDD_HW
{
    internal class BaseSetup
    {

        /*[BeforeScenario]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://rozetka.com.ua/";
        }*/
        [BeforeStep]
        public void StepTimeOut()
        {
            Thread.Sleep(5000);
        }
    }
}
