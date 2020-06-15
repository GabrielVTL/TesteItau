using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Web_iCarros.Driver
{
    class Drivers
    {
        public static IWebDriver driver;

        public static IWebDriver AbrirChrome()
        {
            var filePath = Directory.GetParent(Directory.GetCurrentDirectory()) + "\\WebDriver";
            var options = new ChromeOptions();
            options.AddArguments(
                "--start-maximized",
                "--ignore-certificate-errors",
                "--disable-popup-blocking",
                "--incognito"
                );
            driver = new ChromeDriver(filePath, options);
            return driver;
        }

        public void GoToUrl (string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void FecharNavegador()
        {
            driver.Quit();
            driver = null;
        }
    }
}
