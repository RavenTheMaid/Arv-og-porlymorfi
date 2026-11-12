using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Product : SalesUnit
    {
        public Product
            (
                string name, //goes to SalesUnit class
                DateTime timeOfCreation, //goes to SalesUnit class
                decimal price, //goes to SalesUnit class
                int amountNeededToBeSold
            )
            :base(name, timeOfCreation, price)
        {
            AmountNeededToBeSold = amountNeededToBeSold;
        }

        private int amountNeededToBeSold;
        public int AmountNeededToBeSold
        {
            get
            {
                return amountNeededToBeSold;
            }
            set
            {
                if ( value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amountNeededToBeSold), "one cannot sell negative amounts of products");
                }
                else if (value > 1000000000)
                {
                    throw new ArgumentOutOfRangeException(nameof(amountNeededToBeSold), "Why do you need to sell a billion of these?");
                }
            }
        }
        public override string ToString()
        {
            return $"" +
                $"{base.ToString()}\n" +
                $"Amount needed to be sold: {amountNeededToBeSold}\n";
        }
    }
}
