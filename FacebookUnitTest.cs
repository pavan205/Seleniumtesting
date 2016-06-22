using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace FacebookLoginUnitTestProject
{
    [TestClass]
    public class FacebookUnitTest
    {
        [TestMethod]
        public void Login()
        {
            // create the webdriver

            IWebDriver d = new ChromeDriver(@"E:\Softwares\Testing\chromedriver_win32\chromedriver.exe");

            // open url
            d.Navigate().GoToUrl("http://www.facebook.com");
           


            // enter facebook email id in testbox
            Thread.Sleep(5000);
            d.FindElement(By.Id("email")).SendKeys("mnaidu.thota@gmail.com");
        

            // enter password to text box
            Thread.Sleep(5000);
            d.FindElement(By.Id("pass")).SendKeys("lakshmi@143");
          

            // click on login 
            Thread.Sleep(5000);
            d.FindElement(By.Id("u_0_m")).Click();

           
        }
    }
}
