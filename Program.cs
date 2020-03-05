using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko", 4));
            university.AddStudent(new Student("Julia Veselkina", 5));
            university.AddStudent(new Student("Maria Perechrest", 3));



            Internship internship = new Internship("Interlink");

            internship.setUniversity(university);

            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}

