using System.Collections.Generic;


namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string Name;
        public List<Student> intershipStudent = new List<Student>();

        public Internship(string name)
        {
            Name = name;

        }


        public void enrollStudent(University university)
        {
            foreach (var student in university.allStudents)
            {
                if (student.Knowledge > university.averageLevel)
                {
                    intershipStudent.Add(student);
                }
            }
        }
        public string getStudents()
        {
            string listDtudent = "";
            foreach (var student in intershipStudent)
            {
                listDtudent += student.Name + "/n";
            }
            return listDtudent;
        }
    }
}

