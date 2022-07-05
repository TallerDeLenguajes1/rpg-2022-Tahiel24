//Clase para crear jugadores
public class personajes{
    //Atributos
    private Datos datos;
    private Caracteristicas car;

    //Propiedades
    public Datos Datos { get => datos; set => datos = value; }
    public Caracteristicas Car { get => car; set => car = value; }
    public personajes(){
      
    }
    
    //Constructora
    public personajes(Caracteristicas carac, Datos Dat){
        Datos=Dat;
        Car=carac;
    }
}