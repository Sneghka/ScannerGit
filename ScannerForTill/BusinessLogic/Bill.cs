using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Bill
    {
        public List<char> GetListOfGoods(string str)
        {
            var listOfGoods = new List<char>();
            foreach (char ch in str)
            {
                if (!listOfGoods.Contains(ch)) listOfGoods.Add(ch);
            }
            return listOfGoods;
        }

        public int CountNumberOfOneItem(string str, char ch)
        {
            int i = 0;
            foreach (char chr in str)
            {
                if (chr == ch) i++;
            }
            return i;
        }
    }
}
