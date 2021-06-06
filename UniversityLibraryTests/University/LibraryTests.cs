using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLibrary.University;

namespace UniversityLibraryTests.University
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void AddBook_AddOneBook_BookCountIncreased()
        {
            IBookActions library = new Library();

            library.AddBook(new Book(0));

            Assert.AreEqual(1, library.BookCount, "1 book should be in the library");
        }

        [TestMethod]
        public void RemoveBook_AddFIveBooksThenRemoveOne_BookCountReducedByOne()
        {
            IBookActions library = new Library();

            library.AddBook(new Book(0));
            library.AddBook(new Book(1));
            library.AddBook(new Book(2));
            library.AddBook(new Book(3));
            library.AddBook(new Book(4));
            library.AddBook(new Book(5));


            Assert.AreEqual(1, library.BookCount, "1 book should be in the library");
        }

        public void GetBook_AddFiveBooksThenGetOne_CorrectBookReceived()
        {
            // Arrange
            // create library and add 5 books

            const int testId = 3;
            IBookActions newLibrary = new Library();

            newLibrary.AddBook(new Book(0));
            newLibrary.AddBook(new Book(1));
            newLibrary.AddBook(new Book(2));
            Book book = new Book(testId);
            newLibrary.AddBook(new Book(3));
            newLibrary.AddBook(new Book(4));
            newLibrary.AddBook(new Book(5));

            // Act
            // get book number 3

            // Assert
            // test if you get correct book. // 
            //Assert.AreSame

        }

    }
}
