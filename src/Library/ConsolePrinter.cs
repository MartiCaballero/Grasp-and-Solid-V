using System;
using Full_GRASP_And_SOLID;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeInfo recipeInfo)
        {
            string recipeText = recipeInfo.GetRecipeText();
            Console.WriteLine(recipeText);
        }
    }
}
