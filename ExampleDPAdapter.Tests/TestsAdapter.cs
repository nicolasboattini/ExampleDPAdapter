using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleDPAdapter;

namespace AdapterLibraryExample.Tests
{
    [TestClass]
    public class TestsAdapter
    {
        [TestMethod]
        public void TestNormal_Pasa()
        {
            HuecoRedondo hueco = new HuecoRedondo(5);
            FiguraRedonda rfig = new FiguraRedonda(5);
            Assert.IsTrue(hueco.Encaja(rfig));
        }
        [TestMethod]
        public void TestSinAdapter_NoDebeCompilar()
        {
            HuecoRedondo hueco = new HuecoRedondo(5);
            FiguraCuadrada cfig = new FiguraCuadrada(5);
            //Assert.IsTrue(hueco.Encaja(cfig)); //EstoNoCompila
        }
        [TestMethod]
        public void TestAdapter_Pasa_1_Verdadero_1_Falso()
        {
            HuecoRedondo hueco = new HuecoRedondo((double) 5);            
            FiguraCuadrada small_cuadrado = new FiguraCuadrada((double) 5);           
            FiguraCuadrada big_cuadrado = new FiguraCuadrada((double) 10);            
            FiguraCuadradaAdapter small_cuadrado_adapt = new(small_cuadrado);
            FiguraCuadradaAdapter big_cuadrado_adapt = new(big_cuadrado);
            Assert.IsTrue(hueco.Encaja(small_cuadrado_adapt));
            Assert.IsFalse(hueco.Encaja(big_cuadrado_adapt));
        }
    }
}
