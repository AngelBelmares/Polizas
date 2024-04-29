namespace Tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            PolizaVehicular vehiculo1 = new PolizaVehicular(
                1,
                new DateTime(2021, 1, 1),
                new DateTime(2022, 1, 1),
                PolizaVehicular.MarcasAuto.Honda,
                PolizaVehicular.TipoCobertura.Amplia,
                2021
            );

            PolizaInmobiliaria casa1 = new PolizaInmobiliaria(
                2,
                new DateTime(2021, 1, 1),
                new DateTime(2022, 1, 1),
                PolizaInmobiliaria.Ubicaciones.Norte,
                1000000,
                PolizaInmobiliaria.TipoCobertura.Basica
            );

            Console.WriteLine($"Costo de la poliza del vehiculo: {vehiculo1.CalcularPoliza()}");
            Console.WriteLine(vehiculo1.ObtenerInformacionVehiculo());
            Console.WriteLine($"Costo de la poliza de la vivienda: {casa1.CalcularPoliza()}");
            Console.WriteLine($"Cobertura de la vivienda de costo {casa1.ValorInmueble} en caso de daños: {casa1.CalcularCobertura()}");
        }
    }
}
