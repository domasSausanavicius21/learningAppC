using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary.University
{
    public class Library : IBookActions
    {
        private List<Book> books = new List<Book>();
        public int BookCount => throw new NotImplementedException();

        public void AddBook (Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(int bookId)
        {
            books.RemoveAll(b => b.Id == bookId);
        }

        public void DoStuff()
        {

        }

        public Book GetBook (int bookId)
        {
            return books.Find(b => b.Id == bookId);
        }
    }
}
