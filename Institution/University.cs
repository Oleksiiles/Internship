using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{

    public class University
    {
        public string Name { get; set; }

        public List<Student> allStudent = new List<Student>();
        public University(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            allStudent.Add(student);
        }
    }
}


