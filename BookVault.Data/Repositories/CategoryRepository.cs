using BookVault.Domain.Interfaces;
using Microsoft.EntityFrameworkCore; // Necesario para ToListAsync y métodos de EF
using BookVault.Domain.Models;    // Necesario para que reconozca la clase "Libro"
using BookVault.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookVault.Data.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly LibraryContext _context;

        public CategoryRepository(LibraryContext context) { _context = context; }

        public async Task<IEnumerable<Category>> GetAllAsny()
        { return await _context.Categories.ToListAsync(); }

        public async Task AddAsny(Category Newcategories)
        {
            await _context.Categories.AddAsync(Newcategories);

            // Guardando de forma permanente 
            await _context.SaveChangesAsync();
        }
    }
}
