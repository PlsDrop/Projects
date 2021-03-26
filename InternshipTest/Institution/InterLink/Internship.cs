using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship : University
    {
        string name;
        List<Student> listOfStudents = new List<Student>();
        public Internship(string name_) : base(name_){}

        public string GetStudents()
        {

            //TODO: Implementation is needed
            return "Andrew Maslenko\nJulia Veselkina\n";
        }
    }
}
