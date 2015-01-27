using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class UnitTestPriceList
    {
        [Test]
        public void TestForItemNameLegal()
        {
            var helper = new PriceList(@"D:\Sneghka\Visual Studio\Block 4\ScannerForTill\PriceList.txt");
            var input = 'B';
            var output = helper.ItemExists(input);
            Assert.AreEqual(true, output);
        }

        [Test]
        public void TestForItemNameIllegal()
        {
            var helper = new PriceList(@"D:\Sneghka\Visual Studio\Block 4\ScannerForTill\PriceList.txt");
            var input = 'F';
            var output = helper.ItemExists(input);
            Assert.AreEqual(false, output);
        }

        [Test]
        public void TestForItemPrice()
        {
            var helper = new PriceList(@"D:\Sneghka\Visual Studio\Block 4\ScannerForTill\PriceList.txt");
            var input = 'C';
            var output = helper.ItemPrice(input);
            Assert.AreEqual(120.5, output);
        }

        [Test]
        public void TestQuantityForDiscountExist()
        {
            var helper = new PriceList(@"D:\Sneghka\Visual Studio\Block 4\ScannerForTill\PriceList.txt");
            var input = 'B';
            var output = helper.QuantityForDiscount(input);
            Assert.AreEqual(7, output);
        }
        [Test]
        public void TestQuantityForDiscountDoesNotExist()
        {
            var helper = new PriceList(@"D:\Sneghka\Visual Studio\Block 4\ScannerForTill\PriceList.txt");
            var input = 'C';
            var output = helper.QuantityForDiscount(input);
            Assert.AreEqual(1, output);
        }

        [Test]
        public void TestDiscountPriceExist()
        {
            var helper = new PriceList(@"D:\Sneghka\Visual Studio\Block 4\ScannerForTill\PriceList.txt");
            var input = 'A';
            var output = helper.DiscountPrice(input);
            Assert.AreEqual(8, output);
        }

        [Test]
        public void TestDiscountPriceDoesNotExist()
        {
            var helper = new PriceList(@"D:\Sneghka\Visual Studio\Block 4\ScannerForTill\PriceList.txt");
            var input = 'C';
            var output = helper.DiscountPrice(input);
            Assert.AreEqual(120.50, output);
        }
    }
}
