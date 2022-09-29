namespace Library;

public class CategoryCatalog: IPrintable, ISearch
{
    public string HeaderText {get; private set;}
    public string TextPrintable {get; private set;}

    /*
     La idea es hacer uso del patrón Singleton y hacer que solo exista una instancia de 
     CategoryCatalog. Así si nos referimos al catálogo de categorias solo habría un objeto,
     por ende desde que se crea sería siempre el mismo, evitando perder información entre 
     una instnacia y otra diferente, por confusión. 
    */
    private static CategoryCatalog instance; 
    public static CategoryCatalog Instance{get{return null;} set{;}} 

    
    private CategoryCatalog(){}
    // Lista de categorías en el catálogo.
    public List<Category> Categories {get; private set;}

    // Agrega una categoría al catálogo.
    public void AddCategory(Category cat){}

    // Elimina una oferta de trabajo de la categoría 
    public void RemoveCategory(Category cat){}  

    // Devuelve todas las categorías que hay en el catálogo.
    public string GetCategories(){return "";}

    // Método que devulve todos las ofertas de trabajo dentro de la categoría
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