using System;
using System.Collections.Generic;

namespace Digital.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string NameOfCompany { get; set; }

        public string Salary { get; set; }

        public string Description { get; set; }

        public ICollection<Response> Responces { get; set; }
        public Company()
        {
            Responces = new List<Response>();
        }



    }
}
