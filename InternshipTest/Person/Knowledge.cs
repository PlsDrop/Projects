using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest
{
    public class Knowledge
    {
        int level;
        public Knowledge(int level_)
        {
            level = level_;
        }
        public void SetKnowledgeLevel(int lvl)
        {
            level = lvl;
        }
        public int GetKnowledgeLevel()
        {
            return level;
        }

    }
}
