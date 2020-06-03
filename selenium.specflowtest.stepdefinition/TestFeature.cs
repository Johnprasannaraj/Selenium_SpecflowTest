using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Reflection.Metadata;

namespace SeleniumWebDriver.Step_Definition
{
    [Binding]
    [TestClass]
    public sealed class TestFeature
      

    {
        [Given(@"User is at selenium test web page")]
        [TestMethod]
        public void GivenUserIsAtSeleniumTestWebPage()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist/");
            Thread.Sleep(4000);
            driver.Close();

        }

        [Given(@"Click to view details button should be visible")]
        public void GivenClickToViewDetailsButtonShouldBeVisible()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist/");
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@data-test='1']")).Displayed);
            Thread.Sleep(4000);
            driver.Close();
        }
        [When(@"I click on John Smith ""(.*)"" button")]
        [TestMethod]
        public void WhenIClickOnJohnSmithButton()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist/");
            IWebElement ele = driver.FindElement(By.XPath("//*[@data-test='1']"));
            ele.Click();
            Thread.Sleep(4000);
            driver.Close();
        }
        [Then(@"the John Smith Details should be displayed under selenium test section")]
        [TestMethod]
        public void ThenTheJohnSmithDetailsShouldBeDisplayedUnderSeleniumTestSection()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist/");
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@data-test='1']")).Displayed);
            Thread.Sleep(4000);
            driver.Close();
        }
        [When(@"I click on Jeff Bridges ""(.*)"" button")]
        [TestMethod]
        public void WhenIClickOnJeffBridgesButton()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist/");
            IWebElement ele = driver.FindElement(By.XPath("//*[@data-test='2']"));
            ele.Click();
            Thread.Sleep(4000);
            driver.Close();

        }
        [Then(@"the Jeff Bridges Details should be displayed under selenium test section")]
        [TestMethod]
        public void ThenTheJeffBridgesDetailsShouldBeDisplayedUnderSeleniumTestSection()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist/");
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@data-test='2']")).Displayed);
            Thread.Sleep(4000);
            driver.Close();

        }
        [When(@"I click on Steve Jones ""(.*)"" button")]
        [TestMethod]
        public void WhenIClickOnSteveJonesButton()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist/");
            IWebElement ele = driver.FindElement(By.XPath("//*[@data-test='3']"));
            ele.Click();
            Thread.Sleep(4000);
            driver.Close();
            

        }
        [Then(@"the Steve Jones Details should be displayed under selenium test section")]
        [TestMethod]
        public void ThenTheSteveJonesDetailsShouldBeDisplayedUnderSeleniumTestSection()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://9a2cdb3e.azurewebsites.net/customerlist/");
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@data-test='3']")).Displayed);
            Thread.Sleep(4000);
            driver.Close();
        }

        }
}
