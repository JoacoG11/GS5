using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        //Para lograr que la clase ConsolePrinter dependa de esta interfaz 
        //IRecipeContent en lugar de depender de la clase Recipe,
        //cambiando la firma del método PrintRecipe para que reciba un objeto 
        //de tipo IRecipeContent en lugar de un tipo de la clase Recipe

        //public void PrintRecipe(Recipe recipe) ELIMINADO

        //AGREGADO:
        public void PrintRecipe(IRecipeContent recipe)
        {
            //Console.WriteLine(recipe.GetTextToPrint()); ELIMINADO

            //AGREGADO:
            Console.WriteLine(recipe.GetTextToPrint()); 
        }
    }
}