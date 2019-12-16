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
    }
}
