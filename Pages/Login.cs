using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HB_Murathan.Pages
{
    [TestClass]
    public class Login:Base
    {
       

        [TestMethod]
        public static void OpenPortal()
        {
            DriverForChrome.Manage().Window.Maximize();
            DriverForChrome.Navigate().GoToUrl("https://www.hepsiburada.com");
        }

        [TestMethod]
        public  static void LoginCheck()
        {
            IWebElement LoginButton = DriverForChrome.FindElement(By.Id("myAccount"));            
            try
                {
                    LoginButton.Text.Contains("Giriş Yap").ToString();
                }
                catch (Exception)
                {
                    Assert.Fail("Login durumdasınız");
                }
        }
     
        [TestMethod]
        public static void LoginWithYourUser(string username , string password)
        {
            IWebElement LoginButton = DriverForChrome.FindElement(By.Id("myAccount"));
            IWebElement LoginButtonLink = DriverForChrome.FindElement(By.Id("login"));
           

            LoginButton.Click();
            LoginButtonLink.Click();
            
            try
            {
                Base.WhereIAm("LoginPage");
                IWebElement LoginPageHeader = DriverForChrome.FindElement(By.ClassName("login-container"));         
                IWebElement LoginButtonas=   DriverForChrome.FindElement(By.CssSelector("button[class*='btn-login-submit']"));


                Task.Delay(2000).Wait();
                IWebElement Email = DriverForChrome.FindElement(By.Id("email"));
                IWebElement Pwd = DriverForChrome.FindElement(By.Id("password"));
                
                Email.SendKeys(username);
                Pwd.SendKeys(password);
                LoginButtonas.Click();

            }
            catch (Exception)
            {
                Assert.Fail("Login Page açilamadı");
            }
            

        }
    }
}
