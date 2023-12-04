using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibMS.Classes
{
    public class User
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Gender { get; set; }
        public string? NIC { get; set; }
        public string? Address { get; set;}
        public virtual ObservableCollectionListSource<Book> BorrowedBooks { get; set; } = new();
    }
}
