using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Entity
{
    /// <summary>
    /// The Book db context
    /// </summary>
    public class BookContext :DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Ganre> Ganres { get; set; }
    }
}
