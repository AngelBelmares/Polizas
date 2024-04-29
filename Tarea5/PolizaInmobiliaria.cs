namespace Tarea5
{
    class PolizaInmobiliaria : Poliza
    {
        public enum Ubicaciones
        {
            Norte,
            Sur,
            Este,
            Oeste,
            Centro
        }
        public enum TipoCobertura
        {
            Basica,
            Ampliada,
            TodoRiesgo
        }

        private Dictionary<Ubicaciones, decimal> costoPorUbicacion = new Dictionary<Ubicaciones, decimal>()
        {
            { Ubicaciones.Norte, 0.8m },
            { Ubicaciones.Sur, 0.7m },
            { Ubicaciones.Este, 0.9m },
            { Ubicaciones.Oeste, 0.9m },
            { Ubicaciones.Centro, 1.2m }
        };

        private Dictionary<TipoCobertura, decimal> coberturaPorcentaje = new Dictionary<TipoCobertura, decimal>()
        {
            { TipoCobertura.Basica, 0.75m },    // La cobertura básica cubre el 75% del valor total
            { TipoCobertura.Ampliada, 0.90m },  // La cobertura ampliada cubre el 90% del valor total
            { TipoCobertura.TodoRiesgo, 1.0m }  // La cobertura todo riesgo cubre el 100% del valor total
        };


        private Ubicaciones Ubicacion { get; set; }
        public decimal ValorInmueble { get; private set; }
        private TipoCobertura Cobertura { get; set; }

        public PolizaInmobiliaria(int num_poliza, DateTime fecha_inicial, DateTime fecha_final, Ubicaciones Ubicacion, decimal ValorInmueble, TipoCobertura Cobertura)
            : base(num_poliza, fecha_inicial, fecha_final)
        {
            this.Ubicacion = Ubicacion;
            this.ValorInmueble = ValorInmueble;
            this.Cobertura = Cobertura;
        }


        public decimal CalcularPoliza()
        {
            if (!costoPorUbicacion.TryGetValue(Ubicacion, out decimal costoUbicacion))
                throw new ArgumentException("La ubicación especificada no tiene un costo asociado.");

            return ValorInmueble * 0.02m + costoUbicacion;
        }

        public decimal CalcularCobertura()
        {
            if (!coberturaPorcentaje.TryGetValue(Cobertura, out decimal porcentajeCobertura))
                throw new ArgumentException("El tipo de cobertura especificado no tiene un porcentaje asociado.");

            return ValorInmueble * porcentajeCobertura;
        }

    }
}
