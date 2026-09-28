var manager =  new Stockmanager();
while (true)
{   Console.WriteLine("Type Add or Show or Profit or Total profit");
    string choice = Console.ReadLine()!;

    if(choice == "Add")
    
    {
        Console.Clear();
        Console.WriteLine("Enter product ID");
    int productid;
    while (!int.TryParse(Console.ReadLine(), out productid))
    {
        Console.WriteLine("Please enter a number:");
    }
    

    Console.WriteLine("Enter product name");
    string productname = Console.ReadLine()!;
    while (string.IsNullOrWhiteSpace(productname))
    {
        Console.WriteLine("Please enter with letters not numbers:");
        productname = Console.ReadLine()!;
    }

    Console.WriteLine("Enter buy in price");
    int buyinprice;
    while (!int.TryParse(Console.ReadLine(), out buyinprice))
    {
        Console.WriteLine("Please enter a number:");
    }

    Console.WriteLine("Enter selling price");
    int sellingprice;
    while (!int.TryParse(Console.ReadLine(), out sellingprice))
    {
        Console.WriteLine("Please enter a number:");
    }

    Console.WriteLine("Enter quantity");
    int quantity;
    while (!int.TryParse(Console.ReadLine(), out quantity))
    {
        Console.WriteLine("Please enter a number:");
    }

    var product = new Product(productid, productname, buyinprice, sellingprice, quantity);
    manager.AddProduct(product);
    Console.WriteLine($"{productname} added!\n");
    }

    else if(choice == "Show")
    {
        Console.Clear();
        manager.ShowProducts();
    }

    else if(choice == "Close")
    {
        
    }

    else if(choice == "Profit")
    {
        Console.Clear();
        manager.ShowProfits();
    }

    else if(choice == "Total profit")
    {
        Console.Clear();
        manager.ShowTotalProfits();
    }

    else
    {
        Console.Clear();
        Console.WriteLine("You must type 'Add' or 'Show");
        continue;
    }

    
}
