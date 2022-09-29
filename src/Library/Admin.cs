namespace Library;
public class Admin: Profile
{
    protected string userName {get; set;}
    protected string password {get; set;}

    // En este caso el constructor es público por que si queremos crear
    // instancias de esta clase.  
    public  Admin(string userName, string pasword):base(userName, pasword){}

    // Este método se encarga de crear una categoría con un nombre en particular.
    public Category CreateCategory(string name){return new Category(name);}

    // Este método se encarga de dar de baja las ofertas de trabajo cuando sea pertinente    
    public void RemoveOffer(WorkOffer workOffer){}
}
