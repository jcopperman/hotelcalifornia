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
            driver.Url = "http://hotel-test.equalexperts.io/";
        }

        [Test]
        public void NavigatetToTheHomepage()
        {
            
        }

        [Test]
        public void Test_Case_003_CreateNewBookingRecord()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_Case_004_DeleteExistingBookingRecord()
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