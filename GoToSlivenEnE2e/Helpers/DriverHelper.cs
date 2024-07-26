using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using SeleniumExtras.WaitHelpers;

namespace GoToSlivenEnE2e.Helpers
{
    public class DriverHelper
    {
        protected string baseUrl => "https://gotosliven.com/";

        protected readonly IWebDriver driver;
        protected WebDriverWait wait;

        public DriverHelper(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public IWebElement FindElement(By by)
        {
            IWebElement? element = null;
            try
            {
                element = wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (WebDriverTimeoutException ex)
            {
                Assert.Fail($"Element not found after timeout. Exception says: {ex.Message}");
            }

            catch (WebDriverArgumentException ex)
            {
                Assert.Fail($"Element not found. Exception says: {ex.Message}");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            return element;

        }

        protected ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return driver.FindElements(by);
        }

        public void Click(By by)
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
