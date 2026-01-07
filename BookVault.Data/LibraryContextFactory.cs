using BookVault.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookVault.Data
{
    public class LibraryContextFactory : IDesignTimeDbContextFactory<LibraryContext>
    {
        public LibraryContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();
            // Asegúrate de que el nombre de la DB coincida con el de tu App
            optionsBuilder.UseSqlite("Data Source=Library.db");

            return new LibraryContext(optionsBuilder.Options);
        }
    }
}