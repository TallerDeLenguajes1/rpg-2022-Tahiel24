//Funcion para la batalla
public class Batallar
{
    public Batallar()
    {
    }

    public void BatallarNuevo(List<personajes> ListaJugadores)
    {
        Random j = new Random();
        int indice1, indice2;
        indice1 = j.Next(0, ListaJugadores.Count);
        do
        {
            indice2 = j.Next(0, ListaJugadores.Count);
        } while (indice1 == indice2);
        personajes jugador1 = ListaJugadores[indice1];
        personajes jugador2 = ListaJugadores[indice2];
        bool resultado = true;
        for (int i = ListaJugadores.Count; i > 1; i--)
        {
            Console.WriteLine("\nLa batalla da inicio: \n");
            for (int k = 0; k < 3; k++)
            {
                Ataque(jugador1, jugador2);
                Ataque(jugador2, jugador1);
                Console.WriteLine("\n");
            }
            if (jugador2.Datos.Salud < jugador1.Datos.Salud)
            {
                Console.WriteLine("El ganador es el jugador " + jugador1.Datos.Nombre);
                resultado = true;
            }
            else
            {
                Console.WriteLine("El ganador es el jugador " + jugador2.Datos.Nombre);
                resultado = false;
            }

            Console.WriteLine("\n------------------------------------------------\n");
            if (resultado)
            {
                jugador1.Datos.Salud = jugador1.Datos.SaludInicial;
                ListaJugadores.Remove(jugador2);
                do
                {
                    indice2 = j.Next(0, ListaJugadores.Count);
                    jugador2 = ListaJugadores[indice2];
                } while (indice2 == ListaJugadores.IndexOf(jugador1) && ListaJugadores.Count > 1);
                MejorarPJ(jugador1);
                jugador1.Datos.Cantpartidas++;
            }
            else
            {
                jugador2.Datos.Salud = jugador2.Datos.SaludInicial;
                ListaJugadores.Remove(jugador1);
                do
                {
                    indice1 = j.Next(0, ListaJugadores.Count);
                    jugador1 = ListaJugadores[indice1];
                } while (indice1 == ListaJugadores.IndexOf(jugador2) && ListaJugadores.Count > 1);
                MejorarPJ(jugador2);
                jugador2.Datos.Cantpartidas++;
            }
        }
        personajes Ganador = ListaJugadores[0];
        subirPuntajes(Ganador, Ganador.Datos.Cantpartidas);
    }

    public void Ataque(personajes P, personajes Defensor)
    {
        int poderDisparo, efectividadDisparo, ValorAtaque, poderDefensa, maxProv = 50000, danoProvocado;
        Console.WriteLine("Jugador " + P.Datos.Nombre + ": ");
        Console.WriteLine("Apodo: " + P.Datos.Apodo);
        poderDisparo = P.Car.Destreza * P.Car.Fuerza * P.Car.Nivel;
        Random a = new Random();
        efectividadDisparo = a.Next(0, 100);
        ValorAtaque = poderDisparo * efectividadDisparo;
        poderDefensa = P.Car.Armadura * P.Car.Velocidad;
        danoProvocado = (((ValorAtaque * efectividadDisparo) - poderDefensa) / maxProv) * 100;
        Console.WriteLine("Daño ocasionado: " + danoProvocado);
        Defensor.Datos.Salud -= danoProvocado;
    }

    public void MejorarPJ(personajes P)
    {
        P.Datos.SaludInicial += 200;
        P.Datos.Salud += 200;
        P.Car.Armadura += 2;
        P.Car.Destreza += 2;
        P.Car.Fuerza += 2;
        P.Car.Velocidad += 2;
        P.Car.Nivel += 1;
    }

    public void subirPuntajes(personajes Ganador, int cantBatallas)
    {
        List<string> cadena = new List<string>();
        string path = @"C:\TALLERDELENGUAJES1\rpg-2022-Tahiel24"; //Cambiar path segun se necesite
        cadena.Add(Ganador.Datos.Nombre + ',' + Ganador.Datos.Apodo + ',' + "Cantidad de batallas para ganar: " + cantBatallas + ',' + ',' + "Nivel al finalizar la contienda: " + Ganador.Car.Nivel + ',' + DateTime.Now);
        File.WriteAllLines(path + @"\index.csv", cadena);
    }

}

