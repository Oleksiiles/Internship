using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{

    public class University
    {
        public string Name { get; set; }
        public int averageLevel;


        public List<Student> allStudents = new List<Student>();
        public University(string name)
        {
            Name = name;
        }

        public void setAverageLevel(List<Student> listStudent)
        {
            int ollRating = 0;
            foreach (var student in listStudent)
            {
                ollRating += student.Knowledge;
            }
            averageLevel = ollRating / allStudents.Count;
        }
        public void AddStudent(Student student)
        {
            allStudents.Add(student);
            setAverageLevel(allStudenst);

        }
    }
}


