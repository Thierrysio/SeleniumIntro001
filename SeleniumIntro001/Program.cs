using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumIntro001
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"c:\Drivers\web");
            driver.Navigate().GoToUrl("https://www.google.fr/");
            var element = driver.FindElement(By.XPath("//*[@id=\"L2AGLb\"]"));
            Thread.Sleep(5000);
            element.Click();
            element = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
            element.SendKeys("webshop");
            element.Submit();
            
        }
    }
}
