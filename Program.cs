Console.WriteLine("\nEl amanecer de una batalla legendaria se asoma en el horizonte...Alabado sea el sol");
Console.WriteLine("\n--------------------------Version 1 -------------------\n");
Console.WriteLine("Cantidad de personas a jugar: ");
int cant =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n1. Crear personajes");
Console.WriteLine("2. Salir\n");
int op=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n------------------------------------------------\n");
List<personajes>Players=new List<personajes>();
List<personajes>Jug2=new List<personajes>();
if(op==1){
    for (int i = 0; i < cant; i++)
    {
        Console.WriteLine("Player "+(i+1)+": ");
        Console.WriteLine("Nombre: ");
        string nombre=Console.ReadLine();
        Console.WriteLine("\nApodo: ");
        string apodo=Console.ReadLine();
        Console.WriteLine("\nFecha de nacimiento: ");
        DateOnly fecha=DateOnly.Parse(Console.ReadLine()); 
        Console.WriteLine("\nElija su clase: ");
        Console.WriteLine("1. Piromantico");
        Console.WriteLine("2. Ladron");
        Console.WriteLine("3. Clerigo");
        Console.WriteLine("4. Caballero");
        int tipo=Convert.ToInt32(Console.ReadLine());
        personajes nuevoPersonaje=new personajes(nombre,apodo,fecha,tipo);
        Players.Add(nuevoPersonaje);
        Console.WriteLine("\n------------------------------------------------\n");
    }
    Console.WriteLine("1. Mostrar personajes");
    Console.WriteLine("2. Iniciar batalla");
    int op2=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n------------------------------------------------\n");
    if(op2==1){
        int cont=1;
        foreach (personajes P in Players)
        {
            Console.WriteLine("\nJugador "+cont);
            Console.WriteLine("Nombre: "+ P.Nombre);
            Console.WriteLine("Apodo: "+P.Apodo);
            Console.WriteLine("Fecha de nacimiento: "+P.FechaNacimiento);
            switch(P.Tipo){
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
            Console.WriteLine("Velocidad: "+P.Velocidad);
            Console.WriteLine("Destreza: "+P.Destreza);
            Console.WriteLine("Fuerza: "+P.Fuerza);
            Console.WriteLine("Nivel: "+P.Nivel);
            Console.WriteLine("Armadura: "+P.Armadura);
            Console.WriteLine("Salud: "+P.Salud);
            Console.WriteLine("Edad: "+P.Edad);
            Console.WriteLine("\n--------------------------------------------------\n");
            cont++;
        }
    }else{
        Console.WriteLine("Seleccione los jugadores que combatiran: ");
        int aux=1,play1,play2;
        foreach(personajes P in Players){
            Console.WriteLine(aux+". "+P.Apodo);
            aux++;
        }
        Console.WriteLine("\n");
        play1=Convert.ToInt32(Console.ReadLine());
        play2=Convert.ToInt32(Console.ReadLine());
        Jug2.Add(Players[play1-1]);
        Jug2.Add(Players[play2-1]);
        Batallar batalla=new Batallar();
        batalla.BatallarNuevo(Jug2);
    }
}else{
    Console.WriteLine("Programa finalizado");
}






