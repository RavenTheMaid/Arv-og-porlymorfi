using Entities;

namespace Inheritance;

public class Program
{
    public static void Main()
    {
        List<string> itemsForSale = new();
        SalesPerson salesperson = new(1, "personName", 123.23m, itemsForSale);
        Customer customer = new(2, "otherPersonsName", new(2000, 1, 1), 500m);
        salesperson.AddItemsForSale("thisIsACoolItem", isThisAlreadyForSale); 
        salesperson.AddItemsForSale("thisIsAlsoACoolItem", isThisAlreadyForSale);
        Console.WriteLine(salesperson);
        Console.WriteLine(customer);
    }
}