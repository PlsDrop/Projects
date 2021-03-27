using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        string name;
        List<Student> listOfStudents = new List<Student>();
        public Internship(string name_)
        {
            name = name_;
        }

        public string GetStudentsStr()
        {   
            string str = "";
            foreach (Student student in listOfStudents)
            {
                str += $"{student.GetName()}\n";
            }
            return str;
        }

        public void AddStudent_FromUniversity(Student student, University university)
        {
            if (student.GetKnowledge() > university.CalcMidlKnowledge())
            {
                listOfStudents.Add(student);
            }
        }
        public void AddAllStudent_FromUniversity(University university)
        {
            foreach (Student student in university.GetStudents())
            {
                AddStudent_FromUniversity(student, university);
            }
        }
    }
}
