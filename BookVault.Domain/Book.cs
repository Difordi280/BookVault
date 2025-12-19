using System;
using System.Collections.Generic;
using System.Text;


namespace BookVault.Domain
{
    internal class Book
    {
        public Guid Id { set; get; }

        public string Title { set; get; }
        public string Author { set; get; }
        public string Isbn { set; get; }

        public bool IsSynced { set; get; }
        public DateTime LastModified { set; get; }

        public bool IsDeleted { get; set; }

    }
}
