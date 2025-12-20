using System;
using System.Collections.Generic;
using System.Text;
using BookVault.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookVault.Data.Context
{
    public class LibraryContext:DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // AQUÍ PREPARAS LA MESA:
            // Usa el método .UseSqlite() y pásale el "Data Source=Nombre.db"
            optionsBuilder.UseSqlite("Data Source=Library.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // De momento, podemos dejar el manual de reglas vacío
            // EF Core usará las reglas por defecto.


        }

    }
}
