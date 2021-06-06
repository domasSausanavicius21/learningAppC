using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary.University
{
    public interface IBookActions
    {
        int BookCount { get; }

        void AddBook(Book book);

        void RemoveBook(int bookId);

    }
}
