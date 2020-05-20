using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB_Murathan
{
    [TestClass]
    public class Base
    {
        public static IWebDriver DriverForChrome;
        public static IWebDriver DriverForMozilla;

        [AssemblyInitialize]
        public static void setUpForBrowser(TestContext context)
        {
            DriverForChrome = new ChromeDriver(@"C:\Users\mkizilirmak\source\repos\HB_Murathan\Browsers\Chrome3");
        }

       public static string WhereIAm(string value)
        {
          
            switch (value)
            {
                case "SearchPage":
                    if (DriverForChrome.Url.Contains("ara?q"))
                    {
                        Console.WriteLine("Arama sayfasındasınız");
                    }
                    else
                    {
                        Assert.Fail("Yanlış sayfadasınız!");
                    }
                    break;

                case "LoginPage":
                    if (DriverForChrome.Url.Contains("uyelik/giris?ReturnUrl=%2f"))
                    {
                        Console.WriteLine("Login sayfasındasınız");
                    }
                    else
                    {
                        Assert.Fail("Login sayfasında değilsiniz");
                    }

                    break;

                case "BasketPage":
                    if (DriverForChrome.Url.Contains("ayagina-gelsin/sepetim"))
                    {
                        Console.WriteLine("Login sayfasındasınız");
                    }
                    break;
            }
            

            return value;

        }
    }



}
