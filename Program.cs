using System.Text.Json;

Console.WriteLine("\nEl amanecer de una batalla legendaria se asoma en el horizonte...Alabado sea el sol");
Console.WriteLine("\n--------------------------Version 1 -------------------\n");
Console.WriteLine("1. Crear personajes(Aleatorio)");
Console.WriteLine("2. Leer personaje guardado");
Console.WriteLine("3. Salir\n");
int op = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n------------------------------------------------\n");
List<personajes> ListaJugadores = new List<personajes>();
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
        ListaJugadores.Add(nuevoPersonaje);
    }
    File.WriteAllText("jugadores.json", JsonSerializer.Serialize(ListaJugadores));
    Console.WriteLine("1. Mostrar personajes");
    Console.WriteLine("2. Iniciar batalla");
    int op2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n------------------------------------------------\n");
    if (op2 == 1)
    {
        while (op2 != 2)
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
            Console.WriteLine("1. Mostrar personajes");
            Console.WriteLine("2. Iniciar batalla");
            op2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n------------------------------------------------\n");

        }
        Batallar batalla=new Batallar();
        batalla.BatallarNuevo(ListaJugadores);
    }
    else
    {
        Batallar batalla=new Batallar();
        batalla.BatallarNuevo(ListaJugadores);
    }
}
else if(op==2){
    string filename="jugadores.json";
    string jsonJugadores2=File.ReadAllText(filename);

    ListaJugadores=JsonSerializer.Deserialize<List<personajes>>(jsonJugadores2);
    Console.WriteLine("1. Mostrar personajes");
    Console.WriteLine("2. Iniciar batalla");
    int op2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n------------------------------------------------\n");
    if (op2 == 1)
    {
        while (op2 != 2)
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
            Console.WriteLine("1. Mostrar personajes");
            Console.WriteLine("2. Iniciar batalla");
            op2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n------------------------------------------------\n");

        }
        Batallar batalla=new Batallar();
        batalla.BatallarNuevo(ListaJugadores);
    }
    else
    {
        Batallar batalla=new Batallar();
        batalla.BatallarNuevo(ListaJugadores);
    }
}else
{
    Console.WriteLine("Programa finalizado");
}






