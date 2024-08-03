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

        protected IReadOnlyCollection<IWebElement> FindElements(By by)
        {
            // We pass a By class selector as argument here.
            // Returns an collection of web elements IWebElement or throw an exception
            // Would return an IReadOnlyCollection if By argument is a valid selector.
            // Would throw an exception if By argument is not a valid selector.
            // Would throw an exception if element/elements is/are not found within timeout, defined in GlobalConstants class.

            IReadOnlyCollection<IWebElement>? elements = null;

            try
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(by));
                elements = driver.FindElements(by);
            }
            catch (WebDriverTimeoutException e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: Some of elements, described as | {by} | not found " +
                    $"after timeout, set on {GlobalConstants.DEFAULT_TIMESPAN} seconds.\n" +
                    $"WebDriver says: {e.Message}");
            }
            catch (InvalidSelectorException e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: The argument  | {by} | is not a valid selector here!" +
                    $"WebDriver says: {e.Message}");
            }

            catch (ElementNotVisibleException e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: Somme of requested elements | {by} | is/are present but is/are not visible!" +
                    $"WebDriver says: {e.Message}");
            }

            catch (Exception e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: Exception thrown when trying to find element | {by} |!" +
                    $"An exception, not handled in SlivenProjectsTests.Helpers.DriverHelper class." +
                    $"WebDriver says: {e.Message}");
            }

            return elements;

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
            IReadOnlyCollection<IWebElement> element = FindElements(by);
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
            IReadOnlyCollection<IWebElement> element = FindElements(by);
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
