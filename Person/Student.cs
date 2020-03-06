namespace InternshipTest.Person
{
    public class Student
    {
        public string Name { get; set;}
        public int Knowledge { get; set; }
        public Student(string name, int knowledge)
        {
            Name = name;
            Knowledge = knowledge;
        }

    }
}