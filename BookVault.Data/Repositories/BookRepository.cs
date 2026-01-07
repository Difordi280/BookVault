using System;
using System.Collections.Generic;
using System.Text;
using BookVault.Domain.Interfaces;
using Microsoft.EntityFrameworkCore; // Necesario para ToListAsync y métodos de EF
using BookVault.Domain.Models;    // Necesario para que reconozca la clase "Libro"
using BookVault.Data.Context;
using System.Formats.Asn1;      // Necesario si el Contexto está en otra carpeta

namespace BookVault.Data.Repositories
{
    public class BookRepository:IBookRepository
    {
        // 1. Definicion del campo privado
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        //Sacar los datos de la tabla SQLite
        public async Task<IEnumerable<Book>> GetAllAsny()
        {
            return await _context.Books.Include(b=> b.Category).ToListAsync();
        }

        //Agregar de manera asincrona Datos en una tabla 
        public async Task AddAsny(Book NewBook)
        {
            // Guardando en la base de datos de forma temporal
            await _context.Books.AddAsync(NewBook);

            // Guardando de forma permanente 
            await _context.SaveChangesAsync();
        }

        public async Task<Book> GetBook(Guid Id)
        {
            return await _context.Books.FindAsync(Id);
        }

        public async Task<IEnumerable<Book>> PendingBooks()
        {

            return await _context.Books.Where(u=> !u.IsSynced).ToListAsync();
        }



    }
}
