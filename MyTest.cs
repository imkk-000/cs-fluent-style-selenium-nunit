using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Shouldly;

namespace Test
{
    public class MyTest
    {
        [OneTimeSetUp]
        public void StartFirefox()
        {
            Given.Firefox = Given.Firefox.Start();
        }

        [OneTimeTearDown]
        public void CloseFirefox()
        {
            Given.Firefox.Close();
        }

        [Test]
        public void TestGoogleSearchCooking3Minites()
        {
            Given.Firefox
                .OpenGoogle()
                .Search("cooking 3 minutes");
        }

        [Test]
        public void TestGoogleSearchILoveTasty()
        {
            Given.Firefox
                .OpenGoogle()
                .Search("i love tasty");
        }
    }
}
