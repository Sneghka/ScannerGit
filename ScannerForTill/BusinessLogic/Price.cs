using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Price
    {
        public char Name { get; set; }
        public decimal BasicPrice { get; set; }
        public int DiscountNumber { get; set; }
        public decimal DiscountPrice { get; set; }

        public Price(string line)
        {
            var word = line.Split(' ');

            Name = line[0];
            BasicPrice = Convert.ToDecimal(word[1]);

            if (word.Length == 2) DiscountNumber = 1;
            else DiscountNumber = Convert.ToInt32(word[2]);

            if (word.Length == 2) DiscountPrice = BasicPrice;
            else DiscountPrice = Convert.ToDecimal(word[3]);
        }
    }
}
