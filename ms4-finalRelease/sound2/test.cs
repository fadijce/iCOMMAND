using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace sound2
{
    [TestFixture]
    class test
    {

        [Test]
        public void openFileTest()
        {
            sound sou = new sound();
            MainWindow sou2=new MainWindow();
           // Assert.AreEqual('\0', sou.create("blah.txt"));
            Assert.AreEqual(0, sou.open("C:"));
            Assert.AreEqual(0,sou.internet("yahoo"));
            Assert.AreEqual(0,sou2.changeback());
        }

    }
}
