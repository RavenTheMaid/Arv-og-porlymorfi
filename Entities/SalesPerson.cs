namespace Entities
{
    public class SalesPerson : Person
    {
        public SalesPerson(int id, string name, decimal yearToDateSales) : base(id, name)
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
    }
}
