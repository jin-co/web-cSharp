using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace Assignment_Test
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

            driver.Manage().Window.Maximize();               
        }

        [Test]
        public void PageTitle_EnterAssignment3_ReturnTrue()
        {
            //driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\index.html";                        
            driver.Url = "http:/qa.assignment3.com/pages/index.html";
            Thread.Sleep(500);

            Assert.AreEqual("Assignment 3", driver.Title);
        }

        [Test]
        public void MainPage_CheckNewBoxDisplayed_NewBoxExist()
        {            
            //driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\index.html";
            driver.Url = "http:/qa.assignment3.com/pages/index.html";

            var newComponent = driver.FindElement(By.ClassName("new"));
            Thread.Sleep(500);

            Assert.That(newComponent.Displayed, Is.True);
        }

        [Test]
        public void MainPage_CheckSearchBoxDisplayed_SearchBoxExist()
        {            
            //driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\index.html";
            driver.Url = "http:/qa.assignment3.com/pages/index.html";

            var newComponent = driver.FindElement(By.ClassName("search"));
            Thread.Sleep(500);

            Assert.That(newComponent.Displayed, Is.True);
        }

        [Test]
        public void AddNewPage_CheckFormDisplayed_FormExist()
        {            
            //driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\sale.html";
            driver.Url = "http:/qa.assignment3.com/pages/sale.html";

            var newComponent = driver.FindElement(By.ClassName("form"));
            Thread.Sleep(500);

            Assert.That(newComponent.Displayed, Is.True);
        }

        [Test]
        public void SummaryPage_CheckSummaryDisplayed_SummaryExist()
        {            
            //driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\summary.html";
            driver.Url = "http:/qa.assignment3.com/pages/summary.html";

            var newComponent = driver.FindElement(By.ClassName("table-box"));
            Thread.Sleep(500);

            Assert.That(newComponent.Displayed, Is.True);
        }

        [Test]
        public void ListPage_CheckListDisplayed_ListExist()
        {            
            //driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\list.html";
            driver.Url = "http:/qa.assignment3.com/pages/list.html";

            var newComponent = driver.FindElement(By.ClassName("summary-container"));
            Thread.Sleep(500);

            Assert.That(newComponent.Displayed, Is.True);
        }

        [Test]
        public void SalePage_CheckErrorMessageWhenStart_ErrorMessageNotDisplayed()
        {                       
            //driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\sale.html";            
            driver.Url = "http:/qa.assignment3.com/pages/sale.html";            
            
            var error = driver.FindElement(By.ClassName("error-message"));            
            driver.FindElement(By.ClassName("btn-warning"));
            Thread.Sleep(500);
           
            Assert.That(error.Displayed, Is.False);
        }
        
        [Test]
        public void SalePage_WhenValuesAreValid_GoToSummary()
        {            
            //driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\sale.html";
            driver.Url = "http:/qa.assignment3.com/pages/sale.html";

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var make = driver.FindElement(By.Id("make"));
            var model = driver.FindElement(By.Id("model"));
            var year = driver.FindElement(By.Id("year"));

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("0A0 A9A");
            phone.SendKeys("000-000-0000");
            email.SendKeys("lili@com.com");
            make.SendKeys("Toyota");
            model.SendKeys("Well");
            year.SendKeys("2000");

            Thread.Sleep(500);
            driver.FindElement(By.ClassName("btn")).Click();
            var summary = driver.FindElement(By.ClassName("summary-title"));
            
            Assert.That(summary.Displayed, Is.True);            
        }
        
        [Test]
        public void SalePage_WhenPostalCodeIsNotValid_ShowErrorMessage()
        {            
            //driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\sale.html";
            driver.Url = "http:/qa.assignment3.com/pages/sale.html";

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var make = driver.FindElement(By.Id("make"));
            var model = driver.FindElement(By.Id("model"));
            var year = driver.FindElement(By.Id("year"));

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("222 3R9");
            phone.SendKeys("000-000-0000");
            email.SendKeys("lili@com.com");
            make.SendKeys("Toyota");
            model.SendKeys("Well");
            year.SendKeys("2000");            

            Thread.Sleep(500);
            driver.FindElement(By.ClassName("btn")).Click();
            var error = driver.FindElement(By.ClassName("error-message"));

            Assert.That(error.Displayed, Is.True);
        }

        [Test]
        public void SalePage_WhenPhoneNumIsNotValid_ShowErrorMessage()
        {            
            //driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\sale.html";
            driver.Url = "http:/qa.assignment3.com/pages/sale.html";

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var make = driver.FindElement(By.Id("make"));
            var model = driver.FindElement(By.Id("model"));
            var year = driver.FindElement(By.Id("year"));

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("N2N 3R9");
            phone.SendKeys("0000000000");
            email.SendKeys("lili@com.com");
            make.SendKeys("Toyota");
            model.SendKeys("Well");
            year.SendKeys("2000");

            Thread.Sleep(500);
            driver.FindElement(By.ClassName("btn")).Click();
            var error = driver.FindElement(By.ClassName("error-message"));

            Assert.That(error.Displayed, Is.True);
        }

        [Test]
        public void SummaryPage_WhenValuesAreValid_CreateLink()
        {
            //driver.Url = "C:\\Users\\jin\\Documents\\GitHub\\practice_javascript\\QA_assignment3\\pages\\sale.html";
            driver.Url = "http:/qa.assignment3.com/pages/sale.html";

            var first = driver.FindElement(By.Id("first-name"));
            var last = driver.FindElement(By.Id("last-name"));
            var address = driver.FindElement(By.Id("address"));
            var city = driver.FindElement(By.Id("city"));
            var province = driver.FindElement(By.Id("province"));
            var postal = driver.FindElement(By.Id("postal"));
            var phone = driver.FindElement(By.Id("phone"));
            var email = driver.FindElement(By.Id("email"));
            var make = driver.FindElement(By.Id("make"));
            var model = driver.FindElement(By.Id("model"));
            var year = driver.FindElement(By.Id("year"));

            first.SendKeys("Kwangjin");
            last.SendKeys("Baek");
            address.SendKeys("Somewhere");
            city.SendKeys("Toronto");
            province.SendKeys("Ontario");
            postal.SendKeys("0A0 A9A");
            phone.SendKeys("000-000-0000");
            email.SendKeys("lili@com.com");
            make.SendKeys("Toyota");
            model.SendKeys("Well");
            year.SendKeys("2000");

            Thread.Sleep(500);
            driver.FindElement(By.ClassName("btn")).Click();
            var displayedLink = driver.FindElement(By.XPath("/html/body/main/div/table/tbody/tr[2]/td/a"));
            string link = "http://www.jdpower.com/cars/Toyota/Well/2000";
            
            Assert.AreEqual(link, displayedLink.Text);
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}