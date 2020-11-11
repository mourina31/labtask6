using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK6
{
    class Book
    {
        private String bookname;

        public string BookName
        {
            get { return bookname; }
            set { bookname = value; }
        }


        private String bookAuthor;

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }

        private String bookId;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        private String bookType;

        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }

        private int bookCopy;

        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }


        private Book[] books;
        private int bookCount;

        public int BookCount
        {
            get { return bookCount; }
            set { bookCount = value; }
            
        }

        public void  AddBookCopy(int x )
        {
            if (bookCount < 100)
                bookCopy[ bookCount++ ] = x;
            else
                Console.WriteLine("can not insert book");
        }


        public Book()
        {
            Console.WriteLine("Empty Constructor");
        }

        public Book(String bookname, String bookId, String bookType, int bookCopy)
        {

            this.bookname = bookname;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }

        public void showinfo()
        {
            Console.WriteLine("Name :" + bookname);
            Console.WriteLine("Author :" + bookAuthor);
            Console.WriteLine("ID :" + bookId);
            Console.WriteLine("bookType :" + bookType);
            Console.WriteLine("Book Copy :" + bookCopy);
        }
        public void addBookCopy(int x)
        {
            this.bookCopy += x;
        }

    }
}
