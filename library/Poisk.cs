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
                var book = _context.Books.Where(B => B.title == selectedBook)
                            .Select(B => new
                            {
                                B.title,
                                Author = B.Authors.full_name,
                                B.release_year,
                                B.quantity,
                                Genre = B.Genres.genre,
                                Publishing = B.Publishing.name,
                                B.status
                            })
                            .FirstOrDefault();

                if (book != null)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Название");
                    dataTable.Columns.Add(book.title);
                    dataTable.Rows.Add("Автор", book.Author);
                    dataTable.Rows.Add("Год издания", book.release_year.ToString());
                    dataTable.Rows.Add("Количество", book.quantity.ToString());
                    dataTable.Rows.Add("Жанр", book.Genre);
                    dataTable.Rows.Add("Издательство", book.Publishing);
                    dataTable.Rows.Add("Статус", book.status);

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
    }
}
