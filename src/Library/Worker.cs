namespace Library;
public class Worker: User, IObserver
{
   
    /*
     Tenemos que el constructor de la clase es el que hacae el registro del usuario.
     Como los usuarios van a ser diferentes del administrador, por que van a tener datos personales
     que sirven para las funcinalidades del programa, implementamos la clase padre y en la clase hija 
     le enviamos los datos necesarios para construir el objeto. 
    */
    public  Worker(string userName, string password, string name, string lastName, string phone, Location location)
        :base(userName,password, name, lastName, phone, location)
    {}

    /*
     Este método le da la posibilidad al trabajador de crear una oferta de trabajo.
     dandole una descripción de lo que es el trabajo, un precio y una categoría. 
     También queda dicho quien ese el trabajador al que le pertenece la oferta de trabajo.
    */
    public void CreateWorkOffer(string description, int price, Worker worker, Category category){}

    // Este método es el que permite al trabajador calificar a su empleador. 
    public void RateEmployer(Employer employer, int points){}

    // Este méotodo es el que le avisa al trabajador que su oferta de trabajo fue dada de baja.
    public void Update(){}



    
}
