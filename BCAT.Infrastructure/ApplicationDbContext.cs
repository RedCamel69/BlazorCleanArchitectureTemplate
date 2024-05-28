using BCAT.Domain.Books;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        //ef code first migrations - use Add-Migration not migrations add
        public ApplicationDbContext(DbContextOptions options):base (options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
