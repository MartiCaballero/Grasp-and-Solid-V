using System.IO;
using System;
using Full_GRASP_And_SOLID;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeInfo recipeTextProvider)
        {
            string recipeText = recipeTextProvider.GetRecipeText();
            File.WriteAllText("Recipe.txt", recipeText);
        }
    }
}
