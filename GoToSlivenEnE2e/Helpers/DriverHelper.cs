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
                Assert.Fail($"GO_TO_SLIVEN_TESTS_ERROR: Element - {by} - not found after timeout,\n" +
                    $"set on {GlobalConstants.DEFAULT_TIMESPAN} seconds. WebDriver says: {ex.Message}");
            }

            catch (InvalidSelectorException ex)
            {
                Assert.Fail($"GO_TO_SLIVEN_TESTS_ERROR: 'By' argument passed to FindElement wrapper method - {by} \n" +
                    $"is not valid. WebDriver says: {ex.Message}");
            }

            catch (ElementNotVisibleException ex)
            {
                Assert.Fail($"GO_TO_SLIVEN_TESTS_ERROR: Element is present but not visible - {by} \n" +
                    $"is not valid. WebDriver/CS says: {ex.Message}");
            }

            catch (Exception ex)
            {
                Assert.Fail($"GO_TO_SLIVEN_TESTS_ERROR:  \n" +
                    $"WebDriver/CS says: {ex.Message}");
            }

            return element;

        }

        protected ReadOnlyCollection<IWebElement> FindElements(By by)
        {
                       
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

        protected void SendKeys(By by, string text)
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

        protected string[] GetWebElementTextArray(By by)
        {
            ReadOnlyCollection<IWebElement> element = FindElements(by);
            IWebElement[] webElementArray = element.ToArray();
            string[] textArray = new string[element.Count];
            for (int i = 0; i < element.Count; i++)
            {
                textArray[i] = webElementArray[i].Text;
            }
            return textArray;
        }

        protected IWebElement[] GetWebElementArray(By by)
        {
            ReadOnlyCollection<IWebElement> element = FindElements(by);
            return element.ToArray();
        }

        public string GetCurrentUrl(IWebDriver driver)
        {
            return driver.Url;
        }

        public string GetCurrentTitle(IWebDriver driver)
        {
            return driver.Title;
        }
    }
}
