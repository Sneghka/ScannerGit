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
    public class UnitTestsForPrice
    {
        [Test]

        public void TestForItemName()
        {
            var input = "C 10 150 20";
            var helper = new Price(input);
            var output = helper.Name;
            Assert.AreEqual('C', output);
        }

    }
}
