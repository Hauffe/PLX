using BusinessLayer.Facades;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CategoriaFacade facade = new CategoriaFacade();
            facade.SalvarCategoria("Eletronicos", "Produtos eletroeletronicos");
        }
    }
}
