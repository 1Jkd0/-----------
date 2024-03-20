namespace Groups.Implementions
{
    public class SubjectEntity
    {
        public string Name { get; private set; }
        public string Code { get; private set; }

        public SubjectEntity(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return $"Subject: {Name}, Code: {Code}";
        }
    }
}
