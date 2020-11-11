using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK6
{

    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Student s1 = new Student();
        s1.Name = "SIDDIQ";
        s1.Id = "18368131";
        s1.Department = "CSE";

        Student s2 = new Student("OISHI", "18344444", "CSE");
        Student s3 = new Student("ARTA", "178888", "CSE");

        //s1.showInfo();

        Book b1 = new Book("bookName1", "Author1", "3453", "ABCD", 4);
        Book b2 = new Book("bookName2", "Author2", "5235", "EFGH", 5);
        Book b3 = new Book("bookName3", "Author3", "6264", "IJKL", 6);
        Book b4 = new Book("bookName4", "Author4", "2345", "MNOP", 7);
        Book b5 = new Book("bookName5", "Author5", "6342", "QRST", 3);
        Book b6 = new Book("bookName"6, "Author6", "2665", "UVWS", 1);


        s1.BorrowedBook = new Book[] { b1, b2 };
        s2.BorrowedBook = new Book[] { b3, b4, b5 };
        s3.BorrowedBook = new Book[] { b2, b6 };
        //s1.BorrowedBookCount = borrowedBook.Length;

        //s1.showBorrowedBookInfo();

        Library library = new Library("LIBRARY", "AIUB", new Book[] { b1, b2, b3, b4, b5, b6 }, 6);

        library.showAllBooks();
    }
}
}