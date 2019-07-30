using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using Shouldly;

namespace Test
{
    public class MyTest
    {
        [OneTimeSetUp]
        public void TestStartBrowser() {
            Given.Firefox = new FirefoxDriver();
        }

        [OneTimeTearDown]
        public void TestCloseAllBrowser()
        {
            Given.Firefox.Quit();
        }

        [Test]
        public void TestGoogleTranslateCats()
        {
            Given.Firefox
                .OpenGoogle()
                .SearchWith("cats")
                .Title.ShouldStartWith("cats");
        }

        [Test]
        public void TestGoogleTranslateDogs()
        {
            Given.Firefox
                .OpenGoogle()
                .SearchWith("dogs")
                .Title.ShouldStartWith("dogs");
        }
    }
}
