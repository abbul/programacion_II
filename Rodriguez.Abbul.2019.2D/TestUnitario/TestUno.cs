using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class TestUno
    {
        [TestMethod]
        public void ValidaSerializado()
        {
            //---
            string path = "C:/archivo.xml";
            Avion avionAntes = new Avion(1);
            Avion avionDespues;

            //---
            Xml<Avion>.Guarda(path, avionAntes);
            Xml<Avion>.Lee(path, out avionDespues);
            
            //--
            Assert.AreEqual(avionAntes,avionDespues);
        }
    }
}
