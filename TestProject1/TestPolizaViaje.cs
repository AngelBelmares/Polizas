using System.Runtime.CompilerServices;
using Tarea5;

namespace TestPolizas
{
    [TestClass]
    public class TestPolizaViaje
    {
        [TestMethod]
        public void TestCalcularDuracionViajeCorrect()
        {
            //Variables de inicio
            int num_poliza = 1;
            DateTime fecha_inicial = DateTime.Today;
            DateTime fecha_final = fecha_inicial.AddDays(5);
            string destino = "Cancun";


            PolizaViaje polizaViaje = new PolizaViaje(num_poliza, fecha_inicial,
                fecha_final, destino);
            
            var duracion_viaje = polizaViaje.CalcularDuracionViaje();
            Assert.AreEqual(duracion_viaje, 5);
        }

        [TestMethod]
        public void TestCalcularDuracionViajeIncorrect()
        {
            //Variables de inicio
            int num_poliza = 1;
            DateTime fecha_inicial = DateTime.Today.AddDays(5);
            DateTime fecha_final = DateTime.Today; ;
            string destino = "Cancun";


            PolizaViaje polizaViaje = new PolizaViaje(num_poliza, fecha_inicial, 
                fecha_final, destino);

            var duracion_viaje = polizaViaje.CalcularDuracionViaje();
            Assert.AreNotEqual(duracion_viaje, 5345);
        }

        [TestMethod]
        public void TestCalcularPolizaCorrect()
        {
            //Variables de inicio
            int num_poliza = 1;
            DateTime fecha_inicial = DateTime.Today;
            DateTime fecha_final = fecha_inicial.AddDays(5);
            string destino = "Cancun";


            PolizaViaje polizaViaje = new PolizaViaje(num_poliza, fecha_inicial,
                fecha_final, destino);

            decimal precioPoliza = polizaViaje.CalcularPoliza();
            Assert.AreEqual(precioPoliza, 1000.00m);
        }

        [TestMethod]
        public void TestCalcularPolizaInorrect()
        {
            //Variables de inicio
            int num_poliza = 1;
            DateTime fecha_inicial = DateTime.Today;
            DateTime fecha_final = fecha_inicial.AddDays(5);
            string destino = "Venezuela";


            PolizaViaje polizaViaje = new PolizaViaje(num_poliza, fecha_inicial,
                fecha_final, destino);

            decimal precioPoliza = polizaViaje.CalcularPoliza();
            Assert.AreEqual(precioPoliza, 0);
        }
    }
}