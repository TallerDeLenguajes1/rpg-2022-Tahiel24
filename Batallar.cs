//Clase para las batallas
public class Batallar
{
    //Constructora vacia
    public Batallar()
    {
    }

    //Metodo principal
    public void BatallarNuevo(List<personajes> ListaJugadores)
    {
        //Seleccion de jugadores aleatorios iniciales para comenzar el encuentro
        Random j = new Random();
        int indice1, indice2;
        indice1 = j.Next(0, ListaJugadores.Count);
        do
        {
            indice2 = j.Next(0, ListaJugadores.Count);
        } while (indice1 == indice2);          //Con esto evitamos elegir dos jugadores iguales
        personajes jugador1 = ListaJugadores[indice1];
        personajes jugador2 = ListaJugadores[indice2];
        bool resultado = true;
        //Inicio del combate hasta que solo uno quede en pie
        for (int i = ListaJugadores.Count; i > 1; i--)
        {
            Console.WriteLine("\n||Los combatientes estan frente a frente en la gran Anor Londo, da inicio el encuentro: ||\n");
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Contienda N°: " + (k + 1));
                Console.WriteLine("**************************************");
                Ataque(jugador1, jugador2);
                Console.WriteLine("**************************************");
                Console.WriteLine("\n");
                Console.WriteLine("**************************************");
                Ataque(jugador2, jugador1);
                Console.WriteLine("**************************************");
                Console.WriteLine("\n");
            }
            if (jugador2.Datos.Salud < jugador1.Datos.Salud)
            {
                Console.WriteLine("El ganador es " + jugador1.Datos.Nombre + ", orgulloso guerrero " + jugador1.Datos.Tipo + "." + " Se le dara una botella de Estus para continuar el combate");
                Console.WriteLine("El combatiente " + jugador2.Datos.Nombre + "ha perdido. Sera arrojado al Abismo sin compasion");
                resultado = true;
            }
            else
            {
                Console.WriteLine("El ganador es el jugador " + jugador2.Datos.Nombre + "orgulloso guerrero" + jugador2.Datos.Tipo + "." + " Se le dara una botella de Estus para continuar el combate");
                Console.WriteLine("El combatiente " + jugador1.Datos.Nombre + "ha perdido. Sera arrojado al Abismo sin compasion");
                resultado = false;
            }

            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------\n");
            if (resultado)
            {
                //Colocar vida inicial para el siguiente combate
                jugador1.Datos.Salud = jugador1.Datos.SaludInicial;
                //Remover jugador perdedor
                ListaJugadores.Remove(jugador2);
                do
                {
                    indice2 = j.Next(0, ListaJugadores.Count);
                    jugador2 = ListaJugadores[indice2];
                } while (indice2 == ListaJugadores.IndexOf(jugador1) && ListaJugadores.Count > 1);
                //Mejorar stats del jugador
                MejorarPJ(jugador1);
                jugador1.Datos.Cantpartidas++;
            }
            else
            {
                //Colocar vida inicial para el siguiente combate
                jugador2.Datos.Salud = jugador2.Datos.SaludInicial;
                //Remover jugador perdedor
                ListaJugadores.Remove(jugador1);
                do
                {
                    indice1 = j.Next(0, ListaJugadores.Count);
                    jugador1 = ListaJugadores[indice1];
                } while (indice1 == ListaJugadores.IndexOf(jugador2) && ListaJugadores.Count > 1);
                //Mejorar stats del jugador
                MejorarPJ(jugador2);
                jugador2.Datos.Cantpartidas++;
            }
        }
        personajes Ganador = ListaJugadores[0];
        //Subir puntajes en el csv
        subirPuntajes(Ganador, Ganador.Datos.Cantpartidas);
        //Anunciar al ganador definitivo
        Console.WriteLine("\n");
        Console.WriteLine("|--------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                          |");
        Console.WriteLine("|                                                                          |");
        Console.WriteLine("|   Presentamos al guerrero que tendra el honor de entrar a perpetuar el   |");
        Console.WriteLine("|   sacrificio eterno para avivar el Origen  en el Horno de la Primera     |");
        Console.WriteLine("|                                Llama                                     |");
        Console.WriteLine("|            " + "Felicidades " + ListaJugadores[0].Datos.Nombre + ", lleve eternamente                          |");
        Console.WriteLine("|    con usted la bendicion del gran Gwyn,Señor de la luz solar, Rey de    |");
        Console.WriteLine("|                 Lodran y Soberano de la Era de Fuego                     |");
        Console.WriteLine("|                                                                          |");
        Console.WriteLine("|                                                                          |");
        Console.WriteLine("|--------------------------------------------------------------------------|");
        Console.WriteLine("\n");
    }

    //Metodo para medir el ataque
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

    //Metodo para mejorar el personaje despues de cada pelea
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

    //Metodo para guardar en el csv a los ganadores
    public void subirPuntajes(personajes Ganador, int cantBatallas)
    {
        List<string> cadena = new List<string>();
        string path = @"C:\TALLERDELENGUAJES1\rpg-2022-Tahiel24"; //Cambiar path segun se necesite
        cadena.Add(Ganador.Datos.Nombre + ',' + Ganador.Datos.Apodo + ',' + "Cantidad de batallas para ganar: " + cantBatallas + ',' + ',' + "Nivel al finalizar la contienda: " + Ganador.Car.Nivel + ',' + DateTime.Now);
        File.AppendAllLines(path + @"\index.csv", cadena); //Valido con WriteAllLines
    }

}

