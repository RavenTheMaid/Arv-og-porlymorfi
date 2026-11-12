using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Customer : Person
    {
        public Customer
        (
            int id, //this goes to person class
            string name, //this goes to person class
            DateTime birthDate, //this goes to person class
            string titleOfCourtesy, //this goes to person class
            DateTime becameCustomer, 
            decimal totalMoneySpent
        ) 
            :base(id, name, birthDate, titleOfCourtesy)
        {
            BecameCustomer = becameCustomer;
            TotalMoneySpent = totalMoneySpent;
        }
        private DateTime becameCustomer;
        public DateTime BecameCustomer
        {
            get
            {
                return becameCustomer;
            }
            set
            {
                if (value < DateTime.Today.AddYears(-100))
                {
                    throw new ArgumentOutOfRangeException(nameof(becameCustomer), "You are not over 100 years old cause i say so");
                }
                becameCustomer = value;
            }
        }

        private decimal totalMoneySpent;
        public decimal TotalMoneySpent
        {
            get
            {
                return totalMoneySpent;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(totalMoneySpent), "i dont feel like i owe any money");
                }
                totalMoneySpent += value;
            }
        }
        public override string ToString()
        {
            return $"" +
                $"{base.ToString()}" +
                $"Sign up date: {becameCustomer.ToString("dd MM yyyy")}\n" +
                $"Total spent: {totalMoneySpent}";
        }
    }
}
