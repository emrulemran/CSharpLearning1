using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Selenium1
{
     class FirstTestCase
    {
        static void Main(string[] args) 
        {

                        IWebDriver driver = new FirefoxDriver();
                        driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");

            String parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent window's handle -> " + parentWindowHandle);



            /*

                        Console.Write("test case started ");
                        //create the reference for the browser  
                        IWebDriver driver = new FirefoxDriver();
                        // navigate to URL  
                        driver.Navigate().GoToUrl("https://www.google.com/");
                        Thread.Sleep(2000);
                        // identify the Google search text box  
                        IWebElement ele = driver.FindElement(By.Name("q"));
                        //enter the value in the google search text box  
                        ele.SendKeys("javatpoint tutorials");
                        Thread.Sleep(2000);
                        //identify the google search button  
                        IWebElement ele1 = driver.FindElement(By.Name("btnK"));
                        // click on the Google search button  
                        ele1.Click();
                        Thread.Sleep(3000);
                        //close the browser  
                        driver.Close();
                        Console.Write("test case ended ");
              */
        }
    }
}