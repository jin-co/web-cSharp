using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace TestFinal
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;        

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //driver = new FirefoxDriver();

            driver.Manage().Window.Maximize();
            //driverFirefox.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";            
            Assert.Pass();
        }

        #region Form page test
        [Test]
        public void FormPage_CheckTitle_ReturnTrue()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);

            Assert.AreEqual("Event | Form", driver.Title);
        }

        [Test]
        public void FormPage_CheckFieldsExist_ReturnTrue()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);

            var first = driver.FindElement(By.XPath("/html/body/main/form/div[1]/label"));
            var last = driver.FindElement(By.XPath("/html/body/main/form/div[2]/label"));
            var address = driver.FindElement(By.XPath("/html/body/main/form/div[3]/label"));
            var city = driver.FindElement(By.XPath("/html/body/main/form/div[4]/label"));
            var province = driver.FindElement(By.XPath("/html/body/main/form/div[5]/label"));
            var postal = driver.FindElement(By.XPath("/html/body/main/form/div[6]/label"));
            var phone = driver.FindElement(By.XPath("/html/body/main/form/div[7]/label"));
            var email = driver.FindElement(By.XPath("/html/body/main/form/div[8]/label"));
            var users = driver.FindElement(By.XPath("/html/body/main/form/div[9]/label"));            
            var days = driver.FindElement(By.XPath("/html/body/main/form/div[10]/label"));            

            Assert.That(first.Displayed, Is.True);
            Assert.That(last.Displayed, Is.True);
            Assert.That(address.Displayed, Is.True);
            Assert.That(city.Displayed, Is.True);
            Assert.That(province.Displayed, Is.True);
            Assert.That(postal.Displayed, Is.True);
            Assert.That(phone.Displayed, Is.True);
            Assert.That(email.Displayed, Is.True);
            Assert.That(users.Displayed, Is.True);
            Assert.That(days.Displayed, Is.True);
        }
        #endregion


        #region Summary page test
        [Test]
        public void SummaryPage_CheckTitle_ReturnTrue()
        {
            driver.Url = "http:/qa.final.com/pages/summary.html";
            Thread.Sleep(500);

            Assert.AreEqual("Event | Summary", driver.Title);
        }

        [Test]
        public void SummaryPage_CheckFieldsExist_ReturnTrue()
        {
            driver.Url = "http:/qa.final.com/pages/summary.html";
            Thread.Sleep(500);

            var success = driver.FindElement(By.XPath("/html/body/main/div/p[1]"));
            var days = driver.FindElement(By.XPath("/html/body/main/div/p[2]"));
            var price = driver.FindElement(By.XPath("/html/body/main/div/p[3]"));
            var back = driver.FindElement(By.XPath("/html/body/main/div/p[4]"));

            Assert.That(success.Displayed, Is.True);
            Assert.That(days.Displayed, Is.True);
            Assert.That(price.Displayed, Is.True);
            Assert.That(back.Displayed, Is.True);
        }
        #endregion

        #region Link test
        [Test]
        public void Navigation_WhenSummaryNavClicked_GoToSummaryPage()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/header/ul/a[2]")).Click();
            Thread.Sleep(500);

            Assert.AreEqual("Event | Summary", driver.Title);
        }

        [Test]
        public void Navigation_WhenHomeNavClicked_GoToFormPage()
        {
            driver.Url = "http:/qa.final.com/pages/summary.html";
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/header/ul/a[1]")).Click();
            Thread.Sleep(500);

            Assert.AreEqual("Event | Form", driver.Title);
        }
        #endregion

        #region Validation test
        [Test]
        public void Validation_RequiredFieldIsMissing_ShowErrorMessage()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/main/form/button")).Click();

            var first = driver.FindElement(By.XPath("/html/body/main/form/div[1]/small"));
            var last = driver.FindElement(By.XPath("/html/body/main/form/div[2]/small"));
            var address = driver.FindElement(By.XPath("/html/body/main/form/div[3]/small"));
            var city = driver.FindElement(By.XPath("/html/body/main/form/div[4]/small"));
            var province = driver.FindElement(By.XPath("/html/body/main/form/div[5]/small"));
            var postal = driver.FindElement(By.XPath("/html/body/main/form/div[6]/small"));
            var phone = driver.FindElement(By.XPath("/html/body/main/form/div[7]/small"));
            var email = driver.FindElement(By.XPath("/html/body/main/form/div[8]/small"));
            var users = driver.FindElement(By.XPath("/html/body/main/form/div[9]/small"));
            var days = driver.FindElement(By.XPath("/html/body/main/form/div[10]/small"));
            
            Assert.AreEqual("first Required", first);
            Assert.AreEqual("last Required", last);
            Assert.AreEqual("address Required", address);
            Assert.AreEqual("city Required", city);
            Assert.AreEqual("province Required", province);
            Assert.AreEqual("postal Required", postal);
            Assert.AreEqual("phone Required", phone);
            Assert.AreEqual("email Required", email);
            Assert.AreEqual("users Required", users);
            Assert.AreEqual("days Required", days);
        }
        #endregion

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}