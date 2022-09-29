namespace Library;
public class Category: ISearch, IPrintable
{
    public string HeaderText {get; private set;}
    public string TextPrintable {get; private set;}

    public string Name {get; private set;}
    // Lista de ofertas de trabajos de esa categoría.
    public List<WorkOffer> WorkOffers {get; private set;}

    public Category(string name){}


    // Agrega una oferta de trabajo a la categoría. 
    public void AddWorkOffer(WorkOffer workOffer){}

    // Elimina una oferta de trabajo de la categoría 
    public void RemoveWorkOffer(WorkOffer workOffer){}    

    // Método que devulve todos las ofertas de trabajo dentro de la categoría
    // Devulve un string vacío para que en estos momentos no de un error. 
    public string GetWorkOffersInCategory(string nameCategory){return "";}

    /*
     Método que devulve todos las ofertas de trabajo ordenadas de 
     forma ascendente por la distancia entre el empleador y el trajador.
     Devulve un string vacío para que en estos momentos no de un error. 
    */
    public string GetSortWorkOffersByLocation(){return "";}

    /*
     Método que devulve todos las ofertas de trabajo ordenadas de 
     forma descendente por la puntuación del trabajador.
     Devulve un string vacío para que en estos momentos no de un error. 
    */
    public string GetSortWorkOffersByRating(){return "";}
}