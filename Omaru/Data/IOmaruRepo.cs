using System.Collections.Generic;
using Omaru.Models;

namespace Omaru.Data
{
    public interface IOmaruRepo
    {
        IEnumerable<Users> GetUsers();
    }

}