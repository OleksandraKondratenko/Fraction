using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drob
{
    [TestFixture]
    class TestMethod
    {
        [Test]
        public void PlussTwoFractiont()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1,2);
            Fraction actually = f1 + f2;

            Assert.AreEqual(actually, new Fraction(1, 1));

        }
        [Test]
        public void MinusTwoFractiont()
        {
            Fraction f1 = new Fraction(2, 2);
            Fraction f2 = new Fraction(1,2);
            Fraction actually = f1 - f2;

            Assert.AreEqual(actually, new Fraction(1, 2));

        }
        [Test]
        public void MultTwoFractiont()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1,2);
            Fraction actually = f1 * f2;

            Assert.AreEqual(actually, new Fraction(1, 4));

        }
        [Test]
        public void DivTwoFractiont()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1,2);
            Fraction actually = f1 / f2;

            Assert.AreEqual(actually, new Fraction(1, 1));

        }
    }
}
