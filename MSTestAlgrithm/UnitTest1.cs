using System.Runtime.Intrinsics.X86;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo;
namespace MSTestAlgrithm
{
    [TestClass]
    public class UnitTest1
    {
        private Exercise exercise=new Exercise();
        [TestMethod]
        public void TestFactrial()
        {
            int i=3;
            Assert.AreEqual(exercise.Factrial(i),6);
        }
        [TestMethod]
        public void TestFabonacci()
        {
            Assert.AreEqual(exercise.Fabonacci(5),8);
        }
        [TestMethod]
        public void TestDecryptQQ()
        {
            Assert.AreEqual(exercise.DecryptQQ("44724302"),"47404322");
        }

        [TestMethod]
        public void TestPalindrome()
        {
            Assert.IsTrue(exercise.IsPalindrome("abcdcba"));
            Assert.IsFalse(exercise.IsPalindrome("abcde"));
        }
        [TestMethod]
        public void TestPerfectNum()
        {
            var res=exercise.FindPerfectNumber(1000);
            Assert.AreEqual(res.Count,3);
            Assert.AreEqual(res[0],6);
            Assert.AreEqual(res[1],28);
            Assert.AreEqual(res[2],496);
        }
    }
}
