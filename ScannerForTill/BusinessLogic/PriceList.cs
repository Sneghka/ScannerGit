using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BusinessLogic
{

    public class PriceList
    {
        private List<Price> prices = new List<Price>();

        public PriceList(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                var price = new Price(line);
                prices.Add(price);
            }
        }
        public bool ItemExists(char ch)
        {
            foreach (var price in prices)
            {
                if (price.Name == ch) return true;
            }
            //Console.ReadLine();
            return false;
        }

        public decimal ItemPrice(char ch)
        {
            foreach (var price in prices)
            {
               if (price.Name == ch) return price.BasicPrice;
            }
            // что правильно возвращать вместо 0?
            return 0;
        }

        public int QuantityForDiscount(char ch)
        {
            foreach (var price in prices)
            {
                if (price.Name == ch) return price.DiscountNumber;
            }
            return 1;
        }

        public decimal DiscountPrice(char ch)
        {
            foreach (var price in prices)
            {
                if (price.Name == ch) return price.DiscountPrice;
            }
            return ItemPrice(ch);
        }
    }
}
