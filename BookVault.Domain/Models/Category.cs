using System;
using System.Collections.Generic;
using System.Text;

namespace BookVault.Domain.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public List<Book> Books { get; set; } = new();
    }
}
