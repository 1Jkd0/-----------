namespace Groups.Implementions
{
    public class StudentEntity : PersonEntity
    {
        public string StudentId { get; private set; }

        public StudentEntity(string name, int age, string studentId) : base(name, age)
        {
            StudentId = studentId;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Student ID: {StudentId}";
        }
    }
}

