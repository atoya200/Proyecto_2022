namespace Library;

public class WorkOffer: IPrintable, IObservable
{
    public string HeaderText {get; private set;}
    public string TextPrintable {get; private set;}

    public string Description {get; private set;}
    public int Price {get; private set;}

    // Para saber si la oferta sigue publicada o fue dada de baja por un administrador.
    public bool IsPublished {get; private set;}

    // Trabajador que publico esta oferta
    public Worker Owner {get; private set;}

    public WorkOffer(string description, int price, Worker owner){}

    // Guardamos los observadores que puede llegar a tener un objeto de este tipo.
    public List<IObserver> Observers {get;}
    // Agrega un subscriptor a recibir una notificación por el cambio que se espera manejar. 
    public void AddSubscriber(IObserver observer){}

    // Elimina un subscriptor de la lista de los que querían recibir
    // una notificación por el cambio que se espera manejar. 
    public void RemoveSubscriber(IObserver observer){}    
    
    // Método encargado de revisar que subscriptores hay y notificarlos sobre el cambio previsto.
    public string Notify(){return "";}

    // Este método devuelve la información de la oferta de trabajo, quién la creeo, el precio y la descripción.
    public string GetInformationWorkOffer(){return "";}
}