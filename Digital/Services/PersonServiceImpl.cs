using System;
using System.Linq;
using System.Threading.Tasks;
using Digital.Models;

namespace Digital.Services
{
    public class PersonServiceImpl : PersonService
    {
        public PersonServiceImpl()
        {
        }

        private ResumeContext _context = new ResumeContext();
        public async Task<bool> IsPersonExist(string Name)
        {

            await Task.Delay(1000);

            if (_context.Persons.Where(s => s.FirstName == Name).First() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
