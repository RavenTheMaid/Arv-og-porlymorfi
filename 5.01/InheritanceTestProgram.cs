using Entities;

namespace Inheritance;

public class Program
{
    public static void Main()
    {
        try
        {
            SalesPerson salesperson = new
                (
                    id: 1,
                    name: "personName",
                    birthDate: new(1992, 9, 11),
                    titleOfCourtesy: "Mrs",
                    jobTitle: "Sales Person",
                    dateOfEmployment: new(2004, 4, 10),
                    anualSalary: 10000m,
                    yearToDateSales: 1230.23m
                );
            
            Customer customer = new
                (
                    id: 2,
                    name: "otherPersonsName",
                    birthDate: new(1990, 11, 9),
                    titleOfCourtesy: "Mrs",
                    becameCustomer: new(2000, 1, 1),
                    totalMoneySpent: 500m
                );

            Product product = new
                (
                    name: "beaaannss", 
                    timeOfCreation: new(2008, 8, 15), 
                    price: 10,
                    amountNeededToBeSold: 1320
                );

            Service service = new
                (
                    name: "Necromancy coaching", 
                    timeOfCreation: new(1990, 10, 31), 
                    price: 50000m, 
                    description: "stuff", 
                    startOfService: new(2000, 1, 1), 
                    durationOfService: new(30,0,0,0)
                );

            salesperson.AddProductForSale("thisIsACoolItem", 30m);
            salesperson.AddProductForSale("thisIsAlsoACoolItem", 300m);
            
            Console.WriteLine(salesperson);
            Console.WriteLine(customer);
            Console.WriteLine(product);
            Console.WriteLine(service);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}