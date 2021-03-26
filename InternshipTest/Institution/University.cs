using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        string name;
        List<Student> listOfStudents = new List<Student>();
        public University(string name_)
        {
            name = name_;
        }

        public void AddStudent(Student student)
        {
            listOfStudents.Add(student);
        }
    }
}
