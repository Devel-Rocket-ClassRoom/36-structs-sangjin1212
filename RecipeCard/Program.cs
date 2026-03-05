using System;
IngredIent[] ingreds =
    {
        new IngredIent("스파게티면",200,"g"),
        new IngredIent("토마토소스",150,"ml"),
        new IngredIent("양파",1,"개"),
        new IngredIent("양파", 3,"쪽"),
    };


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
    public RecipeCard(string name, int servings, IngredIent[] ingredIents)
    { 
        Name = name;
        Servings = servings;
        Ingredients = ingredIents;
    }
    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료: ");

    }
}