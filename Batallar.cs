//Funcion para la batalla
public class Batallar
{
    public Batallar()
    {
    }

    public int BatallarNuevo(List<personajes> jugadores)
    {
        Console.WriteLine("\nLa batalla da inicio: \n");
        bool ganador1 = false;
        bool ganador2 = false;
        int poderDisparo, efectividadDisparo, ValorAtaque, poderDefensa, maxProv = 50000, danoProvocado, saludActualizada;

        for (int i = 0; i < 3; i++)
        {
            int indice = 0;
            Console.WriteLine(".......Ronda " + (i + 1) + (": .......\n"));
            foreach (personajes P in jugadores)
            {
                Console.WriteLine("Jugador " + P.Datos.Apodo + ": ");
                poderDisparo = P.Car.Destreza * P.Car.Fuerza * P.Car.Nivel;
                Random a = new Random();
                efectividadDisparo = a.Next(0, 100);
                ValorAtaque = poderDisparo * efectividadDisparo;
                poderDefensa = P.Car.Armadura * P.Car.Velocidad;
                danoProvocado = (((ValorAtaque * efectividadDisparo) - poderDefensa) / maxProv) * 100;
                Console.WriteLine("Daño ocasionado: " + danoProvocado);
                if (indice == 0)
                {
                    jugadores[indice + 1].Datos.Salud = jugadores[indice + 1].Datos.Salud - danoProvocado;
                    indice++;
                }
                else
                {
                    jugadores[indice - 1].Datos.Salud -= danoProvocado;
                }
                Console.WriteLine("\n");
            }
        }
        if (jugadores[0].Datos.Salud < jugadores[1].Datos.Salud)
        {
            ganador2 = true;
        }
        else
        {
            ganador1 = true;
        }

        if (ganador1)
        {
            Console.WriteLine("El jugador " + jugadores[0].Datos.Nombre + " es el ganador");
            return 1;
        }
        else
        {
            Console.WriteLine("El jugador " + jugadores[1].Datos.Nombre + " es el ganador");
            return 0;
        }

    }
}