public class Datos{
    private string tipo;
    private string nombre;
    private string apodo;
    private string fechaNacimiento;
    private int edad;
    private int salud;
    private int saludInicial;
    private int cantpartidas;

    public string Tipo { get => tipo; set => tipo = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Salud { get => salud; set => salud = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apodo { get => apodo; set => apodo = value; }
    public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public int SaludInicial { get => saludInicial; set => saludInicial = value; }
    public int Cantpartidas { get => cantpartidas; set => cantpartidas = value; }

    public Datos(){
        Random random=new Random();
        string []tipos=new string[]{"Piromantico", "Caballero", "Clerigo","Perdido"};
        string[]nombres=new string[]{"Jorge", "Agustin", "Jesus", "Tahiel", "Tomas", "Ezequiel","Juan", "Pedro", "Ezequias", "Isaac"};
        string[]fechas=new string[]{"27/09/2001", "20/10/2001", "27/11/2000", "12/08/2000", "09/05/1990"};
        string[]apodos=new string[]{"Tahiel24", "PolentaConVodka", "ElSabalero","trollSupremo", "ElCuernos"};
        Nombre=nombres[random.Next(0,9)];
        FechaNacimiento=fechas[random.Next(0,4)];
        Tipo=tipos[random.Next(0,3)];
        Apodo=apodos[random.Next(0,4)];
        Edad=random.Next(0,300);
        Salud=3000;
        SaludInicial=3000;
        Cantpartidas=0;
    }
}