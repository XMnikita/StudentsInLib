namespace StudentsInLib
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.students = new System.Windows.Forms.ListBox();
            this.books = new System.Windows.Forms.ListBox();
            this.studentNew = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.captionNew = new System.Windows.Forms.TextBox();
            this.authorNew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить студента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddStudent);
            // 
            // students
            // 
            this.students.FormattingEnabled = true;
            this.students.Location = new System.Drawing.Point(12, 12);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(465, 277);
            this.students.TabIndex = 3;
            // 
            // books
            // 
            this.books.FormattingEnabled = true;
            this.books.Location = new System.Drawing.Point(506, 12);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(545, 277);
            this.books.TabIndex = 4;
            // 
            // studentNew
            // 
            this.studentNew.Location = new System.Drawing.Point(12, 295);
            this.studentNew.Name = "studentNew";
            this.studentNew.Size = new System.Drawing.Size(465, 20);
            this.studentNew.TabIndex = 5;
            this.studentNew.Text = "user";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(739, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить книгу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddBook);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaveAll);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(408, 448);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Взять книгу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BindBookToStudent);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(408, 419);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Вернуть книгу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.UnBindBookFromStudent);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(408, 506);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Все";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ShowAll);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(406, 477);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(182, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "По студенту";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ShowStudentsBooks);
            // 
            // captionNew
            // 
            this.captionNew.Location = new System.Drawing.Point(506, 295);
            this.captionNew.Name = "captionNew";
            this.captionNew.Size = new System.Drawing.Size(545, 20);
            this.captionNew.TabIndex = 12;
            // 
            // authorNew
            // 
            this.authorNew.Location = new System.Drawing.Point(506, 321);
            this.authorNew.Name = "authorNew";
            this.authorNew.Size = new System.Drawing.Size(545, 20);
            this.authorNew.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 537);
            this.Controls.Add(this.authorNew);
            this.Controls.Add(this.captionNew);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.studentNew);
            this.Controls.Add(this.books);
            this.Controls.Add(this.students);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox students;
        private System.Windows.Forms.ListBox books;
        private System.Windows.Forms.TextBox studentNew;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox captionNew;
        private System.Windows.Forms.TextBox authorNew;
    }
}

