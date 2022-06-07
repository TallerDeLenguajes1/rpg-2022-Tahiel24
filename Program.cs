Console.WriteLine("\nEl amanecer de una batalla legendaria se asoma en el horizonte...Alabado sea el sol");
Console.WriteLine("\n--------------------------Version 1 -------------------\n");
Console.WriteLine("Cantidad de personas a jugar: ");
int cant = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n1. Crear personajes");
Console.WriteLine("2. Salir\n");
int op = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n------------------------------------------------\n");
List<personajes> Players = new List<personajes>();
List<personajes> Jug2 = new List<personajes>();
if (op == 1)
{
    for (int i = 0; i < cant; i++)
    {
        Console.WriteLine("Player " + (i + 1) + ": ");
        Console.WriteLine("Nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("\nApodo: ");
        string apodo = Console.ReadLine();
        Console.WriteLine("\nFecha de nacimiento: ");
        DateOnly fecha = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("\nElija su clase: ");
        Console.WriteLine("1. Piromantico");
        Console.WriteLine("2. Ladron");
        Console.WriteLine("3. Clerigo");
        Console.WriteLine("4. Caballero");
        int tipo = Convert.ToInt32(Console.ReadLine());
        Datos nuevoDato = new Datos(nombre, apodo, fecha, tipo);
        Caracteristicas aleatoria = new Caracteristicas();
        personajes nuevoPersonaje = new personajes(aleatoria, nuevoDato);
        Players.Add(nuevoPersonaje);
        Console.WriteLine("\n------------------------------------------------\n");
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
                switch (P.Datos.Tipo)
                {
                    case 1:
                        Console.WriteLine("Clase: Piromantico");
                        break;
                    case 2:
                        Console.WriteLine("Clase: Ladron");
                        break;
                    case 3:
                        Console.WriteLine("Clase: Clerigo");
                        break;
                    case 4:
                        Console.WriteLine("Clase: Caballero");
                        break;
                }
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
        Console.WriteLine("Seleccione los jugadores que combatiran: ");
        int aux = 1, play1, play2;
        foreach (personajes P in Players)
        {
            Console.WriteLine(aux + ". " + P.Datos.Apodo);
            aux++;
        }
        Console.WriteLine("\n");
        play1 = Convert.ToInt32(Console.ReadLine());
        play2 = Convert.ToInt32(Console.ReadLine());
        Jug2.Add(Players[play1 - 1]);
        Jug2.Add(Players[play2 - 1]);
        Batallar batalla = new Batallar();
        batalla.BatallarNuevo(Jug2);
    }
    else
    {
        Console.WriteLine("Seleccione los jugadores que combatiran: ");
        int aux = 1, play1, play2;
        foreach (personajes P in Players)
        {
            Console.WriteLine(aux + ". " + P.Datos.Apodo);
            aux++;
        }
        Console.WriteLine("\n");
        play1 = Convert.ToInt32(Console.ReadLine());
        play2 = Convert.ToInt32(Console.ReadLine());
        Jug2.Add(Players[play1 - 1]);
        Jug2.Add(Players[play2 - 1]);
        Random random = new Random();
        int ind1;
        while (Players.Count >1)
        {

            Batallar batalla = new Batallar();
            int indice = batalla.BatallarNuevo(Jug2);
            if (indice == 1)
            {
                Jug2.Remove(Players[play1 - 1]);
                Players.Remove(Players[play1 - 1]);
            }
            else
            {
                Jug2.Remove(Players[play2 - 1]);
                Players.Remove(Players[play2 - 1]);

            }
            if (Players.Count < 2)
            {
                Console.WriteLine("\n------------------------------------------------\n");
                Console.WriteLine("Inicia el siguiente combate: n");
                ind1 = random.Next(0, Players.Count);
                Jug2.Add(Players[ind1]);
            }
        }

    }
}
else
{
    Console.WriteLine("Programa finalizado");
}






