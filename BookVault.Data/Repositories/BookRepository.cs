using System;
using System.Collections.Generic;
using System.Text;
using BookVault.Domain.Interfaces;
using Microsoft.EntityFrameworkCore; // Necesario para ToListAsync y métodos de EF
using BookVault.Domain.Models;    // Necesario para que reconozca la clase "Libro"
using BookVault.Data.Context;      // Necesario si el Contexto está en otra carpeta

namespace BookVault.Data.Repositories
{
    internal class BookRepository:IBookRepository
    {
        // 1. Definicion del campo privado
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllAsny()
        {
            return null;
        }


    }
}
