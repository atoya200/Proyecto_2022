namespace Library;
public interface IPrintable
{
    /*
     Estas propieades sirven para que las clases que impriman 
     tengan a la mano el texto a imprmir sin tener que preguntar por 
     el tipo de objeto que es el que contiene el mensaje a mostrar. 
    */
    public string HeaderText {get;}
    public string TextPrintable {get; }
}