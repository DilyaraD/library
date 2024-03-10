using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Poisk : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        private Books _book; // Объявляем переменную book здесь

        public Poisk(librariesEntities context, Librarians user)
        {
            InitializeComponent();
            _user = user;
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
            FillContext();
        }

        void FillContext()
        {
            foreach (var books in _context.Books)
            {
                listBox1.Items.Add(books.title);
            }
        }

        private void button_poisk_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            listBox1.Items.Clear();
            var results = _context.Books.Where(B => B.title.Contains(searchText)).ToList();
            foreach (var result in results)
            {
                listBox1.Items.Add(result.title);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedBook = listBox1.SelectedItem.ToString();
                _book = _context.Books.Where(B => B.title == selectedBook).FirstOrDefault(); // Присваиваем значение переменной _book
                if (_book != null)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Название");
                    dataTable.Columns.Add(_book.title);
                    dataTable.Rows.Add("Автор", _book.Authors.full_name);
                    dataTable.Rows.Add("Год издания", _book.release_year.ToString());
                    dataTable.Rows.Add("Количество", _book.quantity.ToString());
                    dataTable.Rows.Add("Жанр", _book.Genres.genre);
                    dataTable.Rows.Add("Издательство", _book.Publishing.name);
                    dataTable.Rows.Add("Статус", _book.status);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            MainW main = new MainW(new librariesEntities(), _user);
            Hide();
            main.ShowDialog();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (_book != null)
            {
                EditBook edit = new EditBook(new librariesEntities(), _user, _book);
                edit.ShowDialog();
            }
            Hide();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (_book != null)
            {
                DeleteBook del = new DeleteBook(new librariesEntities(), _user, _book);
                del.ShowDialog();
            }
        }
    }
} 
