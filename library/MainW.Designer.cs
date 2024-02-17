namespace library
{
    partial class MainW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_readers = new System.Windows.Forms.Button();
            this.button_brbooks = new System.Windows.Forms.Button();
            this.button_data = new System.Windows.Forms.Button();
            this.button_poisk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_rtbooks = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_smena = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_librarian = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Readers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_BorBooks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Books = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_readers
            // 
            this.button_readers.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_readers.Location = new System.Drawing.Point(24, 322);
            this.button_readers.Margin = new System.Windows.Forms.Padding(2);
            this.button_readers.Name = "button_readers";
            this.button_readers.Size = new System.Drawing.Size(200, 66);
            this.button_readers.TabIndex = 9;
            this.button_readers.Text = "Читательские билеты";
            this.button_readers.UseVisualStyleBackColor = true;
            // 
            // button_brbooks
            // 
            this.button_brbooks.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_brbooks.Location = new System.Drawing.Point(24, 188);
            this.button_brbooks.Margin = new System.Windows.Forms.Padding(2);
            this.button_brbooks.Name = "button_brbooks";
            this.button_brbooks.Size = new System.Drawing.Size(200, 50);
            this.button_brbooks.TabIndex = 8;
            this.button_brbooks.Text = "Выдача книг";
            this.button_brbooks.UseVisualStyleBackColor = true;
            // 
            // button_data
            // 
            this.button_data.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_data.Location = new System.Drawing.Point(24, 109);
            this.button_data.Margin = new System.Windows.Forms.Padding(2);
            this.button_data.Name = "button_data";
            this.button_data.Size = new System.Drawing.Size(200, 60);
            this.button_data.TabIndex = 7;
            this.button_data.Text = "Занесение \r\nданных";
            this.button_data.UseVisualStyleBackColor = true;
            this.button_data.Click += new System.EventHandler(this.button_data_Click);
            // 
            // button_poisk
            // 
            this.button_poisk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_poisk.Location = new System.Drawing.Point(24, 38);
            this.button_poisk.Margin = new System.Windows.Forms.Padding(2);
            this.button_poisk.Name = "button_poisk";
            this.button_poisk.Size = new System.Drawing.Size(200, 50);
            this.button_poisk.TabIndex = 6;
            this.button_poisk.Text = "Поиск";
            this.button_poisk.UseVisualStyleBackColor = true;
            this.button_poisk.Click += new System.EventHandler(this.button_poisk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_rtbooks);
            this.groupBox1.Controls.Add(this.button_poisk);
            this.groupBox1.Controls.Add(this.button_readers);
            this.groupBox1.Controls.Add(this.button_data);
            this.groupBox1.Controls.Add(this.button_brbooks);
            this.groupBox1.Location = new System.Drawing.Point(34, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 425);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "выбор действия";
            // 
            // button_rtbooks
            // 
            this.button_rtbooks.Cursor = System.Windows.Forms.Cursors.No;
            this.button_rtbooks.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_rtbooks.Location = new System.Drawing.Point(24, 253);
            this.button_rtbooks.Name = "button_rtbooks";
            this.button_rtbooks.Size = new System.Drawing.Size(200, 50);
            this.button_rtbooks.TabIndex = 10;
            this.button_rtbooks.Text = "Возврат книг";
            this.button_rtbooks.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label_smena);
            this.groupBox2.Controls.Add(this.label_date);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label_librarian);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label_Readers);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_BorBooks);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_Books);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(341, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 425);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "общая информация";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Смена идет:";
            // 
            // label_smena
            // 
            this.label_smena.AutoSize = true;
            this.label_smena.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_smena.Location = new System.Drawing.Point(169, 270);
            this.label_smena.Name = "label_smena";
            this.label_smena.Size = new System.Drawing.Size(29, 33);
            this.label_smena.TabIndex = 10;
            this.label_smena.Text = "0";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date.Location = new System.Drawing.Point(169, 234);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(29, 33);
            this.label_date.TabIndex = 9;
            this.label_date.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата и время:";
            // 
            // label_librarian
            // 
            this.label_librarian.AutoSize = true;
            this.label_librarian.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_librarian.Location = new System.Drawing.Point(16, 196);
            this.label_librarian.Name = "label_librarian";
            this.label_librarian.Size = new System.Drawing.Size(181, 33);
            this.label_librarian.TabIndex = 7;
            this.label_librarian.Text = "Имя Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "На смене работает библиотекарь:";
            // 
            // label_Readers
            // 
            this.label_Readers.AutoSize = true;
            this.label_Readers.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Readers.Location = new System.Drawing.Point(281, 117);
            this.label_Readers.Name = "label_Readers";
            this.label_Readers.Size = new System.Drawing.Size(29, 33);
            this.label_Readers.TabIndex = 5;
            this.label_Readers.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Всего читателей:";
            // 
            // label_BorBooks
            // 
            this.label_BorBooks.AutoSize = true;
            this.label_BorBooks.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BorBooks.Location = new System.Drawing.Point(281, 72);
            this.label_BorBooks.Name = "label_BorBooks";
            this.label_BorBooks.Size = new System.Drawing.Size(29, 33);
            this.label_BorBooks.TabIndex = 3;
            this.label_BorBooks.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Всего книг на руках:";
            // 
            // label_Books
            // 
            this.label_Books.AutoSize = true;
            this.label_Books.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Books.Location = new System.Drawing.Point(281, 31);
            this.label_Books.Name = "label_Books";
            this.label_Books.Size = new System.Drawing.Size(29, 33);
            this.label_Books.TabIndex = 1;
            this.label_Books.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общее количество книг: ";
            // 
            // MainW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainW";
            this.Text = "MainW";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_readers;
        private System.Windows.Forms.Button button_brbooks;
        private System.Windows.Forms.Button button_data;
        private System.Windows.Forms.Button button_poisk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_rtbooks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Readers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_BorBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Books;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_smena;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_librarian;
    }
}