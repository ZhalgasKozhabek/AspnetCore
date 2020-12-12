using System;
using System.Collections.Generic;

namespace Digital.Models
{
    public class Resume
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public string Profile { get; set; }

        
        public Person Person { get; set; }

        public ICollection<Education> Educations { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<WorkExperience> WorkExperiences { get; set; }
        public ICollection<Response> Responces { get; set; }
        public ICollection<Language> Languages { get; set; }

        public Resume()
        {
            Educations = new List<Education>();
            Skills = new List<Skill>();
            WorkExperiences = new List<WorkExperience>();
            Languages = new List<Language>();
            Responces = new List<Response>();
        }
        


    }
}
