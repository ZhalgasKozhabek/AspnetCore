using System;

namespace Digital.Models
{
    public class Response
    {

       

        public bool ISseen { get; set; }

        public int? ResumeID { get; set; }
        public Resume Resume { get; set; }

        public int? CompanyID { get; set; }
        public Company Company { get; set; }

        public Response()
        {

        }

    }
}

