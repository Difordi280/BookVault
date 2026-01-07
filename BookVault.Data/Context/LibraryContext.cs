using System;
using System.Collections.Generic;
using System.Text;
using BookVault.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookVault.Data.Context
{
    public class LibraryContext:DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // AQUÍ PREPARAS LA MESA:
        //    // Usa el método .UseSqlite() y pásale el "Data Source=Nombre.db"
        //    optionsBuilder.UseSqlite("Data Source=Library.db");

        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var catFiccion = Guid.Parse("11111111-1111-1111-1111-111111111111");
            var catNoFiccion = Guid.Parse("22222222-2222-2222-2222-222222222222");
            var catClasicos = Guid.Parse("33333333-3333-3333-3333-333333333333");

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = catFiccion, Name = "Fantasía y Ficción" },
                new Category { Id = catNoFiccion, Name = "Historia y Ciencia" },
                new Category { Id = catClasicos, Name = "Clásicos Universales" }
            );

            // Creamos una fecha fija para todos los libros
            DateTime fechaFija = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var librosRealistas = new List<Book>
    {
        new Book { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Title = "Cien años de soledad", Author = "Gabriel García Márquez", Isbn = "978-0307474728", CategoryId = catClasicos, LastModified = fechaFija, IsSynced = false },
        new Book { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Title = "La sombra del viento", Author = "Carlos Ruiz Zafón", Isbn = "978-8408163381", CategoryId = catFiccion, LastModified = fechaFija, IsSynced = false },
        new Book { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Title = "Sapiens: De animales a dioses", Author = "Yuval Noah Harari", Isbn = "978-8449330643", CategoryId = catNoFiccion, LastModified = fechaFija, IsSynced = false },
        new Book { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Isbn = "978-0743273565", CategoryId = catClasicos, LastModified = fechaFija, IsSynced = false },
        new Book { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Title = "Atomic Habits", Author = "James Clear", Isbn = "978-0735211292", CategoryId = catNoFiccion, LastModified = fechaFija, IsSynced = false },
        new Book { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Title = "1984", Author = "George Orwell", Isbn = "978-0451524935", CategoryId = catFiccion, LastModified = fechaFija, IsSynced = false },
        new Book { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Title = "Le Petit Prince", Author = "Antoine de Saint-Exupéry", Isbn = "978-2070612758", CategoryId = catClasicos, LastModified = fechaFija, IsSynced = false },
        new Book { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Title = "L'Étranger", Author = "Albert Camus", Isbn = "978-2070360024", CategoryId = catClasicos, LastModified = fechaFija, IsSynced = false }
    };

            modelBuilder.Entity<Book>().HasData(librosRealistas);
        }

    }
}
