using System;

namespace Digital.Models
{
    public class Skill
    {
       
        public int IDSkill { get; set; }

        public string SkillName { get; set; }

        public int? ResumeID { get; set; }
        public Resume Resume { get; set; }

        public Skill()
        {

        }

    }
}

