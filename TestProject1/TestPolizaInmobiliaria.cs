using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea5;

namespace TestPolizas
{
    [TestClass]
    public class TestPolizaInmobiliaria
    {
        [TestMethod]
        public void TestConstructorPolizaInmobiliariaValida()
        {
             PolizaInmobiliaria casaValida = new PolizaInmobiliaria(
                 1,
                 new DateTime(2021, 1, 1),
                 new DateTime(2022, 1, 1),
                 PolizaInmobiliaria.Ubicaciones.Norte,
                 1000000,
                 PolizaInmobiliaria.TipoCobertura.Basica
             );

            Assert.IsInstanceOfType(casaValida, typeof(PolizaInmobiliaria));
        }

        [TestMethod]
        public void TestCalcularPolizaInmobiliariaInvalido()
        {
            PolizaInmobiliaria casaInvalida = new PolizaInmobiliaria(
                1,
                new DateTime(2021, 1, 1),
                new DateTime(2022, 1, 1),
                PolizaInmobiliaria.Ubicaciones.Norte,
                -1000000,
                PolizaInmobiliaria.TipoCobertura.Basica
            );

            Assert.ThrowsException<ArgumentException>(() => casaInvalida.CalcularCobertura());
        }

        [TestMethod]
        public void TestCalcularPolizaInmobiliariaValido()
        {
            PolizaInmobiliaria casaValida = new PolizaInmobiliaria(
               1,
               new DateTime(2021, 1, 1),
               new DateTime(2022, 1, 1),
               PolizaInmobiliaria.Ubicaciones.Norte,
               1000000,
               PolizaInmobiliaria.TipoCobertura.Basica
            );

            var costo_poliza = casaValida.CalcularPoliza();
            Assert.AreEqual(costo_poliza, 20000.80m);
        }

        [TestMethod]
        public void TestCalcularCoberturaInvalida()
        {
            PolizaInmobiliaria casaInvalida = new PolizaInmobiliaria(
                1,
                new DateTime(2021, 1, 1),
                new DateTime(2022, 1, 1),
                PolizaInmobiliaria.Ubicaciones.Norte,
                -1000000,
                PolizaInmobiliaria.TipoCobertura.Basica
            );

            Assert.ThrowsException<ArgumentException>(() => casaInvalida.CalcularCobertura());
        }

        [TestMethod]
        public void TestCalcularCoberturaValida()
        {
            PolizaInmobiliaria casaValida = new PolizaInmobiliaria(
               1,
               new DateTime(2021, 1, 1),
               new DateTime(2022, 1, 1),
               PolizaInmobiliaria.Ubicaciones.Norte,
               1000000,
               PolizaInmobiliaria.TipoCobertura.Basica
            );

            var costo_poliza = casaValida.CalcularCobertura();
            Assert.AreEqual(costo_poliza, 750000);
        }

    }
}
