using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
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

        List<PricingRule> pricingRules = new List<PricingRule>
        {
            new PricingRule("A", 15, 3, 40)
        };

        public int GetTotalPrice () 
        { 
            if (basket.Count != 0)
            {
                foreach (var item in basket.GroupBy(x => x))
                {
                    int itemValue = 0;

                    if (prices.TryGetValue(item.Key, out itemValue))
                    {
                        PricingRule ruleA = pricingRules.FirstOrDefault(r => r._sku == "A");
                        int itemCount = item.Count();

                        if (ruleA != null && itemCount >= ruleA._offerQuantity)
                        {
                            total += ruleA._offerPrice;
                        }
                        else
                        {
                            total += itemValue;
                        }
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

    public class PricingRule
    {
        public string _sku { get; }
        public int _unitPrice { get; }
        public int _offerQuantity { get; }
        public int _offerPrice { get; }

        public PricingRule (string sku, int unitPrice, int offerQuantity, int offerPrice)
        {
            _sku = sku;
            _unitPrice = unitPrice;
            _offerQuantity = offerQuantity;
            _offerPrice = offerPrice;
        }
    }
}
