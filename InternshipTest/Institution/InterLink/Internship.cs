using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship : EducationalOrganization
    {
        public Internship(string name_) : base(name_){}

        public void AddStudent_FromUniversity(Student student, University university)
        {
            if (student.GetKnowledgeInt() > university.CalcMidlKnowledge())
            {
                listOfStudents.Add(student);
            }
        }
        public void AddAllStudents_FromUniversity(University university)
        {
            foreach (Student student in university.GetStudents())
            {
                AddStudent_FromUniversity(student, university);
            }
        }
    }
}
