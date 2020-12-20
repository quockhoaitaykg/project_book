using System;
using System.Collections.Generic;

#nullable disable

namespace BookManagementv2.Models
{
    public partial class BookStatus
    {
        public BookStatus()
        {
            Books = new HashSet<Book>();
        }

        public int BookStatusId { get; set; }
        public string BookStatus1 { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
