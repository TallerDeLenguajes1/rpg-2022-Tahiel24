public class personajes{
    private Datos datos;
    private Caracteristicas car;

    public Datos Datos { get => datos; set => datos = value; }
    public Caracteristicas Car { get => car; set => car = value; }

    public personajes(Caracteristicas carac, Datos Dat){
        Datos=Dat;
        Car=carac;
    }
}