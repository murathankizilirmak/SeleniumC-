using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HB_Murathan
{
    [TestClass]
    public class WithoutLogin
    {
        [TestMethod]
        public void WithoutLoginAndBuyProductFromTwoSeller()
        {
            Pages.Login.OpenPortal();
            Pages.Login.LoginCheck();
            //Aşağıdaki kalem ürününü testmanager,hp alm gibi data store eden herhangi bir kaynaktan almak bazen gerekebilir,ben şimdilik kendim girdim.
            int destination = 0;
            //Satıcılar ve sepete eklerken ilk item rahat eklenirken 2. ürün eklenemedi bu sebeple aşağıdaki loop u kurmak zorunda kaldım.
            Again:
            if (destination<=1)
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
