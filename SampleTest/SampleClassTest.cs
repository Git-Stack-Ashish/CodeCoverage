using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Sample;

namespace SampleTest
{
    [TestFixture]
    public class SampleClassTest
    {
        [Test]
        public void AddTest()
        {
            int a = SampleClass.Add(1, 2);
        }
    }
}
