using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK6
{
    class student
    {

        private String name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private String id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }


        private String department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public Book[] BorrowedBook
        {
            get { return borrowedBook; }
            set { borrowedBook = value; borrowedBookCount = borrowedBook.Length; }
        }

        public int BorrowedBookCount
        {
            get { return borrowedBookCount; }
            set { borrowedBookCount = value; }
        }

        public student()
        {
            Console.WriteLine("Empty Constructor");
        }

        public student(String name, String id, String department, float cgpa)
        {

            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }


        public void showinfo()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("ID :" + id);
            Console.WriteLine("Department :" + department);
            Console.WriteLine("CGPA :" + cgpa);
        }
        public void showBorrowedBookInfo()
        {
            for (int i = 0; i < borrowedBookCount; i++)
            {
                borrowedBook[i].showInfo();
            }
        }
    }
}
