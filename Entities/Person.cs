using System.ComponentModel.Design;

namespace Entities
{
    public class Person
    {
        public Person
            (
                int id, 
                string name, 
                DateTime birthDate, 
                string titleOfCourtesy
            )

        {

            ID = id;
            Name = name;
            BirthDate = birthDate;
            TitleOfCourtesy = titleOfCourtesy;
        }
        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new ArgumentOutOfRangeException(nameof(id), "ID cannot be below 0");
                }
                id = value;
            }
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
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(name), "name cannot be empty");
                }
                name = value;
            }
        }
        private DateTime birthDate;
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                if (value < DateTime.Today.AddYears(-100))
                {
                    throw new ArgumentOutOfRangeException(nameof(birthDate), "You are not over 100 years old if you can be here");
                }
                else if (value > DateTime.Today.AddDays(1))
                {
                    throw new ArgumentOutOfRangeException(nameof(birthDate), "you are not born tomorrow");
                }
                birthDate = value;
            }
        }
        private string titleOfCourtesy;
        public string TitleOfCourtesy
        {
            get
            {
                return titleOfCourtesy;
            }
            set
            {
                if(value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException(nameof(titleOfCourtesy), "theres no way a title can be that long");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(titleOfCourtesy), "please get a title of courtesy");
                }
                titleOfCourtesy = value;
            }
        }
        public override string ToString()
        {
            return $"" +
                $"{titleOfCourtesy} {name}\n" +
                $"Birthday: {birthDate}\n" +
                $"ID: {id}\n";
        }
    }
}
