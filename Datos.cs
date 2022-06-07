public class Datos{
    private int tipo;
    private string nombre;
    private string apodo;
    private DateOnly fechaNacimiento;
    private int edad;
    private int salud;

    public int Tipo { get => tipo; set => tipo = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apodo { get => apodo; set => apodo = value; }
    public DateOnly FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Salud { get => salud; set => salud = value; }

    public Datos(string name, string apod, DateOnly fecNac,int tip){
        Random random=new Random();
        Tipo=tip;
        Nombre=name;
        Apodo=apod;
        FechaNacimiento=fecNac;
        Edad=random.Next(0,300);
        Salud=100;
    }
}