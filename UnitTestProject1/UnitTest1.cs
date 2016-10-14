using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            ClassLibrary1.Class1 obj = new ClassLibrary1.Class1();
            int res= obj.add(5,4);
            Assert.That(res,Is.EqualTo(9));
        }
    }
}
