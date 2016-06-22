using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Chrome;

namespace FacebookLoginTest
{
    class FacebookLoginClass
    {

        public static void Main()
        {
            // create the webdriver

            IWebDriver d = new ChromeDriver(@"E:\Softwares\Testing\chromedriver_win32\chromedriver.exe");

            // open url
            d.Navigate().GoToUrl("http://www.facebook.com");
            Console.WriteLine(" Facebook url is open sucessfully...");


            // enter facebook email id in testbox
            Thread.Sleep(5000);
            d.FindElement(By.Id("email")).SendKeys("mnaidu.thota@gmail.com");
            Console.WriteLine(" email id sending sucessfully...");

            // enter password to text box
            Thread.Sleep(5000);
            d.FindElement(By.Id("pass")).SendKeys("lakshmi@143");
            Console.WriteLine(" Facebook password sending sucessfully...");

            // click on login 
            Thread.Sleep(5000);
            d.FindElement(By.Id("u_0_m")).Click();

            Console.WriteLine(" Facebook login sucessfully...");

            
        }
    }
}
