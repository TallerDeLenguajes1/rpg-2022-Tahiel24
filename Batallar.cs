//Funcion para la batalla
public class Batallar
{
    public Batallar()
    {
    }

    public bool BatallarNuevo(personajes jugador1, personajes jugador2,List<personajes>ListaJugadores)
    {
        Console.WriteLine("\nLa batalla da inicio: \n");
        for (int i = 0; i < 3; i++)
        {
            Ataque(jugador1,jugador2);
            Ataque(jugador2,jugador1);
            Console.WriteLine("\n");
        }
        if(jugador2.Datos.Salud<jugador1.Datos.Salud){
            Console.WriteLine("El ganador es el jugador "+jugador1.Datos.Nombre);
            return true;
        }else{
            Console.WriteLine("El ganador es el jugador "+jugador2.Datos.Nombre);
            return false;
        }
    }

public void Ataque(personajes P, personajes Defensor)
{
    int poderDisparo, efectividadDisparo, ValorAtaque, poderDefensa, maxProv = 50000, danoProvocado, saludActualizada;
    Console.WriteLine("Jugador " + P.Datos.Nombre + ": ");
    Console.WriteLine("Apodo: "+P.Datos.Apodo);
    poderDisparo = P.Car.Destreza * P.Car.Fuerza * P.Car.Nivel;
    Random a = new Random();
    efectividadDisparo = a.Next(0, 100);
    ValorAtaque = poderDisparo * efectividadDisparo;
    poderDefensa = P.Car.Armadura * P.Car.Velocidad;
    danoProvocado = (((ValorAtaque * efectividadDisparo) - poderDefensa) / maxProv) * 100;
    Console.WriteLine("Daño ocasionado: " + danoProvocado);
    Defensor.Datos.Salud-=danoProvocado;
}

public void MejorarPJ(personajes P){
    P.Datos.SaludInicial+=200;
    P.Datos.Salud+=200;
    P.Car.Armadura+=2;
    P.Car.Destreza+=2;
    P.Car.Fuerza+=2;
    P.Car.Velocidad+=2;
    P.Car.Nivel+=1;
}

}

