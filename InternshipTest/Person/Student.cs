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

        public void SetKnowledgeLevel(int lvl)
        {
            knowledge.SetKnowledgeLevel(lvl);
        }

        public int GetKnowledgeInt()
        {
            return this.knowledge.GetKnowledgeLevel();
        }


        public Knowledge GetKnowledge()
        {
            return knowledge;
        }

        public string GetName()
        {
            return name;
        }
    }
}