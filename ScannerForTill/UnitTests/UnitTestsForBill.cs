using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using NUnit.Framework;



namespace UnitTests
{
    [TestFixture]
    class UnitTestsForBill
    {
        [Test]
        public void TestForListOfGoods()
        {
            var helper = new Bill();
            var input = "AABCDFDDE";
            var output = helper.GetListOfGoods(input);
            Assert.AreEqual("ABCDFE", output);
        }

        [Test]
        public void TestCountOneItemInBill()
        {
            var helper = new Bill();
            var input = "AABCDFDDE";
            var output = helper.CountNumberOfOneItem(input, 'A');
            Assert.AreEqual(2, output);
        }

    }
}
