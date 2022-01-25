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
                LoadStudents();
            }
            else
            {
                File.Create(filename);
            }

            filename = dir + "/books.txt";
            if (File.Exists(filename))
            {
                booksArray = Loader.LoadFromFile<Book>(filename);
                LoadBooks();
            }
            else
            {
                File.Create(filename);
            }



        }

        void LoadStudents()
        {
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

        void LoadBooks()
        {
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

        void BindBookToStudent(object sender, EventArgs ev)
        {
            var stid = studentsArray[students.SelectedIndex].unicID;
            var book = booksArray[books.SelectedIndex];

            if (book.currentOwner != -1)
            {
                var st = studentsArray.First(e => e.unicID == book.currentOwner);
                MessageBox.Show($"Отберите книгу у {st.surname} {st.name} {st.thirdname}", "ошибочка");
                return;
            }

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
        void Copy<T>(T[] arr1, T[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

        }

        private void AddStudent(object sender, EventArgs e)
        {
            var line = studentNew.Text.Split();
            var student = new Student()
            {
                name = line[0],
                surname = line[1],
                thirdname = line[2],
                groupNumber = line[3],
                unicID = studentsArray.Length
            };


            Student[] newArr = new Student[studentsArray.Length + 1];
            Copy(studentsArray, newArr);

            newArr[studentsArray.Length] = student;
            studentsArray = newArr;

            LoadStudents();
        }


        private void AddBook(object sender, EventArgs e)
        {

            var book = new Book()
            {
                caption = captionNew.Text,
                author = authorNew.Text,
                currentOwner = -1,
                unicID = booksArray.Length
            };

            Book[] newArr = new Book[booksArray.Length + 1];
            Copy(booksArray, newArr);

            newArr[booksArray.Length] = book;
            booksArray = newArr;

            LoadBooks();
        }

        private void SaveAll(object sender, EventArgs e)
        {
            var dir = Directory.GetCurrentDirectory();
            string filename = dir + "/students.txt";

            if (!File.Exists(filename))
            {
                File.Create(filename);
            }

            Loader.SaveToFile(filename, studentsArray);

            filename = dir + "/books.txt";

            if (!File.Exists(filename))
            {
                File.Create(filename);
            }

            Loader.SaveToFile(filename, booksArray);

        }
    }
}
