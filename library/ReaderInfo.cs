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
    public partial class ReaderInfo : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        private readonly Readers _reader;
        public ReaderInfo(librariesEntities context, Librarians user, Readers reader)
        {
            InitializeComponent();
            _reader = reader;
            _user = user;
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
            FillReaderInfo();
            FillBorrowedBooks();
            FillReturnedBooks();
        }

        void FillReaderInfo()
        {
            label_name.Text = _reader.first_name;
            label_lname.Text = _reader.last_name;
            label_phone.Text = _reader.phone_number;
            label_year.Text = _reader.birthday.ToString("yyyy-MM-dd");
            label_chitticket.Text = _reader.id.ToString();
        }

        void FillBorrowedBooks()
        {
            var borrowedBooks = _context.BorrowedBooks.Where(b => b.reader_id == _reader.id)
                            .Select(b => new
                            {
                                b.dates_b,
                                book = b.Books.title,
                                b.dates_must_return
                            })
                            .FirstOrDefault();

            if (borrowedBooks != null)
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Книга");
                dataTable.Columns.Add("Дата выдачи");
                dataTable.Columns.Add("Дата возврата");
                dataTable.Rows.Add(borrowedBooks.book, borrowedBooks.dates_b.ToShortDateString(), borrowedBooks.dates_must_return.ToShortDateString());
                dataGridView_bbooks.DataSource = dataTable;
            }
            
        }

        void FillReturnedBooks()
        {
            var returnedBooks = _context.ReturnedBooks.Where(r => r.reader_id == _reader.id)
                .Select(b => new
                {
                    book = b.Books.title,
                    b.dates_return
                })
                            .FirstOrDefault();

            if (returnedBooks != null)
            {
                DataTable returnedBook = new DataTable();
                returnedBook.Columns.Add("Книга");
                returnedBook.Columns.Add("Дата возврата");
                returnedBook.Rows.Add(returnedBooks.book, returnedBooks.dates_return.ToShortDateString());
                dataGridView_rbooks.DataSource = returnedBook;
            }
           
        }


        private void button_edite_Click(object sender, EventArgs e)
        {
            EditReaderInfo editForm = new EditReaderInfo(_context, _user, _reader);
            editForm.ShowDialog();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ListReaders list = new ListReaders(new librariesEntities(), _user);
            Hide();
            list.ShowDialog();
        }
    }
}
