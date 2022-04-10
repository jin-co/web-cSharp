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

        [Test]
        public void Navigation_WhenGoBackClicked_GoBackToFormPage()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var users = driver.FindElement(By.Id("users"));
            var day1 = driver.FindElement(By.Id("day1"));
            var day2 = driver.FindElement(By.Id("day2"));
            Thread.Sleep(500);

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("A9A 0A0");
            phone.SendKeys("000-000-0000");
            email.SendKeys("lili@com.com");
            users.SendKeys("4");
            day1.Click();
            day2.Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/main/form/button")).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/main/div/p[4]/a")).Click();
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

            var firstErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[1]/small"));
            var lastErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[2]/small"));
            var addressErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[3]/small"));
            var cityErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[4]/small"));
            var provinceErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[5]/small"));
            var postalErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[6]/small"));
            var phoneErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[7]/small"));
            var emailErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[8]/small"));
            var usersErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[9]/small"));
            var daysErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[10]/small"));

            Assert.AreEqual("first name required", firstErrorMessage.Text);
            Assert.AreEqual("last name required", lastErrorMessage.Text);
            Assert.AreEqual("address required", addressErrorMessage.Text);
            Assert.AreEqual("city required", cityErrorMessage.Text);
            Assert.AreEqual("province required", provinceErrorMessage.Text);
            Assert.AreEqual("postal required", postalErrorMessage.Text);
            Assert.AreEqual("phone required", phoneErrorMessage.Text);
            Assert.AreEqual("email required", emailErrorMessage.Text);
            Assert.AreEqual("#users required", usersErrorMessage.Text);
            Assert.AreEqual("#days required", daysErrorMessage.Text);
        }

        [Test]
        public void Validation_WhenPostalInWrongFormat_ShowErrorMessage()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var users = driver.FindElement(By.Id("users"));
            var day1 = driver.FindElement(By.Id("day1"));
            var day2 = driver.FindElement(By.Id("day2"));
            Thread.Sleep(500);

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("A9 0A0");
            phone.SendKeys("000-000-0000");
            email.SendKeys("lili@com.com");
            users.SendKeys("4");
            day1.Click();
            day2.Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/main/form/button")).Click();
            var postalErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[6]/small"));
            Assert.AreEqual("postal wrong format", postalErrorMessage.Text);
        }

        [Test]
        public void Validation_WhenPhoneInWrongFormat_ShowErrorMessage()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var users = driver.FindElement(By.Id("users"));
            var day1 = driver.FindElement(By.Id("day1"));
            var day2 = driver.FindElement(By.Id("day2"));
            Thread.Sleep(500);

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("A9A 0A0");
            phone.SendKeys("000000-0000");
            email.SendKeys("lili@com.com");
            users.SendKeys("4");
            day1.Click();
            day2.Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/main/form/button")).Click();
            var phoneErrorMessage = driver.FindElement(By.XPath("/html/body/main/form/div[7]/small"));
            Assert.AreEqual("phone wrong format", phoneErrorMessage.Text);
        }       

        [Test]
        public void Validation_WhenValuesValid_ShowSummary()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);            

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var users = driver.FindElement(By.Id("users"));
            var day1 = driver.FindElement(By.Id("day1"));
            var day2 = driver.FindElement(By.Id("day2"));
            Thread.Sleep(500);

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("A9A 0A0");
            phone.SendKeys("000-000-0000");
            email.SendKeys("lili@com.com");
            users.SendKeys("4");
            day1.Click();
            day2.Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/main/form/button")).Click();

            Assert.AreEqual("Event | Summary", driver.Title);
        }
        #endregion

        #region Price calculation
        [Test]
        public void PriceCaculation_WhenOnlyDayOneCheckedWithOneUser_ShowPrice375()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var users = driver.FindElement(By.Id("users"));
            var day1 = driver.FindElement(By.Id("day1"));
            var day2 = driver.FindElement(By.Id("day2"));
            Thread.Sleep(500);

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("A9A 0A0");
            phone.SendKeys("000-000-0000");
            email.SendKeys("lili@com.com");
            users.SendKeys("1");
            day1.Click();            
            Thread.Sleep(500);
            
            driver.FindElement(By.XPath("/html/body/main/form/button")).Click();
            var price = driver.FindElement(By.XPath("/html/body/main/div/p[3]/span"));

            Assert.AreEqual("$375", price.Text);
        }

        [Test]
        public void PriceCaculation_WhenOnlyDayTwoCheckedWithOneUser_ShowPrice475()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var users = driver.FindElement(By.Id("users"));
            var day1 = driver.FindElement(By.Id("day1"));
            var day2 = driver.FindElement(By.Id("day2"));
            Thread.Sleep(500);

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("A9A 0A0");
            phone.SendKeys("000-000-0000");
            email.SendKeys("lili@com.com");
            users.SendKeys("1");
            day2.Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/main/form/button")).Click();
            var price = driver.FindElement(By.XPath("/html/body/main/div/p[3]/span"));

            Assert.AreEqual("$475", price.Text);
        }

        [Test]
        public void PriceCaculation_WhenBothDaysCheckedWithOneUser_ShowPrice800()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var users = driver.FindElement(By.Id("users"));
            var day1 = driver.FindElement(By.Id("day1"));
            var day2 = driver.FindElement(By.Id("day2"));
            Thread.Sleep(500);

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("A9A 0A0");
            phone.SendKeys("000-000-0000");
            email.SendKeys("lili@com.com");
            users.SendKeys("1");
            day1.Click();
            day2.Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath("/html/body/main/form/button")).Click();
            var price = driver.FindElement(By.XPath("/html/body/main/div/p[3]/span"));

            Assert.AreEqual("$800", price.Text);
        }

        [Test]
        public void PriceCaculation_WhenBothDaysCheckedWithMoreThan5Users_ShowDiscountedPrice()
        {
            driver.Url = "http:/qa.final.com/pages/index.html";
            Thread.Sleep(500);

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var users = driver.FindElement(By.Id("users"));
            var day1 = driver.FindElement(By.Id("day1"));
            var day2 = driver.FindElement(By.Id("day2"));
            Thread.Sleep(500);
            int numberOfUsers = 6;
            double total = 0;

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("A9A 0A0");
            phone.SendKeys("000-000-0000");
            email.SendKeys("lili@com.com");
            users.SendKeys(numberOfUsers.ToString());
            day1.Click();
            day2.Click();
            Thread.Sleep(500);
            total = (800 * numberOfUsers) * 0.95;

            driver.FindElement(By.XPath("/html/body/main/form/button")).Click();
            var price = driver.FindElement(By.XPath("/html/body/main/div/p[3]/span"));

            Assert.AreEqual("$" + total, price.Text);
        }
        #endregion

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}