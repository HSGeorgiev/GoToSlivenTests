using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using SeleniumExtras.WaitHelpers;

namespace GoToSlivenEnE2e.Pages
{
    internal class BaseClass
    {
        public string baseUrl => "https://www.goto-sliven.com/en/";

        protected readonly IWebDriver driver;
        protected WebDriverWait wait;

        public BaseClass(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        protected IWebElement FindElement(By by)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        protected ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return driver.FindElements(by);
        }

        protected void Click(By by)
        {
            FindElement(by).Click();
        }

        protected void Type(By by, string text)
        {
            IWebElement element = FindElement(by);
            element.Clear();
            element.SendKeys(text);
        }

        protected string GetText(By by)
        {
            IWebElement element = FindElement(by);
            return element.Text;
        }
    }
}
