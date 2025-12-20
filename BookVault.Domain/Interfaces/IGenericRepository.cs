using System;
using System.Collections.Generic;
using System.Text;

namespace BookVault.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        //Esto es para toda la lista de objetos que queremos pedir 
        Task<IEnumerable<T>> GetAllAsny();
        // esto es para guardar un objeto poniendo el nombre o entity
        Task AddAsny(T entity);
    }
}
