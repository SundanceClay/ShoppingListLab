

List<string> shoppingList = new List<string>();
Dictionary<string, decimal> myMenu = new Dictionary<string, decimal>()
{ 
    { "apple",0.99m},
    { "banana",0.59m },
    { "cauliflower",1.59m },
    { "dragonfruit",2.19m },
    { "elderberry",1.79m},
    { "fig",2.09m },
    { "grapefruit",1.99m },
    { "honeydew",3.49m }
};

Console.WriteLine("Welcome to Jake and Shawn's Market!");
foreach(var keyValuePair in myMenu)
    Console.WriteLine($"{keyValuePair.Key}     \t{keyValuePair.Value}");
bool badKey = false;
do
{
    Console.Write("What item would you like to order? ");
    string item = Console.ReadLine();
    decimal value;

    if (myMenu.ContainsKey(item))
    {
        shoppingList.Add(item);
        value = myMenu[item];
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
decimal itemMin = 10;
decimal itemMax = 0;
Console.WriteLine("Thanks for your order!\nHere's what you got:");
foreach (var item in shoppingList)
{
    if (myMenu[item] < itemMin) itemMin = myMenu[item];
    if (myMenu[item] > itemMax) itemMax = myMenu[item];
    sumItems += myMenu[item];
    Console.WriteLine($"{item} \t{myMenu[item]} ");
    
}
Console.WriteLine($"Your total for all items is: ${sumItems}");
Console.WriteLine($"The least expensive item costs ${itemMin} and\nthe most expensive item costs ${itemMax}.");

