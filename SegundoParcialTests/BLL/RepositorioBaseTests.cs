using Microsoft.VisualStudio.TestTools.UnitTesting;
using SegundoParcial.BLL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            Vendedores vendedor = new Vendedores();
            vendedor.VendedorId = 1;
            vendedor.Nombres = "Oscar";
            vendedor.Cuota = 2100;
            RepositorioBase<Vendedores> repositorio;
            repositorio = new RepositorioBase<Vendedores>();
            Assert.IsTrue(repositorio.Guardar(vendedor));
        }

       
    }
}