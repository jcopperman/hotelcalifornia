using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace HotelBookingTests
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void NavigatetToTheHomepage()
        {
            driver.Url = "http://hotel-test.equalexperts.io/";
        }

        [Test]
        public void CreateNewBookingRecord()
        {
            Assert.Pass();
        }

        [Test]
        public void DeleteExistingBookingRecord()
        {
            Assert.Pass();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}