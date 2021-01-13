using System.Collections.Generic;
using System.Linq;
using Omaru.Models;

namespace Omaru.Data
{

    public class SqlOmaruRepo : IOmaruRepo
    {
        private OmaruContext _context;

        public SqlOmaruRepo(OmaruContext context)
        {
            _context = context;
        }


        public IEnumerable<Users> GetAllUsers()
        {
            return _context.User.ToList();
        }
    }

}
