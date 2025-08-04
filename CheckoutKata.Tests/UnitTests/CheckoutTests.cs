namespace CheckoutKata.Tests.UnitTests
{
    [TestClass]
    public sealed class CheckoutTests
    {
        [TestMethod]
        public void EmptyBasketIsZero()
        {
            var checkout = new Checkout();
            Assert.AreEqual(0, checkout.GetTotalPrice());
        }

        [TestMethod]
        public void TotalMatchesItemPriceWhenOneItemInBasket()
        {
            var checkoutA = new Checkout();
            checkoutA.Scan("A");
            Assert.AreEqual(10, checkoutA.GetTotalPrice());

            var checkoutB = new Checkout();
            checkoutB.Scan("B");
            Assert.AreEqual(15, checkoutB.GetTotalPrice());

            var checkoutC = new Checkout();
            checkoutC.Scan("C");
            Assert.AreEqual(40, checkoutC.GetTotalPrice());

            var checkoutD = new Checkout();
            checkoutD.Scan("D");
            Assert.AreEqual(55, checkoutD.GetTotalPrice());
        }

        [TestMethod]

        //public void OfferForItemBAppliedAtCheckout()
        //{
        //    var checkout = new Checkout();
        //    checkout.Scan("B");
        //    checkout.Scan("B");
        //}
    }
}
