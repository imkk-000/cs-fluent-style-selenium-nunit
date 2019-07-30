using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Test
{
    public static class MyTestExtension
    {
        public static IWebDriver Start(this IWebDriver driver)
        {
            return new FirefoxDriver();
        }

        public static IWebDriver OpenGoogle(this IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            return driver;
        }

        public static IWebDriver Search(this IWebDriver driver, string keywords)
        {
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys(keywords);
            searchBox.SendKeys(Keys.Enter);
            return driver;
        }
    }
}
