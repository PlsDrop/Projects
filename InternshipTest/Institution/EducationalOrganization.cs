using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class EducationalOrganization
    {
        protected string name;
        protected List<Student> listOfStudents = new List<Student>();

        public string GetStudentsStr()
        {   
            string str = "";
            foreach (Student student in listOfStudents)
            {
                str += $"{student.GetName()} ({student.GetKnowledgeInt().ToString()} -knowledge)\n";
            }
            return str;
        }

        public EducationalOrganization(string name_)
        {
            name = name_;
        }
        public void AddStudent(Student student)
        {
            listOfStudents.Add(student);
        }

        public string GetName()
        {
            return name;
        }
        public List<Student> GetStudents()
        {
            return listOfStudents;
        }

        public string GetMidlKnowledgeStr()
        {
            return $"{CalcMidlKnowledge().ToString("#.##")} - midl knowledge of {name}.";
        }

        public decimal CalcMidlKnowledge()
        {   
            int summ = 0;
            foreach(Student student in listOfStudents)
            {
                summ += student.GetKnowledgeInt();
            }
            return summ/listOfStudents.Count;
        }
    }
}