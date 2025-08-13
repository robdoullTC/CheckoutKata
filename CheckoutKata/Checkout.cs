using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Checkout
    {
        int total = 0;
        private List<string> basket = [];

        private Dictionary<string, int> prices = new()
        {
            {"A", 10},
            {"B", 15},
            {"C", 40},
            {"D", 55}
        };




        public int GetTotalPrice () 
        { 

            if (basket.Count != 0)
            {
                foreach (string item in basket)
                {
                    int itemValue = 0;

                    if (prices.TryGetValue(item, out itemValue))
                    {
                        total += itemValue;
                    }
                }
            }
            return total;
        }

        public void Scan(string v)
        {
            if (prices.ContainsKey(v))
            {
                basket.Add(v);
            }
        }
    }

    public class PricingRules
    {
        private string _sku;
        private int _price;
        private int _quantity;

        public PricingRules (string sku, int price, int quantity)
        {
            _sku = sku;
            _price = price;
            _quantity = quantity;
        }
    }
}
