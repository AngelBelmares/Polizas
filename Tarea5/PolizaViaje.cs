using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    internal class PolizaViaje : Poliza
    {
        private string _destino;
        private Dictionary<string, decimal> destinos = new Dictionary<string, decimal>
        {
            {"Cancun", 1000.00m},
            {"Destino2", 1500.00m},
            {"Destino3", 2000.00m}
        };

        public PolizaViaje(int numPoliza, DateTime fechaInicial, DateTime fechaFinal, string destino) : base(numPoliza, fechaInicial, fechaFinal)
        {
            _destino = destino;
        }

        //Metodo 1
        public int CalcularDuracionViaje()
        {
            TimeSpan duracion = Fecha_final - Fecha_inicial;
            return duracion.Days;
        }


        //Metodo 2 
        public decimal CalcularPoliza()
        {
            if (destinos.ContainsKey(_destino))
            {
                return destinos[_destino];
            }
            else
            {
                Console.WriteLine("El destino no está disponible en la lista.");
                return 0;
            }
        }
    }
}
