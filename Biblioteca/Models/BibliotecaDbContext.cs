using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Biblioteca.Models;


namespace Biblioteca.Models
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext() : base("name=BibliotecaConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BibliotecaDbContext>());
        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }

    }
}



