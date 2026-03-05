using System;
Console.WriteLine("=== 원본 레시피 ===");
IngredIent[] ingreds =
    {
        new IngredIent("스파게티면",200,"g"),
        new IngredIent("토마토소스",150,"ml"),
        new IngredIent("양파",1,"개"),
        new IngredIent("마늘", 3,"쪽"),
    };
RecipeCard recipe = new RecipeCard("토마토 파스타",2, ingreds);
recipe.PrintRecipe();
Console.WriteLine();
Console.WriteLine("=== 4인분으로 변환 ===");
recipe.ScaleRecipe(2);
struct IngredIent
{
    public string Name;
    public double Amount;
    public string Unit;

    public IngredIent(string name, double amount, string unit)
    { 
        Name = name;
        Amount = amount;
        Unit = unit;
    }
}
struct RecipeCard
{
    public string Name;
    public int Servings;
    public IngredIent[] Ingredients;
    public RecipeCard(string name, int servings, IngredIent[] ingreds)
    { 
        Name = name;
        Servings = servings;
        Ingredients = ingreds;
    }
    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료:");
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Console.WriteLine($"- {Ingredients[i].Name}: {Ingredients[i].Amount}{Ingredients[i].Unit}");
        }
    }
    public void ScaleRecipe(int newServings)
    {
        Console.WriteLine($"[{Name}] ({Servings * newServings}인분)");
        Console.WriteLine("재료:");
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Console.WriteLine($"- {Ingredients[i].Name}: {Ingredients[i].Amount * newServings}{Ingredients[i].Unit}");
        }
    }
}