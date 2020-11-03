using Microsoft.EntityFrameworkCore;
using net_api_swagger.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_api_swagger.Infrastructure
{
    public class libraryDbContext : DbContext
    {
        public libraryDbContext(DbContextOptions<libraryDbContext> options) : base(options)
        {


        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
