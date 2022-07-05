//Librerias
using System.Net;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

public class Datos
{
    //Atributos de la clase
    private string tipo;
    private string nombre;
    private string apodo;
    private string fechaNacimiento;
    private int edad;
    private int salud;
    private int saludInicial;
    private int cantpartidas;

    //Propiedades
    public string Tipo { get => tipo; set => tipo = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Salud { get => salud; set => salud = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apodo { get => apodo; set => apodo = value; }
    public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public int SaludInicial { get => saludInicial; set => saludInicial = value; }
    public int Cantpartidas { get => cantpartidas; set => cantpartidas = value; }

    //Constructora
    public Datos()
    {
        Random random = new Random();
        string []tipos=new string[]{"Piromantico", "Caballero", "Clerigo","Perdido"};
        consumirAPI();
        Tipo=tipos[random.Next(0,3)];
        Salud = 3000;
        SaludInicial = 3000;
        Cantpartidas = 0;
    }

    //Metodo para consumir un WebService
    public void consumirAPI()
    {
        string url = @"https://api.generadordni.es/v2/profiles/person";
        var request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";
        request.ContentType = "application/json";
        request.Accept = "application/json";
        List<MisDatos> enlistarDatos=new List<MisDatos>();
        try
        {
            WebResponse response = request.GetResponse();
            Stream strReader = response.GetResponseStream();
            if (strReader == null) return;
            StreamReader objReader = new StreamReader(strReader);
            string responseBody = objReader.ReadToEnd();
            enlistarDatos = JsonSerializer.Deserialize<List<MisDatos>>(responseBody);
            Random r=new Random();
            Nombre=enlistarDatos[r.Next(0,enlistarDatos.Count)].Name;
            FechaNacimiento=enlistarDatos[r.Next(0,enlistarDatos.Count)].Birthdate;
            Apodo=enlistarDatos[r.Next(0,enlistarDatos.Count)].Username;
            Edad=enlistarDatos[r.Next(0,enlistarDatos.Count)].Age;
        }
        catch (WebException error)
        {
            Console.WriteLine("Se ha producido un error al intentar comunicarse con la API");
        }
    }
}