using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest.Person
{
    public class Student
    {   
        string name;
        Knowledge knowledge = new Knowledge(0); 
        public Student(string name_)
        {
            name = name_;
        }

        public void SetKnowledge(Knowledge knowledge_)
        {
            this.knowledge = knowledge_;
        }

        public int GetKnowledge()
        {
            return this.knowledge.level;
        }

        public string GetName()
        {
            return name;
        }
    }
}