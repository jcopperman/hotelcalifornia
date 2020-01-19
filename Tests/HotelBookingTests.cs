using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace HotelBookingTests
{
    public class Tests
    {
        IWebDriver _driver;

        public string homeUrl = "http://hotel-test.equalexperts.io/";

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            
        }
        public void NavigatetToTheHomepage()
        {
            _driver.Navigate().GoToUrl(homeUrl);
        }

        public void DeleteExistingHotelBookingRecord()
        {
            IWebElement element = _driver.FindElement(By.Id("firstname"));
        }

        [Test]
        public void Test_Case_003_CreateNewBookingRecord()
        {
            NavigatetToTheHomepage();
            IWebElement firstname = _driver.FindElement(By.Id("firstname"));
            IWebElement lastname = _driver.FindElement(By.Id("lastname"));
            IWebElement totalprice = _driver.FindElement(By.Id("totalprice"));
            IWebElement depositpaid = _driver.FindElement(By.Id("depositpaid"));
            IWebElement checkin = _driver.FindElement(By.Id("checkin"));
            IWebElement checkout = _driver.FindElement(By.Id("checkout"));
            IWebElement savebutton = _driver.FindElement(By.CssSelector("#form > div:nth-child(1) > div:nth-child(7) > input:nth-child(1)"));
            firstname.SendKeys("Doctor");
            lastname.SendKeys("Who");
            totalprice.SendKeys("1000");
            checkin.SendKeys("2020-12-25");
            checkout.SendKeys("2020-12-25");
            savebutton.Click();
            Thread.Sleep(3000);
            Assert.Pass();
        }

        [Test]
        public void Test_Case_004_DeleteExistingBookingRecord()
        {
            NavigatetToTheHomepage();
            Assert.Pass();
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }
    }
}