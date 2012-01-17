using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace sound
{
    class sound
    {
        [Test]
        public void openFileTest()
        {
            sound sou = new sound();
            sou.create("jh");
            Assert.AreEqual('\0', sou.create("blah.txt"));
            Assert.AreEqual(0, sou.open("C:"));
        }
    }
}
