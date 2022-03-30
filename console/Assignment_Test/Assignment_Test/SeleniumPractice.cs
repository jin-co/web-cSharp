using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Assignment_Test
{
    [TestFixture]
    public class SeleniumPractice
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //driver = new FirefoxDriver(); // setting up firefox browser

            //new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //driver = new EdgeDriver(); //setting up edge browser

            driver.Manage().Window.Maximize(); // maximizes the opening browser
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://www.selenium.dev/";
            //TestContext.Progress.WriteLine(driver.Title);
            //TestContext.Progress.WriteLine(driver.Url);
            //driver.Close(); // closes only the browser that is open
            //driver.Quit(); // closes all the browsers

            driver.FindElement(By.Id("")).SendKeys(""); // identifies a field and sends a value
            driver.FindElement(By.Name("")).SendKeys(""); // identifies a field and sends a value
            driver.FindElement(By.ClassName("")).SendKeys(""); // identifies a field and sends a value
            driver.FindElement(By.Id("")).Clear(); // clears the field
            // for css tagName[attribute = ""]
            driver.FindElement(By.CssSelector("input[value = 'Sign']"));
            driver.FindElement(By.XPath("//input[@value = 'Sign']"));
            driver.FindElement(By.CssSelector("input[value = 'Sign']")).Click(); // will click

            Thread.Sleep(3000); // mimics interval
            String gettingText = driver.FindElement(By.Id("")).Text;
            
            IWebElement link = driver.FindElement(By.LinkText("linkText"));
            String href = link.GetAttribute("href");
            String expectedUrl = "https//";

            Assert.AreEqual(expectedUrl, href);


        }

    }
}
