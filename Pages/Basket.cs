using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace HB_Murathan.Pages
{
    [TestClass]
    public class Basket : Base
    {
        [TestMethod]
        public static void BasketPage()
        {
            try
            {
                Base.WhereIAm("BasketPage");
                IList<IWebElement> CheckTheBasket = DriverForChrome.FindElements(By.ClassName("cart-item-list"));
                if (CheckTheBasket.Count < 1)
                {
                    Assert.Fail("Baskette ürün bulunamadı");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void ClickBasketButton()
        {
            IWebElement ClickTheBasket = DriverForChrome.FindElement(By.Id("CartButton"));
            try
            {
                ClickTheBasket.Click();
            }
            catch (Exception)
            {
                Assert.Fail("Basket butonuna tıklanamadı");
            }
        }
    }
}
