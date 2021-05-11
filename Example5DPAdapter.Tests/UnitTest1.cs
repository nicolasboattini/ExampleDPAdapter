using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Example5DPAdapter.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var triceratops = new Triceratops();
            var child = ChildCreator.CreateChild(new TriceratopsToMammalAdapter(triceratops));
            Assert.AreEqual("TRICERATOPS IS CRYING", child.Cry());
            
        }
    }
}
