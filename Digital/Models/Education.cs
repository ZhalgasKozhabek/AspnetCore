using System;

namespace Digital.Models
{
    public class Education
    {
      
        public int IDEdu { get; set; }

        public string University { get; set; }

        public string Degree { get; set; }

        public string FromYear { get; set; }

        public string ToYear { get; set; }

        public int? ResumeID { get; set; }
        public Resume Resume { get; set; }

        public Education()
        {

        }


    }
    }

