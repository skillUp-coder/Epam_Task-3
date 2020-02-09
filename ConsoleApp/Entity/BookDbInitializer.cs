using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp.Entity
{
    public class BookDbInitializer:DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            context.Books.Add(new Book { Name = "C++ tour", Author = "Bjarne Straunstrup", Price = 899, Code= 111222111, Description= "Book for those who are passionate about C++" });//
            context.Books.Add(new Book { Name = "C#: Learn C# ", Author = "Jamie Chan", Price = 999, Code = 999888999, Description = "C# in Depth-a book for those who are passionate about C#" });
            context.Books.Add(new Book { Name = "War and Peace ", Author = "Leo Tolstoy", Price = 399, Code = 123321123, Description = "Epic in scale, War and Peace delineates in graphic detail events leading up to Napoleon's invasion of Russia, and the impact of the Napoleonic era on Tsarist society, as seen through the eyes of five Russian aristocratic families"});

            context.Ganres.Add(new Ganre { Title= "technical literature"  });
            context.Ganres.Add(new Ganre { Title = "technical literature" });
            context.Ganres.Add(new Ganre { Title = "Historical novel" });
            base.Seed(context);
        }
    }
}
