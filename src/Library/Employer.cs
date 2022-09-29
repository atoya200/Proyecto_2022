namespace Library;
public class Employer: User, ISearch
{
   
    /*
     Tenemos que el constructor de la clase es el que hace el registro del usuario.
     Como los usuarios van a ser diferentes del administrador, por que van a tener datos personales
     que sirven para las funcinalidades del programa, implementamos la clase padre y en la clase hija 
     le enviamos los datos necesarios para construir el objeto. 
    */
    public  Employer(string userName, string password, string name, string lastName, string phone, Location location)
        :base(userName,password, name, lastName, phone, location)
    {}

    
    // Este método es el que permite al empleador calificar a su trabajador. 
    public void RateWorker(Worker worker, int points){}

    // Método que devulve todos las ofertas de trabajo dentro de una categoría
    public string GetWorkOffersInCategory(string nameCategory){return "";}

    /*
     Método que devulve todos las ofertas de trabajo ordenadas de 
     forma ascendente por la distancia entre el empleador y el trajador
    */
    public string GetSortWorkOffersByLocation(){return "";}

    /*
     Método que devulve todos las ofertas de trabajo ordenadas de 
     forma descendente por la puntuación del trabajador
    */
    public string GetSortWorkOffersByRating(){return "";}
}





    

