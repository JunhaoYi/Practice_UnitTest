using NUnit.Framework;
using TestNinja.Fundamentals;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        [Test]
        public void Add_WhenCalled_ReturnTheSunOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = _math.Max(1,2);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_ArgumentIsAreEqual_ReturnTheSameArgument()
        {
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
