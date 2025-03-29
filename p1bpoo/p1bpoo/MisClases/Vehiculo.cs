using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }
        protected int velocidad = 0;
        protected int VelocidadMaxima { get; set; }
        protected int CapacidadTanque { get; set; }
        protected int ConsumoCombustible { get; set; }

        //Tipo de licencia
        protected List<string> TiposLicenciaAceptada = new List<string> { "A", "B", "C" };
        private chofer piloto = null;
        private int estadoVehiculo = 0; //0 = apagado, 1 = encendido, 2 = en movimiento

        //Agregar el metodo de asignar piloto
        public string AsignarPiloto(chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (!TiposLicenciaAceptada.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene la licencia adecuada";
            }
            if (piloto != null)
            {
                return "El vehiculo ya tiene un piloto asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado exitosamente";
        }

        public string Encender()
        {
            if (piloto == null)
            {
                return "No se puede encender el vehiculo sin un piloto asignado";
            }
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                return "Vehiculo encendido";
            }
            return "El carro ya esta encendido";
        }

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
            Console.WriteLine("Velocidad actual: {0} km/h", this.velocidad);
            Console.WriteLine("Velocidad máxima: {0} km/h", this.VelocidadMaxima);
            Console.WriteLine("Estado del vehículo: {0}", this.estadoVehiculo == 0 ? "apagado" : this.estadoVehiculo == 1 ? "encendido" : "en movimiento");
            Console.WriteLine("Piloto asignado: {0}", this.piloto != null ? this.piloto.Nombre : "Ninguno");
        }

        public virtual void acelerar(int cuanto)
        {
            if (estadoVehiculo != 1)
            {
                Console.WriteLine("No se puede acelerar si el carro está apagado");
                return;
            }

            if (velocidad + cuanto > VelocidadMaxima)
            {
                Console.WriteLine("¡Alerta! No se puede superar la velocidad máxima de {0} km/h.", VelocidadMaxima);
                return;
            }

            velocidad += cuanto;
            Console.WriteLine("Vas a {0} km/h", velocidad);
        }

        public void Frenar(int cuanto)
        {
            if (velocidad - cuanto <= 0)
            {
                velocidad = 0;
                estadoVehiculo = 1; // encendido
                Console.WriteLine("El vehículo se ha detenido y está encendido.");
            }
            else
            {
                velocidad -= cuanto;
                Console.WriteLine("Vas a {0} km/h", velocidad);
            }
        }

        public void Apagar()
        {
            if (velocidad > 0)
            {
                Console.WriteLine("No se puede apagar el vehículo en movimiento.");
                return;
            }

            estadoVehiculo = 0; // apagado
            Console.WriteLine("El vehículo se ha apagado.");
        }
    }
}
