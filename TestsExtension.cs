using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Test
{
    public static class TestsExtension
    {
        public static IWebDriver OpenGoogle(this IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            return driver;
        }

        public static IWebDriver SearchWith(this IWebDriver driver, string keyword)
        {
            driver.FindElement(By.Name("q")).SendKeys(keyword + Keys.Enter);
            driver.WaitUtil(By.Id("rcnt"));
            return driver;
        }

        private static void WaitUtil(this IWebDriver driver, By findElementBy, int TimeoutSeconds = 3)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(TimeoutSeconds))
                .Until(d => d.FindElement(findElementBy));
        }
    }
}
