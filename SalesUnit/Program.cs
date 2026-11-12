namespace SalesUnit
{
    public class Product
    {
        public Product (string name, DateTime dateOfCreation, decimal price, int amountNeededToBeSold)
        {

        }


        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(name), "Product name cannot be empty");
                }
                char[] characterArray = value.ToCharArray();
                foreach (char character in characterArray)
                {
                    if (char.IsNumber(character))
                    {
                        throw new ArgumentOutOfRangeException(nameof(name), "Product name cannot include numbers");
                    }
                }
                name = value;
            }
        }

    }
}
