using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class DeleteBook : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        private readonly Books _book;
        public DeleteBook(librariesEntities context, Librarians user, Books book)
        {
            InitializeComponent();
            _context = context;
            _user = user;
            _book = book;
            Fill();
        }

        void Fill() 
        {
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

                var borrowedReaders = _context.BorrowedBooks.Where(b => b.book_id == _book.id)
                                                            .Where(b => !_context.ReturnedBooks.Any(r => r.book_id == b.book_id))
                                                            .Select(b => new
                                                            {
                                                                ReaderName = b.Readers.first_name,
                                                                ReaderName2 = b.Readers.last_name,
                                                                DatesB = b.dates_b,
                                                                DatesMustReturn = b.dates_must_return
                                                            })
                                                            .ToList();

                DataTable dataTable2 = new DataTable();
                dataTable2.Columns.Add("Читатель");
                dataTable2.Columns.Add("Дата выдачи");
                dataTable2.Columns.Add("Дата возврата");

                foreach (var reader in borrowedReaders)
                {
                    dataTable2.Rows.Add(reader.ReaderName + " " + reader.ReaderName2, reader.DatesB, reader.DatesMustReturn);
                }

                dataGridView2.DataSource = dataTable2;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 1)
            {
                MessageBox.Show("Не все книги еще сданы! Повторите попытку позже.");
            }
            else
            {
                var bookInContext = _context.Books.Find(_book.id);
                if (bookInContext != null)
                {
                    bookInContext.status = "Unavailable";
                    _context.SaveChanges();
                    MessageBox.Show("Книга списана!");
                    Close();
                    Poisk p = new Poisk(new librariesEntities(), _user);
                    p.Show();
                }
            }
        }
    }
}
