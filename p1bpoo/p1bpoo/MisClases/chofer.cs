using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class chofer : iPiloto
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        private string tipoLicencia;

        public string TipoLicencia
        {
            get { return tipoLicencia; }
            set
            {
                if ((value == "A" && Edad < 18) ||
                    (value == "B" && Edad < 21) ||
                    (value == "C" && Edad < 23))
                {
                    throw new ArgumentException("La edad no corresponde con el tipo de licencia.");
                }
                tipoLicencia = value;
            }
        }

        public chofer(string nombre, int edad, string tipoLicencia)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.TipoLicencia = tipoLicencia; // Esto llamará al setter y validará la licencia
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: {0}", this.Nombre);
            Console.WriteLine("Edad: {0}", this.Edad);
            Console.WriteLine("Tipo de licencia: {0}", this.TipoLicencia);
        }
    }
}
