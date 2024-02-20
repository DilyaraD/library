using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class RetBooks : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        private Readers _reader;
        public RetBooks(librariesEntities context, Librarians user)
        {
            InitializeComponent();
            _user = user;
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
            FillContext();
        }
        void FillContext()
        {
            foreach (var readers in _context.Readers)
            {
                listBox2.Items.Add(readers.first_name + " " + readers.last_name);
            }
        }

        private void LoadUnreturnedBooks(int readerId)
        {
            var unreturnedBooks = _context.BorrowedBooks
         .Where(bb => bb.reader_id == readerId && !_context.ReturnedBooks.Any(rb => rb.book_id == bb.book_id))
         .Select(bb => new
         {
             BookTitle = bb.Books.title,
             DueDate = bb.dates_must_return
         })
         .ToList();

            dataGridView1.DataSource = unreturnedBooks;
            if (!dataGridView1.Columns.Contains("ReturnButton"))
            {
                DataGridViewButtonColumn returnButtonColumn = new DataGridViewButtonColumn();
                returnButtonColumn.Name = "ReturnButton";
                returnButtonColumn.HeaderText = "Сдать книгу";
                returnButtonColumn.Text = "Сдать книгу";
                returnButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(returnButtonColumn);
            }

            // Добавляем названия колонок "Название книги" и "Дата сдачи книги"
            dataGridView1.Columns["BookTitle"].HeaderText = "Название книги";
            dataGridView1.Columns["DueDate"].HeaderText = "Дата сдачи книги";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                string reader = listBox2.SelectedItem.ToString();
                _reader = _context.Readers.Where(R => R.first_name + " " + R.last_name == reader).FirstOrDefault();

                if (_reader != null)
                {
                    LoadUnreturnedBooks(_reader.id);
                    DataTable dataTable1 = new DataTable();
                    dataTable1.Columns.Add("Имя");
                    dataTable1.Columns.Add(_reader.first_name);
                    dataTable1.Rows.Add("Фамилия", _reader.last_name);
                    dataTable1.Rows.Add("День рождения", _reader.birthday.ToShortDateString());
                    dataTable1.Rows.Add("Номер телефона", _reader.phone_number.ToString());
                    dataGridView2.DataSource = dataTable1;
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ReturnButton"].Index)
            {
                string bookTitle = dataGridView1.Rows[e.RowIndex].Cells["BookTitle"].Value.ToString();

                var book = _context.Books.FirstOrDefault(b => b.title == bookTitle);
                if (book != null)
                {
                    ReturnedBooks returnedBook = new ReturnedBooks
                    {
                        returned_book_id = _context.ReturnedBooks.Max(rb => rb.returned_book_id) + 1,
                        reader_id = _reader.id,
                        book_id = book.id,
                        librarian_id = _user.id,
                        dates_return = DateTime.Now
                    };
                    book.quantity += 1;
                    _context.ReturnedBooks.Add(returnedBook);
                    _context.SaveChanges();
                    // Показываем сообщение о сдаче книги
                    string readerName = _reader.first_name + " " + _reader.last_name;
                    MessageBox.Show($"Книга \"{bookTitle}\" сдана читателем {readerName} {DateTime.Now}");
                    LoadUnreturnedBooks(_reader.id);
                }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            MainW mainW = new MainW(new librariesEntities(), _user);
            Hide();
            mainW.Show();
        }
    }
}
