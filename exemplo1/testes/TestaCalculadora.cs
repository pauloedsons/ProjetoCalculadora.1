using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using exemplo1;

namespace testes
{
    [TestClass]
    public class TestaCalculadora
    {
        [TestMethod]
        public void TestaSoma()
        {
            Calculadora c = new Calculadora();
            int resultado = c.Soma(3, 4);
            Assert.AreEqual(7, resultado);
        }
    }
}
