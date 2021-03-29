using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University("CH.U.I.");
            
            Student student1 = new Student("Andrew");
            Student student2 = new Student("Julia");
            Student student3 = new Student("Maria");
            Student student4 = new Student("Anton");
            Student student5 = new Student("Dmitry");
            Student student6 = new Student("Vladislav");
            Student student7 = new Student("Olexandr");
            Student student8 = new Student("Nataliya");
            Student student9 = new Student("Yevgeniy");
            
            student1.SetKnowledgeLevel(35);
            student2.SetKnowledgeLevel(3);
            student3.SetKnowledgeLevel(99);
            student4.SetKnowledgeLevel(86);
            student5.SetKnowledgeLevel(12);
            student6.SetKnowledgeLevel(58);
            student7.SetKnowledgeLevel(32);
            student8.SetKnowledgeLevel(81);
            student9.SetKnowledgeLevel(70);
            
            
            university.AddStudent(student1);
            university.AddStudent(student2);
            university.AddStudent(student3);
            university.AddStudent(student4);
            university.AddStudent(student5);
            university.AddStudent(student6);
            university.AddStudent(student7);
            university.AddStudent(student8);
            university.AddStudent(student9);

            Internship internship = new Internship("Interlink");
            
            internship.AddAllStudents_FromUniversity(university);
            Console.WriteLine(university.GetMidlKnowledgeStr());
            Console.WriteLine("////////////////////////////////");
            
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudentsStr());
            Console.WriteLine("////////////////////////////////");
            
            Console.WriteLine($"List of {university.GetName()} students:");
            Console.WriteLine(university.GetStudentsStr());
        }
    }
}
