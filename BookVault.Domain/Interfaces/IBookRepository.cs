using System;
using System.Collections.Generic;
using System.Text;
using BookVault.Domain.Models;

namespace BookVault.Domain.Interfaces
{
    public interface IBookRepository:IGenericRepository<Book>
    {
        

        // Obtener un libro en especifico con el Id
        Task<Book> GetBook(Guid Id);
        
        //lista de libros pendientes 
        Task<IEnumerable<Book>> PendingBooks();

    }
}
