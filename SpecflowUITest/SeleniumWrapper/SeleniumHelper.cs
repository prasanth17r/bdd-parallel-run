using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWrapper
{
    public class SeleniumHelper
    {
        private IWebDriver driverObj;

        public void LaunchApp(string appUrl)
        {
            driverObj = new ChromeDriver();
            driverObj.Navigate().GoToUrl(appUrl);
        }

        public IWebElement GetElement(string locator)
        {
            IWebElement element = driverObj.FindElement(By.XPath(locator));
            return element;
        }

        public void EnterText(string text, string elementLocator)
        {
            IWebElement element = this.GetElement(elementLocator);
            element.SendKeys(text);
        }

    }
}