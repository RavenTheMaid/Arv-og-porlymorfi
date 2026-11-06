namespace Entities
{
    public class SalesPerson : Person
    {
        public SalesPerson(int id, string name, decimal yearToDateSales, List<string> itemsForSale) : base(id, name)
        {
            YearToDateSales = yearToDateSales;
            this.itemsForSale = itemsForSale;
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
        private List<string> itemsForSale = new();

        public void AddItemsForSale(string addedItem)
        {
            bool isThisAlreadyForSale = false;
            foreach(string item in itemsForSale)
            {
                if(item == addedItem)
                {
                    throw new ArgumentException("This item is already for sale");
                    isThisAlreadyForSale = true;
                    break;
                }

            }
            if (isThisAlreadyForSale != true)
            {
                itemsForSale.Add(addedItem);
            }
        }
        public override string ToString()
        {
            string allItems = "Items ";
            foreach(string item in itemsForSale)
            {
                allItems += $"{item}\n";
            }

            return $"" +
                $"{base.ToString()}\n" +
                $"YtD sales: {yearToDateSales:C2}";
        }
    }
}
