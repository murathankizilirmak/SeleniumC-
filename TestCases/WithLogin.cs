using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HB_Murathan.TestCases
{
    [TestClass]
    public class WithLogin
    {
        [TestMethod]
        public void LoginAndBuyProductFromTwoSeller()
        {
            Pages.Login.OpenPortal();
            Pages.Login.LoginWithYourUser("deneme@hotmail.com","sifrenizigirin");
            //Aşağıdaki kalem ürününü testmanager,hp alm gibi data store eden herhangi bir kaynaktan almak bazen gerekebilir,ben şimdilik kendim girdim.
            int destination = 0;
            Again:
            if (destination <= 1)
            {
                Pages.SearchProduct.SearchProducts("Kalem");
                Pages.SearchProduct.CheckSellerAndClickTheCheckBoxes(destination);
                Pages.SearchProduct.AddToBasket();
                Pages.SearchProduct.ClearFilterSelection();
                destination++;
                goto Again;
            }
            Pages.Basket.ClickBasketButton();
            Pages.Basket.BasketPage();
        }
    }
}
