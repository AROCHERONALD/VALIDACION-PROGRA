using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Moto : Vehiculo
    {
        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            this.CapacidadTanque = 15; // Ejemplo de capacidad del tanque para una moto
            this.ConsumoCombustible = 1; // Ejemplo de consumo de combustible para una moto
            this.VelocidadMaxima = 120; // Ejemplo de velocidad máxima para una moto
        }

        public void HacerCaballito()
        {
            if (velocidad > 0)
            {
                Console.WriteLine("¡Haciendo caballito!");
            }
            else
            {
                Console.WriteLine("No se puede hacer caballito si la moto está detenida.");
            }
        }
    }
}
