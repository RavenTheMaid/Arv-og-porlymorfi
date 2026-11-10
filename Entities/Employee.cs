using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Entities
{
    public class Employee : Person
    {
        public Employee
        (
            int id, string name, DateTime birthDate, string titleOfCourtesy, //this goes to person class
            string jobTitle, DateTime dateOfEmployment, decimal anualSalary
        ) 
            :base(id, name, birthDate, titleOfCourtesy)
        {
            JobTitle = jobTitle;
            DateOfEmployment = dateOfEmployment;
            AnualSalary = anualSalary;
        }
        private string jobTitle;
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        private DateTime dateOfEmployment;
        public DateTime DateOfEmployment
        {
            get
            {
                return dateOfEmployment;
            }
            set
            {
                if (value < DateTime.Today.AddYears(-100))
                {
                    throw new ArgumentOutOfRangeException(nameof(dateOfEmployment), "You did not start working here 100 years ago");
                }
                else if (value > DateTime.Today.AddDays(30))
                {
                    throw new ArgumentOutOfRangeException(nameof(dateOfEmployment), "You cannot predict the future");
                }
                dateOfEmployment = value;
            }
        }
        private decimal anualSalary;
        public decimal AnualSalary
        {
            get
            {
                return anualSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(anualSalary), "you must not be allowed to make negative money");
                }
                else if (value > 1000000000)
                {
                    throw new ArgumentOutOfRangeException(nameof(anualSalary), "i dont allow billionares here");
                }
                anualSalary = value;
            }
        }
        public override string ToString()
        {
            return $"" +
                $"{base.ToString()}" +
                $"Job title: {jobTitle}\n" +
                $"Employment start: {dateOfEmployment.ToString("dd MM yyyy")}";
        }
    }
}
