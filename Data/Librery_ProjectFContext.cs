using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Librery_ProjectF.Models;

namespace Librery_ProjectF.Data
{
    public class Librery_ProjectFContext : DbContext
    {
        public Librery_ProjectFContext (DbContextOptions<Librery_ProjectFContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Employees> Employees { get; set; } = default!;

        public DbSet<User> User { get; set; }
        //public DbSet<Librery_ProjectF.Models.BookCategory> BookCategory { get; set; } = default!;
        public DbSet<BookCategory> BookCategories { get; set; }


    }
}
