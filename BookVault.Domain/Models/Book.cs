using System;
using System.Collections.Generic;
using System.Text;


namespace BookVault.Domain.Models
{
    public class Book
    {
        public Guid Id { set; get; }

        public string Title { set; get; }
        public string Author { set; get; }
        public string Isbn { set; get; }
        public Guid CategoryId { set; get; }
        public Category Category { set; get; }

        public string Country
        {
            get
            {
                // Intentamos procesar el ISBN que ya tiene el libro
                if (ISBN.TryParse(this.Isbn, out var result))
                {
                    
                    return result.GroupName ?? "Internacional";
                }

                return "N/A";
            }
        }

        // sirve para identificar si  dato se a subido o no a la nube
        public bool IsSynced { set; get; }
        public DateTime LastModified { set; get; }

        //Esto sirve para decirle a la base de datos en la nube que un elemento se a eliminado 
        public bool IsDeleted { get; set; }


    }
}
