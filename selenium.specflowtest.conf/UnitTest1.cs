using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumWebDriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement ele = driver.FindElement(By.Name("q"));
            ele.SendKeys("COVID-19 cases in Worldometer");
            Thread.Sleep(2000);
            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            ele1.Click();
            Thread.Sleep(3000);
            driver.Close();
           }
    }
}
