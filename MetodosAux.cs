//Clase auxiliar
public class MisMetodos
{
    //Constructora vacia
    public MisMetodos()
    {
    }

    //Metodos
    public void MostrarDatos(List<personajes> ListaJugadores)
    {
        int cont = 1;
        foreach (personajes P in ListaJugadores)
        {
            Console.WriteLine("\nJugador " + cont);
            Console.WriteLine("Nombre: " + P.Datos.Nombre);
            Console.WriteLine("Apodo: " + P.Datos.Apodo);
            Console.WriteLine("Fecha de nacimiento: " + P.Datos.FechaNacimiento);
            Console.WriteLine("Clase: " + P.Datos.Tipo);
            Console.WriteLine("\nEstadisticas: ");
            Console.WriteLine("Velocidad: " + P.Car.Velocidad);
            Console.WriteLine("Destreza: " + P.Car.Destreza);
            Console.WriteLine("Fuerza: " + P.Car.Fuerza);
            Console.WriteLine("Nivel: " + P.Car.Nivel);
            Console.WriteLine("Armadura: " + P.Car.Armadura);
            Console.WriteLine("Salud: " + P.Datos.Salud);
            Console.WriteLine("Edad: " + P.Datos.Edad);
            Console.WriteLine("\n--------------------------------------------------\n");
            cont++;
        }
    }
}