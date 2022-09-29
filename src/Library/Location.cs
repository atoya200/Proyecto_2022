namespace Library;
public class Location
{
    public string Nombre {get; set;}
    public double Latitude {get; set;}
    public double Longitude {get; set;}

    // Crea la locación o ubicación para poder saber donde esta ese usuario en un mapa,
    // para así poder tomar decisiones en base a cuan lejos esta el trabajador del empleador. 
    public Location(string nombre, double latitude, double longitude){}

}
