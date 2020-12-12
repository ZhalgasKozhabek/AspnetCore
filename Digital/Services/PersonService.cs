using System;
using System.Threading.Tasks;

namespace Digital.Services
{
    public interface PersonService
    {
        Task<bool> IsPersonExist(String Name);
    }
}
