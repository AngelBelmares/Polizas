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

            Console.WriteLine(vehiculo1.CalcularPoliza());

        }
    }
}
