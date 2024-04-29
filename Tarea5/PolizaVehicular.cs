namespace Tarea5
{
    class PolizaVehicular : Poliza
    {
        public enum MarcasAuto
        {
            Toyota,
            Ford,
            Chevrolet,
            Honda,
            BMW
        }

        public enum TipoCobertura
        {
            RC,         // Responsabilidad civil
            Limitada,
            Amplia
        }

        private Dictionary<int, double> costoPorAnio = new Dictionary<int, double>()
        {
            { 2000, 3000 },
            { 2001, 3100 },
            { 2002, 3200 },
            { 2003, 3300 },
            { 2004, 3400 },
            { 2005, 3500 },
            { 2006, 3600 },
            { 2007, 3700 },
            { 2008, 3800 },
            { 2009, 3900 },
            { 2010, 4000 },
            { 2011, 4100 },
            { 2012, 4200 },
            { 2013, 4300 },
            { 2014, 4400 },
            { 2015, 4500 },
            { 2016, 4600 },
            { 2017, 4700 },
            { 2018, 4800 },
            { 2019, 4900 },
            { 2020, 5000 },
            { 2021, 5100 },
            { 2022, 5200 },
            { 2023, 5300 },
            { 2024, 5400 }
        };

        private Dictionary<MarcasAuto, double> costoPorMarca = new Dictionary<MarcasAuto, double>()
        {
            { MarcasAuto.Toyota, 1000 },
            { MarcasAuto.Ford, 2000 },
            { MarcasAuto.Chevrolet, 3000 },
            { MarcasAuto.Honda, 4000 },
            { MarcasAuto.BMW, 5000 }
        };

        private Dictionary<TipoCobertura, double> costoPorCobertura = new Dictionary<TipoCobertura, double>()
        {
            { TipoCobertura.RC, 1000 },
            { TipoCobertura.Limitada, 2000 },
            { TipoCobertura.Amplia, 3000 }
        };

        private MarcasAuto MarcaAuto { get; set; }
        private int Anio { get; set; }
        private TipoCobertura Cobertura { get; set; }

        public PolizaVehicular(int num_poliza, DateTime fecha_inicial, DateTime fecha_final, MarcasAuto MarcaAuto, TipoCobertura Cobertura, int Anio)
            : base(num_poliza, fecha_inicial, fecha_final)
        {
            this.MarcaAuto = MarcaAuto;
            this.Anio = Anio;
            this.Cobertura = Cobertura;
        }

        public decimal CalcularPoliza()
        {
            if (!costoPorAnio.TryGetValue(Anio, out double costoAnio))
                throw new ArgumentException("El año especificado no tiene un costo asociado.");

            if (!costoPorMarca.TryGetValue(MarcaAuto, out double costoMarca))
                throw new ArgumentException("La marca de auto especificada no tiene un costo asociado.");

            if (!costoPorCobertura.TryGetValue(Cobertura, out double costoCobertura))
                throw new ArgumentException("El tipo de cobertura especificado no tiene un costo asociado.");

            return (decimal)(costoAnio + costoMarca + costoCobertura);
        }

        public string ObtenerInformacionVehiculo()
        {
            return $"Vehículo asegurado: {MarcaAuto}, Año:  {Anio}, Cobertura: {Cobertura}";
        }
    }
}
