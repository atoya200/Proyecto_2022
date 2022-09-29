namespace Library;
public class Profile
{
    // Datos para ingresar al sistema
    protected string userName {get; set;}
    protected string password {get; set;}

    // Hacemos que el constructor sea protected porque no queremos que 
    // se creen instancias de este objeto. 
    protected  Profile(string userName, string Pasword){}
}
