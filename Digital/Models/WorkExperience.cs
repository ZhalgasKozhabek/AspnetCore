using System;

namespace Digital.Models
{
    public class WorkExperience
    {
        
        public int ExperienceID { get; set; }
      
        public string Company { get; set; }

        public string Title { get; set; }
 
        public string Country { get; set; }

        public string FromYear { get; set; }

        public string ToYear { get; set; }

        public string Description { get; set; }

        public int? ResumeID { get; set; }
        public Resume Resume { get; set; }

        public WorkExperience()
        {

        }

    }
}
