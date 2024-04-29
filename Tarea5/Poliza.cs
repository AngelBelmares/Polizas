namespace Tarea5
{
    class Poliza(int num_poliza, DateTime fecha_inicial, DateTime fecha_final)
    {
        protected int Num_poliza { get; set; } = num_poliza;
        protected DateTime Fecha_inicial { get; set; } = fecha_inicial;
        protected DateTime Fecha_final { get; set; } = fecha_final;
        protected decimal Costo { get; set; }
    }

}
