public class Stockmanager
{
    List<Product> Items = new List<Product>();
    
    public void AddProduct(Product product)
    {
        Items.Add(product);
    }

    public void ShowProducts()
    {
        Console.WriteLine("Current products:\n");
        foreach(Product p in Items)
        {
            Console.WriteLine($"ID: {p.ProductID}\n Item: {p.ProductName}\n Buyin price: {p.BuyInPrice}kr\n Selling price: {p.SellingPrice}kr\n Quantity: {p.Quantity}st \n\n");
        }
    }

    public void ShowProfits()
    {
        foreach (Product p in Items)
        {
            Console.WriteLine($"{p.ProductName}: {p.GetSaleProfit()}kr vinst per st");
        }
    }

    public void ShowTotalProfits()
    {
        int total = 0;
        foreach (Product p in Items)
        {
           total += p.GetSaleProfit() * p.Quantity;
        }
        Console.WriteLine($"Total möjlig vinst: {total}kr");
    }
}

public class Product
{
    public int ProductID {get; set;}
    public string ProductName {get; set;}

    public int BuyInPrice {get; set;}
    public int SellingPrice {get; set;}
    public int Quantity {get; set;}

    public Product(int productid, string productname, int buyinprice, int sellingprice, int quantity)
    {
        ProductID = productid;
        ProductName = productname;
        BuyInPrice = buyinprice;
        SellingPrice = sellingprice;
        Quantity = quantity;


        
    }
    public StockStatus GetStockStatus()
    {
        if( Quantity == 0) return StockStatus.OutofStock;
        if (Quantity <= 2) return StockStatus.LowStock;
        return StockStatus.Instock;

    

    }

    public int GetSaleProfit()
    {
        return SellingPrice - BuyInPrice;

    }
    

}