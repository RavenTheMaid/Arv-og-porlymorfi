using Entities;

namespace Inheritance;

public class Program
{
    public static void Main()
    {
        try
        {
            Dictionary<string, decimal> itemsForSale = new();
            SalesPerson salesperson = new(1, "personName", new(1992, 9, 11), "Mrs", "Sales Person", new(2004,4,10), 10000m, 123.23m, itemsForSale);
            Customer customer = new(2, "otherPersonsName", new(1990, 11, 9), "Mrs", new(2000, 1, 1), 500m);
            salesperson.AddProductForSale("thisIsACoolItem", 30m);
            salesperson.AddProductForSale("thisIsAlsoACoolItem", 300m);
            Console.WriteLine(salesperson);
            Console.WriteLine(customer);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}