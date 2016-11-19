using BusinessLayer.Facades;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer.Tabelas;

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
        [TestMethod]
        public void TestMethod2()
        {
            UsuarioFacade facade = new UsuarioFacade();
            facade.SalvarUsuario("Robert", "robert@robert.com", "123mudar");
        }
        [TestMethod]
        public void TestMethod3()
        {
            AnuncioFacade facade = new AnuncioFacade();
            facade.SalvarAnuncio("Bicicleta", 120.2, 1, 1);
        }

    }
}
