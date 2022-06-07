public class Caracteristicas
{
    private int velocidad;
    private int destreza;
    private int fuerza;
    private int nivel;
    private int armadura;

    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Destreza { get => destreza; set => destreza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public int Armadura { get => armadura; set => armadura = value; }

    
    public Caracteristicas(){
        Random random=new Random();
        Velocidad=random.Next(1,10);
        Destreza=random.Next(1,6);
        Fuerza=random.Next(1,11);
        Nivel=random.Next(1,11);
        Armadura=random.Next(1,11);
    }
}