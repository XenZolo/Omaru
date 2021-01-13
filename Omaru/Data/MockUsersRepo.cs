using System.Collections.Generic;
using Omaru.Data;
using Omaru.Models;

namespace omaru.Data
{
    public class MockUsersRepo : IOmaruRepo
    {
        public IEnumerable<Users> GetAllUsers()
        {
            var Users = new List<Users>
            {
                new Users{ id = 1, username = "admin", password = "admin", role = "admin"},
                new Users{ id = 2, username = "reception", password = "reception", role = "reception"},
                new Users{ id = 3, username = "chef", password = "chef", role = "chef"}
            };

            return Users;
        }
    }
}