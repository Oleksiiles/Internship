using System.Collections.Generic;


namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string Name;
        public int averageLevel;
        public List<Student> intershipStudent = new List<Student>();

        public Internship(string name)
        {
            Name = name;

        }
          
        public void setAverageLevel(University university)
        {
            int ollRating = 0;
            foreach (var student in university.allStudent)
            {
                ollRating += student.Knowledge;
            } 
            averageLevel = ollRating / university.allStudent.Count;
        }
        public void enrollStudent()
        {
            foreach (var student in universityStudentList)
            {
                if (student.Knowledge > averageLevel)
                {
                    intershipStudent.Add(student);
                }
            }
        }
        public string setStudents()
        {
            string listDtudent = "";
            foreach (var student in University.allStudent)
            {
                if (student.Knowledge > averageLevel)
                {
                    intershipStudent.Add(student);
                    listDtudent += student.Name + "/n";

                }
            }
            return listDtudent;
        }
    }
}

