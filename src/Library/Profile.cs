namespace Library;
public class Profile
{
    protected string userName {get; set;}
    protected string password {get; set;}

    // Hacemos que el constructor sea protected por que no queremos que 
    // se creen instancias de este objeto. 
    protected  Profile(string userName, string Pasword){}
}
