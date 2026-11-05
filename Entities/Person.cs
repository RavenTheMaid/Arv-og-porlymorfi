namespace Entities
{
    public class Person
    {
        public Person(int id, string name)
        {
            ID = id;
            Name = name;
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
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException(nameof(id), "ID cannot be below 0");
                }
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
    }
}
