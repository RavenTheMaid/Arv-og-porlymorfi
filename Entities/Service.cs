using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Service : SalesUnit
    {
        public Service
            (
                
                string name, //goes to SalesUnit class
                DateTime timeOfCreation, //goes to SalesUnit class
                decimal price, //goes to SalesUnit class
                string description, 
                DateTime startOfService, 
                TimeSpan durationOfService
            )
            :base (name, timeOfCreation, price)
        {
            Description = description;
            StartOfService = startOfService;
            DurationOfService = durationOfService;
        }
        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(description), "Description cannot be empty");
                }
                description = value;
            }
        }
        private DateTime startOfService;
        public DateTime StartOfService
        {
            get
            {
                return startOfService;
            }
            set
            {
                if (value < DateTime.Today.AddYears(-100))
                {
                    throw new ArgumentOutOfRangeException(nameof(startOfService), "Service cannot start over 100 years ago");
                }
                else if (value > DateTime.Today.AddYears(10))
                {
                    throw new ArgumentOutOfRangeException(nameof(startOfService), "service cannot start in 10 years or more");
                }
                startOfService = value;
            }
        }
        private TimeSpan durationOfService;
        public TimeSpan DurationOfService
        {
            get
            {
                return durationOfService;
            }
            set
            {
                durationOfService = value;
            }
        }
        public override string ToString()
        {
            return $"" +
                $"{base.ToString()}\n" +
                $"Service description: {description}\n" +
                $"Service start {startOfService.ToString("dd MM yyy")}\n" +
                $"Service duration: {durationOfService.ToString(@"d")}\n";
        }
    }
}
