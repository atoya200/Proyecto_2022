namespace Library;
public class User: Profile, IPrintable
{
    public string HeaderText {get; private set;}
    public string TextPrintable {get; private set;}
    protected string userName {get; set;}
    protected string password {get; set;}
    public string Name {get; private set;}
    public string LastName {get; private set;}
    public string Phone {get; private set;}
    public Location Location {get; private set;}
    protected int countRates {get;  set;}
    protected int ratingTotal {get;  set;}

    /*
     Tenemos que el constructor de la clase es el que hacae el registro del usuario.
     Como los usuarios van a ser diferentes del administrador, por que van a tener datos personales
     que sirven para las funcinalidades del programa, implementamos la clase padre y en la clase hija 
     le enviamos los datos necesarios para construir el objeto. 
    */
    protected  User(string userName, string password, string name, string lastName, string phone, Location location)
        :base(userName,password)
    {}

    // Este método devolvería toda la información que podría verse (excluímos la contraseña y el nombre de usuario).
    // Tiene un return con un string vacío para que no marque un error de sintaxis. 
    public string GetInformatioUser(){return "";}
}
