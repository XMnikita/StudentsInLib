using System.IO;
using StudentsInLib.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInLib
{
    public partial class Form1 : Form
    {
        Student[] studentsArray;
        Book[] booksArray;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            var dir = Directory.GetCurrentDirectory();
            string filename = dir + "/students.txt";

            if (File.Exists(filename))
            {
                studentsArray = Loader.LoadFromFile<Student>(filename);
                students.Items.Clear();

                if (studentsArray != null)
                {
                    foreach (var st in studentsArray)
                    {
                        var line = $"{st.surname} {st.name} {st.thirdname}";
                        students.Items.Add(line);
                    }

                }
            }
            else
            {
                File.Create(filename);
            }

            filename = dir + "/books.txt";
            if (File.Exists(filename))
            {
                booksArray = Loader.LoadFromFile<Book>(filename);
                books.Items.Clear();

                if (booksArray != null)
                {
                    foreach (var book in booksArray)
                    {
                        var line = $"{book.caption} {book.author}";
                        books.Items.Add(line);
                    }
                }
            }
            else
            {
                File.Create(filename);
            }



        }

        void BindBookToStudent(object sender, EventArgs e)
        {
            var stid = studentsArray[students.SelectedIndex].unicID;
            var book = booksArray[books.SelectedIndex];

            book.currentOwner = stid;
        }

        void UnBindBookFromStudent(object sender, EventArgs e)
        {
            var book = booksArray[books.SelectedIndex];
            book.currentOwner = -1;

        }

        void ShowStudentsBooks(object sender, EventArgs ev)
        {
            var st = studentsArray[students.SelectedIndex];
            students.Items.Clear();

            students.Items.Add($"{st.surname} {st.name} {st.thirdname}");
            books.Items.Clear();

            Book[] studentsBooks = booksArray.Where(e => e.currentOwner == st.unicID).ToArray();

            if (studentsBooks != null)
            {
                foreach (var book in studentsBooks)
                {
                    var line = $"{book.caption} {book.author}";
                    books.Items.Add(line);
                }
            }
        }

        void ShowAll(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddStudent(object sender, EventArgs e)
        {

        }

        private void AddBook(object sender, EventArgs e)
        {

        }
    }
}
