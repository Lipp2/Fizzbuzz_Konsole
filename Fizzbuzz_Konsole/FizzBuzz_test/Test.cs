using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fizzbuzz_Konsole;

namespace FizzBuzz_test
{
    [TestFixture]
    public class Test
    {
        [Test, Category("Akzeptanztest")]
        public void Wie_viele_zahlen()
        {
            var ergebnis = Start_FizzBuzz.Zahlen_auswerten(20, 50);
            Assert.AreEqual(31, ergebnis.Count());
        }

        //[Test, Category("Undsotest")]

        //public void test()
        //{
        //    var ergebnis = Program.Zahlen_auswerten(0, 10);
        //    Assert.AreEqual("Fizz", ergebnis[3]);
        //}

    }
}
