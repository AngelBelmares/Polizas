using Tarea5;

namespace TestPolizas
{
    [TestClass]
    public class TestPolizaVehicular
    {
        [TestMethod]
        public void TestCalcularPolizaVehiculoInvalido()
        {
            PolizaVehicular vehiculoInvalido = new PolizaVehicular(
                1,
                new DateTime(2021, 1, 1),
                new DateTime(2022, 1, 1),
                PolizaVehicular.MarcasAuto.Honda,
                PolizaVehicular.TipoCobertura.Amplia,
                2025
            );

            var costo_poliza = vehiculoInvalido.CalcularPoliza();
            Assert.AreEqual(costo_poliza, 0);
        }

        [TestMethod]
        public void TestCalcularPolizaVehiculoValido()
        {
            PolizaVehicular vehiculoValido = new PolizaVehicular(
                1,
                new DateTime(2021, 1, 1),
                new DateTime(2022, 1, 1),
                PolizaVehicular.MarcasAuto.Honda,
                PolizaVehicular.TipoCobertura.Amplia,
                2021
            );

            var costo_poliza = vehiculoValido.CalcularPoliza();
            Assert.AreEqual(costo_poliza, 12100);
        }

        [TestMethod]
        public void TestObtenerInformacionVehiculoInvalido()
        {
            PolizaVehicular vehiculoInvalido = new PolizaVehicular(
                1,
                new DateTime(2021, 1, 1),
                new DateTime(2022, 1, 1),
                PolizaVehicular.MarcasAuto.Honda,
                PolizaVehicular.TipoCobertura.Amplia,
                2025
            );

            var info_vehiculo = vehiculoInvalido.ObtenerInformacionVehiculo();
            Assert.AreEqual(info_vehiculo, "Vehículo asegurado: Honda, Año:  2025, Cobertura: Amplia");
        }

        [TestMethod]
        public void TestObtenerInformacionVehiculoValido()
        {
            PolizaVehicular vehiculoValido = new PolizaVehicular(
                1,
                new DateTime(2021, 1, 1),
                new DateTime(2022, 1, 1),
                PolizaVehicular.MarcasAuto.Honda,
                PolizaVehicular.TipoCobertura.Amplia,
                2021
            );

            var info_vehiculo = vehiculoValido.ObtenerInformacionVehiculo();
            Assert.AreEqual(info_vehiculo, "Vehículo asegurado: Honda, Año:  2021, Cobertura: Amplia");
        }
    }
}
