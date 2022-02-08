using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using BrowserStack;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Safari;

namespace ConsoleApp1
{
    class Program
    {
        public static IWebDriver driver;
        static void Main(string[] args)
        {
            
            try
            {


                //        List<KeyValuePair<string, string>> options = new List<KeyValuePair<string, string>>() {
                //new KeyValuePair<string, string>("key", "MB2FznbXBqaCqjEXmp3p"),

                //        new KeyValuePair<string, string>("localIdentifier", "Test123"),
                //        //new KeyValuePair<string, string>("f", "C:\\row1\\"),
                //        new KeyValuePair<string, string>("onlyAutomate", "true"),
                //        new KeyValuePair<string, string>("verbose", "true"),
                //        new KeyValuePair<string, string>("forcelocal", "true"),
                //        new KeyValuePair<string, string>("binarypath", "C:\\Users\\rojha\\source\\repos\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\netcoreapp2.1\\BrowserStackLocal.exe"),
                //        new KeyValuePair<string, string>("logfile", "C:\\row1\\local.log"),
                //    };
                //        local.start(options);

                //        Console.WriteLine(local.isRunning());


                //CHROME ON WINDOWS 11 machine

                //ChromeOptions capabilities = new ChromeOptions();
                // capabilities.BrowserVersion = "latest";
                //Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                //browserstackOptions.Add("os", "Windows");
                //browserstackOptions.Add("osVersion", "11");
                //browserstackOptions.Add("local", "false");
                //browserstackOptions.Add("seleniumVersion", "3.7.1");
                //browserstackOptions.Add("userName", "ron_pc5Vwn");
                //browserstackOptions.Add("accessKey", "MB2FznbXBqaCqjEXmp3p");
                //capabilities.AddAdditionalOption("bstack:options", browserstackOptions);



                //SAFARI ON IPHONE

                SafariOptions capabilities = new SafariOptions();
                Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                browserstackOptions.Add("osVersion", "15");
                browserstackOptions.Add("deviceName", "iPhone 13");
                browserstackOptions.Add("realMobile", "true");
                browserstackOptions.Add("local", "false");
                browserstackOptions.Add("debug", "true");
                browserstackOptions.Add("consoleLogs", "verbose");
                browserstackOptions.Add("userName", "ron_pc5Vwn");
                browserstackOptions.Add("accessKey", "MB2FznbXBqaCqjEXmp3p");



                //CHROME ON ANDROID PHONES

                //ChromeOptions capabilities = new ChromeOptions();
                //Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
                //browserstackOptions.Add("osVersion", "12.0");
                //browserstackOptions.Add("deviceName", "Google Pixel 6");

                //browserstackOptions.Add("realMobile", "false");
                //browserstackOptions.Add("local", "false");
                //browserstackOptions.Add("debug", "true");
                //browserstackOptions.Add("consoleLogs", "verbose");
                //browserstackOptions.Add("userName", "ron_pc5Vwn");
                //browserstackOptions.Add("accessKey", "MB2FznbXBqaCqjEXmp3p");




                capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
                //capabilities.AddArgument("--ignore-certificate-errors");
                capabilities.AcceptInsecureCertificates = true;



                driver = new RemoteWebDriver(new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capabilities);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                //driver.Manage().Window.Maximize();


                driver.Navigate().GoToUrl("https://www.hbomax.com");
                //Console.WriteLine(driver.Title.ToString());
                Thread.Sleep(2000);



                //driver.FindElement(By.Id("username")).SendKeys("CWOWRN");
                //driver.FindElement(By.Id("password")).SendKeys("Welcome1!");

                //Thread.Sleep(2000);

                try
                {
                    IWebElement myelement = driver.FindElement(By.XPath("//a[contains(.,'$9.99')]"));
                    IJavaScriptExecutor jse2 = (IJavaScriptExecutor)driver;
                    jse2.ExecuteScript("arguments[0].click();", myelement);


//                    driver.FindElement(By.XPath("//a[contains(.,'$9.99')]")).Click();
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Exception occured on clicking due to " +ex);
                }
               

                //Thread.Sleep(2000);
                //driver.FindElement(By.Id("btnLogin")).Click();
                Thread.Sleep(2000);
                driver.Quit();
            }
            

            catch (Exception ex)
            {

                driver.Quit();
                
            }
        }
    }
}
