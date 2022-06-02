namespace Full_GRASP_And_SOLID
{
    /*
    Para aplicar el principio de inversión de dependencias, definimos 
    la abstracción de la que queremos que ConsolePrinter y Recipe dependan; 
    en este caso una interfaz IRecipeContent con un método GetTextToPrint
    */
    public interface IRecipeContent
    {
        string GetTextToPrint();
    }
}