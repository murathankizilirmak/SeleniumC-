using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HB_Murathan.Pages
{
    [TestClass]
    public class SearchProduct : Base
    {
        [TestMethod]
        public static void SearchProducts(string productname)
        {

            IWebElement SearcButton = DriverForChrome.FindElement(By.Id("buttonProductSearch"));
            IWebElement Search = DriverForChrome.FindElement(By.Id("productSearch"));
            Search.Clear();
            Search.SendKeys(productname);

            try
            {
                SearcButton.Click();
                Base.WhereIAm("SearchResult");
                IWebElement SearchResultPage = DriverForChrome.FindElement(By.ClassName("results-container"));
            }
            catch (Exception)
            {
                Assert.Fail("Search sayfası bulunamadı!");
            }
        }

        [TestMethod]
        public static void CheckSellerAndClickTheCheckBoxes(int count)
        {
            IWebElement SellerFilter = DriverForChrome.FindElement(By.CssSelector("li[class*='box-container satici']"));
            IList<IWebElement> SellerCheckBoxes = SellerFilter.FindElements(By.TagName("li"));
            SellerCheckBoxes[count].Click();
            Task.Delay(2000).Wait();
        }

        [TestMethod]
        public static void AddToBasket()
        {
            IList<IWebElement> BasketItem = DriverForChrome.FindElements(By.ClassName("add-to-cart"));
            BasketItem[0].Click();
        }

        [TestMethod]
        public static void ClearFilterSelection()
        {
            IWebElement ClearSelections = DriverForChrome.FindElement(By.Id("btnClearFilters"));
            ClearSelections.Click();

        }
    }


}
