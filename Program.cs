//Librerias
using System.Text.Json;
//Declaracion de listas e instancias de las clases a utilizar
List<personajes> ListaJugadores = new List<personajes>();
List<personajes> Jug2 = new List<personajes>();
MisMetodos metodos=new MisMetodos();
Batallar batalla=new Batallar();
Random j = new Random();
//Inicio del RPG
Console.WriteLine("\nEl amanecer de una batalla legendaria se asoma en el horizonte...Alabado sea el sol");
Console.WriteLine("\n--------------------------Version Definitiva -------------------\n");
Console.WriteLine("1. Tomar guerreros inscriptos");             //Generar jugadores aleatorios
Console.WriteLine("2. Tomar copias de almas guardadas en el Vacio");       //Jugadores guardados en el JSON
Console.WriteLine("3. Salir\n");
int op = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n------------------------------------------------\n");
//Generar la cantidad aleatoria de jugadores a combatir
int cant = j.Next(2, 10);
//Generar personaje de forma aleatoria
if (op == 1)
{
    for (int i = 0; i < cant; i++)
    {
        Datos nuevoDato = new Datos();
        Caracteristicas aleatoria = new Caracteristicas();
        personajes nuevoPersonaje = new personajes(aleatoria, nuevoDato);
        ListaJugadores.Add(nuevoPersonaje);
    }
    //Serializacion de la lista de jugadores
    File.WriteAllText("jugadores.json", JsonSerializer.Serialize(ListaJugadores));
    Console.WriteLine("1. Mostrar personajes");
    Console.WriteLine("2. Iniciar batalla");
    int op2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n------------------------------------------------\n");
    if (op2 == 1)
    {
        while (op2 != 2)
        {
            metodos.MostrarDatos(ListaJugadores);
            Console.WriteLine("1. Mostrar personajes");
            Console.WriteLine("2. Iniciar batalla");
            op2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n------------------------------------------------\n");

        }
        //Combate
        batalla.BatallarNuevo(ListaJugadores);
    }
    else
    {
        //Combate
        batalla.BatallarNuevo(ListaJugadores);
    }
}
else if(op==2){
    //Deserializar para usar jugadores ya guardados
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
            metodos.MostrarDatos(ListaJugadores);
            Console.WriteLine("1. Mostrar personajes");
            Console.WriteLine("2. Iniciar batalla");
            op2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n------------------------------------------------\n");

        }
        //Combate
        batalla.BatallarNuevo(ListaJugadores);
    }
    else
    {
        //Combate
        batalla.BatallarNuevo(ListaJugadores);
    }
}else
{
    Console.WriteLine("Programa finalizado");
}






