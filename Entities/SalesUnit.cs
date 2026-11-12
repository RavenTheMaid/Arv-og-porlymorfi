using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SalesUnit
    {
        public SalesUnit(string name, DateTime timeOfCreation, decimal price)
        {
            Name = name;
            TimeOfCreation = timeOfCreation;
            Price = price;
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
        private DateTime timeOfCreation;
        public DateTime TimeOfCreation
        {
            get
            {
                return timeOfCreation;
            }
            set
            {
                if (value < DateTime.Today.AddYears(-50))
                {
                    throw new ArgumentOutOfRangeException(nameof(timeOfCreation), "Please make a product thats not over 50 years old");
                }
                else if (value > DateTime.Today.AddYears(3))
                {
                    throw new ArgumentOutOfRangeException(nameof(timeOfCreation), "Please make a product that isnt -3 years old");
                }
                timeOfCreation = value;
            }
        }
        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be at or below 0");
                }
                else if (value > 1000000000)
                {
                    throw new ArgumentOutOfRangeException(nameof(price), "stop selling to rich people");
                }
            }
        }
        public override string ToString()
        {
            return $"" +
                $"Unit name: {name}\n" +
                $"Created date: {TimeOfCreation}\n" +
                $"Price: {price}\n";
        }
    }
}
