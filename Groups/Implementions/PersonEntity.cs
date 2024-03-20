namespace Groups.Implementions
{
    public class PersonEntity
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public PersonEntity(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}, Age: {Age}";
        }
    }
}
