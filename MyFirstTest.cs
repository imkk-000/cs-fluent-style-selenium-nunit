using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestOpenGoogleDotCom()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("https://www.google.com/");
                Assert.AreEqual("https://www.google.com/", driver.Url);
            }
        }
    }
}
