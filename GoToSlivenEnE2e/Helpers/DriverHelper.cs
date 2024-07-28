using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using SeleniumExtras.WaitHelpers;
using GoToSlivenEnE2e.Globals;

namespace GoToSlivenEnE2e.Helpers
{
    public class DriverHelper
    {
        protected readonly IWebDriver driver;
        protected WebDriverWait wait;

        public DriverHelper(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(GlobalConstants.DEFAULT_TIMESPAN));
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
                Assert.Fail($"GO_TO_SLIVEN_TESTS_ERROR: Element not found after timeout,\n" +
                    $"set on {GlobalConstants.DEFAULT_TIMESPAN} seconds. Test says: {ex.Message}");
            }

            catch (InvalidSelectorException ex)
            {
                Assert.Fail($"GO_TO_SLIVEN_TESTS_ERROR: 'By' argument passed to FindElement wrapper method - {by} \n" +
                    $"is not valid. Test says: {ex.Message}");
            }

            catch (ElementNotVisibleException ex)
            {
                Assert.Fail($"GO_TO_SLIVEN_TESTS_ERROR: Element is present but not visible - {by} \n" +
                    $"is not valid. Test says: {ex.Message}");
            }

            catch (Exception ex)
            {
                Assert.Fail($"GO_TO_SLIVEN_TESTS_ERROR:  \n" +
                    $"Test says: {ex.Message}");
            }

            return element;

        }

        protected ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            
            ReadOnlyCollection<IWebElement> element = null;
            
            try
            {
                return driver.FindElements(by);
            }
            catch (NoSuchElementException ex)
            {
                Assert.Fail($"GO_TO_SLIVEN_TESTS_ERROR: The element {by} is not found - No such element on the page.\n" +
                    $"Test says: {ex.Message}");
                return null;
            }

            catch (Exception ex)
            {
                Assert.Fail($"GO_TO_SLIVEN_TESTS_ERROR:  \n" +
                    $"Test says: {ex.Message}");
                return null;
            }

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
