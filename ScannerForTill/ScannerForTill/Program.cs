using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BusinessLogic;

namespace ScannerForTill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a bill");
            string bill = Console.ReadLine();
            var priceList = new PriceList(@"D:\Sneghka\Visual Studio\Block 4\ScannerForTill\PriceList.txt");

            foreach (char ch in bill) if (!priceList.ItemExists(ch) || bill == string.Empty) return;

            var listOfGoods = new Bill();
            decimal sumOfBill = 0;
            foreach (char ch in listOfGoods.GetListOfGoods(bill))
            {
                if (listOfGoods.CountNumberOfOneItem(bill, ch) >= priceList.QuantityForDiscount(ch))
                {
                    sumOfBill += priceList.DiscountPrice(ch) * listOfGoods.CountNumberOfOneItem(bill, ch);
                }
                else
                {
                    sumOfBill += priceList.ItemPrice(ch) * listOfGoods.CountNumberOfOneItem(bill, ch);
                }
            }
            Console.WriteLine("Sum of the bill = {0}", sumOfBill);
            Console.ReadKey();
        }
    }
}

