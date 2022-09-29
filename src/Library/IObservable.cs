namespace Library;

// Siguiendo el patrón observador es que surge esta interfaz
public interface IObservable
{   
    // Guardamos los observadores que puede llegar a tener un objeto de este tipo
    public List<IObserver> Observers {get;}

    // Agrega un subscriptor a recibir una notificación por el cambio que se espera manejar. 
    public void AddSubscriber(IObserver observer);

    // Elimina un subscriptor de la lista de los que querían recibir
    // una notificación por el cambio que se espera manejar. 
    public void RemoveSubscriber(IObserver observer);
    // Método encargado de revisar que subscriptores hay y notificarlos sobre el cambio previsto
    public string Notify();

}