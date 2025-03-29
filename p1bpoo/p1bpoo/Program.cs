using p1bpoo.MisClases;

class Program
{
    static void Main(string[] args)
    {
        // Crear un chofer con licencia tipo A y edad 20
        chofer pilotoMoto = new chofer("Carlos", 20, "A");

        // Crear una moto
        Moto miMoto = new Moto(2025, "Negro", "Yamaha");

        // Asignar piloto a la moto
        string respuestaAsignacion = miMoto.AsignarPiloto(pilotoMoto);
        Console.WriteLine(respuestaAsignacion);

        // Encender la moto
        string respuestaEncender = miMoto.Encender();
        Console.WriteLine(respuestaEncender);

        // Acelerar la moto
        miMoto.acelerar(50);
        miMoto.acelerar(80); // Esto debería mostrar una alerta de velocidad máxima

        // Mostrar información de la moto
        miMoto.InformacionVehiculo();

        // Hacer caballito
        miMoto.HacerCaballito();

        // Frenar la moto
        miMoto.Frenar(50);
        miMoto.Frenar(30); // Esto debería detener la moto

        // Apagar la moto
        miMoto.Apagar();
    }
}

