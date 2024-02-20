using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Data.Entity;

namespace library
{
    public partial class BorrBooks : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        private Readers _reader;
        private Books _book;
        public BorrBooks(librariesEntities context, Librarians user)
        {
            InitializeComponent();
            _user = user;
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
            FillContext();
            FillReaderInfo();
        }
        void FillContext()
        {
            foreach (var readers in _context.Readers)
            {
                listBox2.Items.Add(readers.first_name + " " + readers.last_name);
            }

            foreach (var books in _context.Books)
            {
                listBox1.Items.Add(books.title);
            }
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            MainW main = new MainW(new librariesEntities(), _user);
            Hide();
            main.ShowDialog();
        }

        void FillReaderInfo()
        {
            label_brdate.Text = DateTime.Now.ToShortDateString();
            label_rdate.Text = DateTime.Now.AddDays(14).ToShortDateString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedBook = listBox1.SelectedItem.ToString();
                _book = _context.Books.Where(B => B.title == selectedBook).FirstOrDefault();

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
                    label_title.Text = _book.title;
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button_poisk_Click(object sender, EventArgs e)
        {
            string searchText = textBox_title.Text;
            listBox1.Items.Clear();
            var results = _context.Books.Where(B => B.title.Contains(searchText)).ToList();
            foreach (var result in results)
            {
                listBox1.Items.Add(result.title);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                string reader = listBox2.SelectedItem.ToString();
                _reader = _context.Readers.Where(R => R.first_name + " " + R.last_name == reader).FirstOrDefault();

                if (_reader != null)
                {
                    DataTable dataTable1 = new DataTable();
                    dataTable1.Columns.Add("Имя");
                    dataTable1.Columns.Add(_reader.first_name);
                    dataTable1.Rows.Add("Фамилия", _reader.last_name);
                    dataTable1.Rows.Add("День рождения", _reader.birthday.ToShortDateString());
                    dataTable1.Rows.Add("Номер телефона", _reader.phone_number.ToString());
                    dataGridView2.DataSource = dataTable1;
                    label_name.Text = _reader.first_name + " " + _reader.last_name;
                }
            }
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            string searchText = textBox_name.Text;
            listBox2.Items.Clear();
            var results = _context.Readers.Where(R => R.first_name.Contains(searchText) || R.last_name.Contains(searchText)).ToList();
            foreach (var result in results)
            {
                listBox2.Items.Add(result.first_name + " " + result.last_name);
            }
        }

        private void button_give_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите читателя и книгу для выдачи.");
                return;
            }

            string reader = listBox2.SelectedItem.ToString();
            _reader = _context.Readers.Where(R => R.first_name + " " + R.last_name == reader).FirstOrDefault();
            string selectedBook = listBox1.SelectedItem.ToString();
            _book = _context.Books.Where(B => B.title == selectedBook).FirstOrDefault();

            if (_context.BorrowedBooks.Any(b => b.reader_id == _reader.id && b.book_id == _book.id && b.dates_must_return > DateTime.Now && b.dates_b < DateTime.Now))
            {
                MessageBox.Show("У читателя книга уже на руках.");
                return;
            }

            if (_book.quantity <= 0)
            {
                MessageBox.Show("Книги закончились.");
                return;
            }
            DateTime currentDate = DateTime.Now;
            DateTime newDate = currentDate.AddHours(336);
            int borrbook = (int)_context.BorrowedBooks.Max(B => B.borrowed_book_id);
            BorrowedBooks borbook = new BorrowedBooks
            {
                borrowed_book_id = borrbook + 1,
                reader_id = _reader.id,
                book_id = _book.id,
                dates_b = currentDate,
                dates_must_return = newDate,
                librarian_id = _user.id
            };

            _book.quantity -= 1;
            _context.BorrowedBooks.Add(borbook);
            _context.SaveChanges();
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            label_name.Text = "";
            label_title.Text = "";
            MessageBox.Show("Выдана книга.");
        }
    }
}
