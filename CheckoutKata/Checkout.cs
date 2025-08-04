using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class Checkout
    {
        int total;

        private Dictionary<string, int> prices = new()
        {
            {"A", 10},
            {"B", 15},
            {"C", 40},
            {"D", 55}
        };


        public int GetTotalPrice () 
        { 
            return total; 
        }

        public void Scan(string v)
        {
            if (prices.ContainsKey(v))
            {
                total += prices[v];
            }
        }
    }
}
