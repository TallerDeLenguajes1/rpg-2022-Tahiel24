//Libreria para serializar
using System.Text.Json.Serialization;

//Clase para tomar los datos que provienen del json de la API
public class MisDatos
{
    public MisDatos()
    {
    }
    
    [JsonPropertyName("nif")]
    public string Nif { get; set; }

    [JsonPropertyName("nie")]
    public string Nie { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("surname")]
    public string Surname { get; set; }

    [JsonPropertyName("surnname2")]
    public string Surnname2 { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }

    [JsonPropertyName("fullname")]
    public string Fullname { get; set; }

    [JsonPropertyName("birthdate")]
    public string Birthdate { get; set; }

    [JsonPropertyName("age")]
    public int Age { get; set; }

    [JsonPropertyName("phonenumber")]
    public string Phonenumber { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; }

    [JsonPropertyName("municipality")]
    public string Municipality { get; set; }

    [JsonPropertyName("municipality_inecode")]
    public string MunicipalityInecode { get; set; }

    [JsonPropertyName("province")]
    public string Province { get; set; }

    [JsonPropertyName("province_inecode")]
    public string ProvinceInecode { get; set; }

    [JsonPropertyName("address")]
    public string Address { get; set; }

    [JsonPropertyName("address_number")]
    public string AddressNumber { get; set; }

    [JsonPropertyName("address_zipcode")]
    public string AddressZipcode { get; set; }

    [JsonPropertyName("iban")]
    public string Iban { get; set; }

    [JsonPropertyName("bic")]
    public string Bic { get; set; }

    [JsonPropertyName("card_number")]
    public string CardNumber { get; set; }

    [JsonPropertyName("card_expiration_date")]
    public string CardExpirationDate { get; set; }

    [JsonPropertyName("card_cvc")]
    public string CardCvc { get; set; }

    [JsonPropertyName("ssn")]
    public string Ssn { get; set; }

    [JsonPropertyName("passport")]
    public string Passport { get; set; }

    
}