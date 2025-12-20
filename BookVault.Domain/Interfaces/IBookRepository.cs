using System;
using System.Collections.Generic;
using System.Text;
using BookVault.Domain.Models;

namespace BookVault.Domain.Interfaces
{
    public interface IBookRepository
    {
        // Lista de libros que ahi en la base de datos
        IEnumerable<Book> ListBooks();

        // Obtener un libro en especifico con el Id
        Book GetBook(Guid Id);
        // Guardar libros en la base de datos 
        void SaveBooks(Book NewBooks );

        //lista de libros pendientes 
        IEnumerable<Book> BooksToInsert();

    }
}
