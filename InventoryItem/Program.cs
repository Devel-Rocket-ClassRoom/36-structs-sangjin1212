using System;
using System.Numerics;
Console.WriteLine("=== 인벤토리 목록 ===");
InventoryItem[] items =
    {
        new InventoryItem("검",3.5,1500),
        new InventoryItem("방패",5.0,1200),
        new InventoryItem("포션",0.3,50),
        new InventoryItem("활", 1.8,1300),
        new InventoryItem("투구", 2.0,800)
    };
double totalWeight = 0;
int totalPrice = 0;
InventoryItem MaxPrice = items[0];
InventoryItem MinWeight = items[0];
for (int i = 0; i < items.Length; i++)
{
    Console.WriteLine($"{items[i].Name} - 무게: {items[i].Weight:f1}Kg, 가격: {items[i].Price}골드");
    totalWeight += items[i].Weight;
    totalPrice += items[i].Price;
    if (items[i].Price > MaxPrice.Price)
    {
        MaxPrice = items[i];
    }
    if (items[i].Weight < MinWeight.Weight)
    {
        MinWeight = items[i];
    }
}
Console.WriteLine();
Console.WriteLine("=== 인벤토리 통계 ===");
Console.WriteLine($"전체 무게: {totalWeight:f1}Kg");
Console.WriteLine($"전체 가격: {totalPrice}골드");
Console.WriteLine($"평균 가격: {totalPrice / items.Length}골드");
Console.WriteLine($"가장 비싼 아이템: {MaxPrice.Name}");
Console.WriteLine($"가장 가벼운 아이템:{MinWeight.Name}");


struct InventoryItem
{
    public string Name;
    public double Weight;
    public int Price;

    public InventoryItem(string name, double weight, int price)
    { 
        Name = name;
        Weight = weight;
        Price = price;
    }
}
