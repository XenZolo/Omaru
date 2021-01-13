using Microsoft.EntityFrameworkCore;
using Omaru.Models;

namespace Omaru.Data
{
    public class OmaruContext : DbContext
    {
        public OmaruContext(DbContextOptions<OmaruContext> opt) : base(opt)
        {

        }

        public DbSet<Users> User { get; set; }

    }

}