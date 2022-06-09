Console.WriteLine("\nEl amanecer de una batalla legendaria se asoma en el horizonte...Alabado sea el sol");
Console.WriteLine("\n--------------------------Version 1 -------------------\n");
Console.WriteLine("\n1. Crear personajes");
Console.WriteLine("2. Salir\n");
int op = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n------------------------------------------------\n");
List<personajes> Players = new List<personajes>();
List<personajes> Jug2 = new List<personajes>();
Random j = new Random();
int cant = j.Next(2, 7);
if (op == 1)
{
    for (int i = 0; i < cant; i++)
    {
        Datos nuevoDato = new Datos();
        Caracteristicas aleatoria = new Caracteristicas();
        personajes nuevoPersonaje = new personajes(aleatoria, nuevoDato);
        Players.Add(nuevoPersonaje);
    }
    Console.WriteLine("1. Mostrar personajes");
    Console.WriteLine("2. Iniciar batalla");
    int op2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n------------------------------------------------\n");
    if (op2 == 1)
    {
        while (op2 != 2)
        {
            int cont = 1;
            foreach (personajes P in Players)
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
            Console.WriteLine("1. Mostrar personajes");
            Console.WriteLine("2. Iniciar batalla");
            op2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n------------------------------------------------\n");

        }
        int indice1, indice2;
        indice1 = j.Next(0, Players.Count);
        do
        {
            indice2 = j.Next(0, Players.Count);
        } while (indice1 == indice2);
        personajes Jugador1 = Players[indice1];
        personajes Jugador2 = Players[indice2];
        Batallar batalla = new Batallar();
        bool resultado = true;
        for (int i = Players.Count; i > 1; i--)
        {
            resultado = batalla.BatallarNuevo(Jugador1, Jugador2, Players);
            Console.WriteLine("\n------------------------------------------------\n");
            if (resultado)
            {
                Jugador1.Datos.Salud = Jugador1.Datos.SaludInicial;
                Players.Remove(Jugador2);
                do
                {
                    indice2 = j.Next(0, Players.Count);
                    Jugador2 = Players[indice2];
                } while (indice2 == Players.IndexOf(Jugador1) && Players.Count > 1);
                batalla.MejorarPJ(Jugador1);
            }
            else
            {
                Jugador2.Datos.Salud = Jugador2.Datos.SaludInicial;
                Players.Remove(Jugador1);
                do
                {
                    indice1 = j.Next(0, Players.Count);
                    Jugador1 = Players[indice1];
                } while (indice1 == Players.IndexOf(Jugador2) && Players.Count > 1);
                batalla.MejorarPJ(Jugador2);
            }
        }
    }
    else
    {
        int indice1, indice2;
        indice1 = j.Next(0, Players.Count);
        do
        {
            indice2 = j.Next(0, Players.Count);
        } while (indice1 == indice2);
        personajes Jugador1 = Players[indice1];
        personajes Jugador2 = Players[indice2];
        Batallar batalla = new Batallar();
        bool resultado = true;
        for (int i = Players.Count; i > 1; i--)
        {
            resultado = batalla.BatallarNuevo(Jugador1, Jugador2, Players);
            Console.WriteLine("\n------------------------------------------------\n");
            if (resultado)
            {
                Jugador1.Datos.Salud = Jugador1.Datos.SaludInicial;
                Players.Remove(Jugador2);
                do
                {
                    indice2 = j.Next(0, Players.Count);
                    Jugador2 = Players[indice2];
                } while (indice2 == Players.IndexOf(Jugador1) && Players.Count > 1);
                batalla.MejorarPJ(Jugador1);
            }
            else
            {
                Jugador2.Datos.Salud = Jugador2.Datos.SaludInicial;
                Players.Remove(Jugador1);
                do
                {
                    indice1 = j.Next(0, Players.Count);
                    Jugador1 = Players[indice1];
                } while (indice1 == Players.IndexOf(Jugador2) && Players.Count > 1);
                batalla.MejorarPJ(Jugador2);
            }
        }
    }
}
else
{
    Console.WriteLine("Programa finalizado");
}






