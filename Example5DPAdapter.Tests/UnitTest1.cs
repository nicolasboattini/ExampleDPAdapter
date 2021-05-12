using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Example5DPAdapter.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Triceratops_Da_Hijo_Como_Mamifero_Y_Llora()
        {
            var triceratops = new Triceratops();
            var triceratops_adaptado = new TriceratopsAMamiferoAdapter(triceratops);
            var hijo = CreadorDeHijo.CreateChild(triceratops_adaptado);
            Assert.AreEqual("TRICERATOPS ESTA LLORANDO", hijo.Llorar());
            
        }
    }
}
