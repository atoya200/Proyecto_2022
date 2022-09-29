namespace Library;
public interface ISearch
{
    // Método que devulve todos las ofertas de trabajo dentro de una categoría
    public string GetWorkOffersInCategory(string nameCategory );

    /*
     Método que devulve todos las ofertas de trabajo ordenadas de 
     forma ascendente por la distancia entre el empleador y el trajador
    */
    public string GetSortWorkOffersByLocation();

    /*
     Método que devulve todos las ofertas de trabajo ordenadas de 
     forma descendente por la puntuación del trabajador
    */
    public string GetSortWorkOffersByRating();
}