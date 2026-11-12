namespace Entities
{
    public class SalesPerson : Employee
    {
        public SalesPerson
        (
            int id,//this goes to person class
            string name,//this goes to person class
            DateTime birthDate, //this goes to person class
            string titleOfCourtesy,//this goes to person class
            string jobTitle, //goes to employee class
            DateTime dateOfEmployment, //goes to employee class
            decimal anualSalary, //goes to employee class
            decimal yearToDateSales
        ) 
            :base(id, name, birthDate, titleOfCourtesy, jobTitle, dateOfEmployment, anualSalary)
        {
            YearToDateSales = yearToDateSales;
        }
        private decimal yearToDateSales;
        public decimal YearToDateSales
        {
            get
            {
                return yearToDateSales;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "A sale cannot be negative");
                }
                else if (value != yearToDateSales)
                {
                    yearToDateSales = value;
                }
            }
        }
        private Dictionary<string, decimal> productsForSale = new();

        public void AddProductForSale(string addedProduct, decimal price)
        {
            bool isThisAlreadyForSale = false;
            foreach(string product in productsForSale.Keys)
            {
                if(product == addedProduct)
                {
                    isThisAlreadyForSale = true;
                    throw new ArgumentException("This item is already for sale");
                }

            }
            if (isThisAlreadyForSale != true)
            {
                productsForSale.Add(addedProduct, price);
            }
        }
        public decimal procentAnualSold()
        {
            return Math.Round(yearToDateSales / AnualSalary * 100, 2);
        }

        public override string ToString()
        {
            string allProducts = "";
            foreach(string product in productsForSale.Keys)
            {
                try
                {
                productsForSale.TryGetValue(product, out decimal price);
                allProducts += $"{product}: {price:c2}\n";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            return $"" +
                $"{base.ToString()}\n" +
                $"YtD sales: {yearToDateSales:C2}\n" +
                $"Procent of anual salary sold: {procentAnualSold()}%\n\n" +
                $"Products for sale\n" +
                $"{allProducts}\n";
        }
    }
}
