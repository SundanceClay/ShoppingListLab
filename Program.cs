  

List<int> shoppingList = new List<int>();
Dictionary<int, ItemAndPrice> myMenu = new Dictionary<int, ItemAndPrice>()
{
    {1 ,new ItemAndPrice { Item = "apple", Price = 0.99m} },
    {2 ,new ItemAndPrice { Item = "banana", Price = 0.59m } },
    {3 ,new ItemAndPrice { Item = "cauliflower", Price = 1.59m } },
    {4 ,new ItemAndPrice { Item = "dragonfruit", Price = 2.19m } },
    {5 ,new ItemAndPrice { Item = "elderberry", Price = 1.79m} },
    {6 ,new ItemAndPrice { Item = "fig", Price = 2.09m } },
    {7 ,new ItemAndPrice { Item = "grapefruit", Price = 1.99m } },
    {8 ,new ItemAndPrice { Item = "honeydew", Price = 3.49m } }
};

Console.WriteLine("Welcome to Jake and Shawn's Market!");
foreach(var keyValuePair in myMenu)
    Console.WriteLine($"{keyValuePair.Key}     \t{keyValuePair.Value.Item} \t{keyValuePair.Value.Price}");
bool badKey = false;
do
{
    Console.Write("What item would you like to order? (enter the number) ");
    string item;
    int itemNum = int.Parse(Console.ReadLine());
    decimal value;

    if (myMenu.ContainsKey(itemNum))
    {
        item = myMenu[itemNum].Item; 
        shoppingList.Add(itemNum);
        value = myMenu[itemNum].Price;
        Console.WriteLine($"Adding { item } to cart at {value}");
        badKey = false;
    }
    else
    {
        Console.WriteLine("The item is not something we sell. ");
        badKey = true;
    }
    Console.WriteLine("Do you want to add more items to your cart? Y or n");
    if (Console.ReadLine() == "y") badKey = true;
    else badKey = false;
}
while (badKey);
decimal sumItems = 0m;
decimal itemMin = 10m;
decimal itemMax = 0m;
Console.WriteLine("Thanks for your order!\nHere's what you got:");
foreach (var itemNum in shoppingList)
{
    if (myMenu[itemNum].Price < itemMin) itemMin = myMenu[itemNum].Price;
    if (myMenu[itemNum].Price > itemMax) itemMax = myMenu[itemNum].Price;
    sumItems += myMenu[itemNum].Price;
    Console.WriteLine($"{myMenu[itemNum].Item} \t{myMenu[itemNum].Price} ");
    
}
Console.WriteLine($"Your total for all items is: ${sumItems}");
Console.WriteLine($"The least expensive item costs ${itemMin} and\nthe most expensive item costs ${itemMax}.");

