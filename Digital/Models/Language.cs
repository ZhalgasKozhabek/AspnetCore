using System;

namespace Digital.Models
{
    public class Language
    {

        public int IDLanguage { get; set; }

        public string LanguageName { get; set; }

        public string Proficiency { get; set; }

   
        public int? ResumeID { get; set; }
        public Resume Resume { get; set; }

        public Language()
        {

        }
        

    }
    }

