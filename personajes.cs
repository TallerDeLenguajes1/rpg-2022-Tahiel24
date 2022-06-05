public class personajes{
    //Atributos
    private int velocidad;
    private int destreza;
    private int fuerza;
    private int nivel;
    private int armadura;
    private int tipo;
    private string nombre;
    private string apodo;
    private DateOnly fechaNacimiento;
    private int edad;
    private int salud;

    //Propiedades

    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Destreza { get => destreza; set => destreza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public int Armadura { get => armadura; set => armadura = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apodo { get => apodo; set => apodo = value; }
    public DateOnly FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Salud { get => salud; set => salud = value; }
    public int Tipo { get => tipo; set => tipo = value; }

    //Constructora
    public personajes(string name, string apod, DateOnly fecNac,int tip)
    {
        Random j=new Random();
        Random k=new Random();
        Random l=new Random();
        Random m=new Random();
        Random n=new Random();
        Random o=new Random();
        int vel=j.Next(1,10);
        int des=k.Next(1,5);
        int fue=l.Next(1,10);
        int niv=m.Next(1,10);
        int arm=n.Next(1,10);
        int ed=o.Next(0,300);
        Velocidad=vel;
        Destreza=des;
        Fuerza=fue;
        Nivel=niv;
        Armadura=arm;
        Tipo=tip;
        Nombre=name;
        Apodo=apod;
        FechaNacimiento=fecNac;
        Edad=ed;
        Salud=100;
    }

    //Metodos
    public void Batallar(List<personajes>jugadores){
        Console.WriteLine("\nLa batalla da inicio: \n");
        bool ganador1=false;
        bool ganador2=false;
        int poderDisparo, efectividadDisparo, ValorAtaque,poderDefensa,maxProv=50000,danoProvocado,saludActualizada;
        
        for (int i = 0; i < 3; i++)
        {
            int indice=0;
            Console.WriteLine(".......Ronda "+(i+1)+(": .......\n"));
            foreach (personajes P in jugadores)
            {
                Console.WriteLine("Jugador "+P.Apodo+": ");
                poderDisparo=P.Destreza*P.Fuerza*P.Nivel;
                Random a=new Random();
                efectividadDisparo=a.Next(0,100);
                ValorAtaque=poderDisparo*efectividadDisparo;
                poderDefensa=P.Armadura*P.Velocidad;
                danoProvocado=(((ValorAtaque*efectividadDisparo)-poderDefensa)/maxProv)*100;
                Console.WriteLine("Daño ocasionado: "+danoProvocado);
                if(indice==0){
                    jugadores[indice+1].Salud=jugadores[indice+1].Salud-danoProvocado;
                    indice++;
                }else{
                    jugadores[indice-1].Salud-=danoProvocado;
                }
                Console.WriteLine("\n");
            }
        }
        if(jugadores[0].Salud<jugadores[1].Salud){
            ganador2=true;
        }else{
            ganador1=true;
        }

        if(ganador1){
            Console.WriteLine("El jugador "+jugadores[0].Nombre+" es el ganador");
        }else{
            Console.WriteLine("El jugador "+jugadores[1].Nombre+" es el ganador");
        }
    }
}