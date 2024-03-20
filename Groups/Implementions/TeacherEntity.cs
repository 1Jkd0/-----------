using Groups.Implementions;

namespace Students.Implementations
{
    public class TeacherEntity : PersonEntity
    {
        public string Subject { get; private set; }

        public TeacherEntity(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Subject: {Subject}";
        }
    }
}
