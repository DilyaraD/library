﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class MainW : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        private readonly Books _book;
        private readonly Readers _reader;
        private System.Timers.Timer timer;
        public MainW(librariesEntities context, Librarians user)
        {
            InitializeComponent();
            _user = user;
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
            startsmena();
            Display();
        }

        private void startsmena () 
        {
            DateTime currentDate = DateTime.Now;
            var shift = _context.Shifts.FirstOrDefault(s => s.librarian_id == _user.id && s.start_time <= currentDate && s.end_time >= currentDate);
            if (shift != null)
            {
                //MessageBox.Show( "Вы вернулись!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else {
                SmenaW smw = new SmenaW(new librariesEntities(), _user);
                Hide();
                smw.ShowDialog();
            }
        }

        public void StartShiftTimer()
        {
            var currentDate = DateTime.Now;
            var shift = _context.Shifts.FirstOrDefault(s => s.librarian_id == _user.id && s.start_time <= currentDate && s.end_time >= currentDate);
            if (shift != null)
            {
                var startTime = shift.start_time;
                var timer = new System.Timers.Timer(1000);
                timer.Elapsed += (sender, e) =>
                {
                    var elapsed = DateTime.Now - startTime;
                    var hours = elapsed.Hours.ToString("00");
                    var minutes = elapsed.Minutes.ToString("00");
                    var seconds = elapsed.Seconds.ToString("00");
                    var timeString = $"{hours}:{minutes}:{seconds}"; 
                    
                    // Проверяем, что контрол все еще существует
                    if (label_smena.InvokeRequired)
                    {
                        label_smena.Invoke((MethodInvoker)delegate () 
                        { label_smena.Text = timeString; });
                    }
                    else
                    {
                        label_smena.Text = timeString;
                    }
                };
                timer.Start();
            }
        }

        public int CountUnreturnedBooks()
        {
            int unreturnedBooks = 0;
            foreach (var borrowedBook in _context.BorrowedBooks)
            {
                var returnedBook = _context.ReturnedBooks.FirstOrDefault(r => r.book_id == borrowedBook.book_id && r.reader_id == borrowedBook.reader_id);
                if (returnedBook == null)
                {
                    unreturnedBooks++;
                }
            }
            return unreturnedBooks;
        }

        private void Display()
        {
            label_librarian.Text = _user.first_name + " " + _user.last_name;
            label_date.Text = DateTime.Now.ToShortDateString();
            StartShiftTimer();
            int readers = (int)_context.Readers.Max(R => R.id);
            int totalBooks = _context.Books.Where(B=> B.status == "Available").Sum(b => b.quantity);
            label_Readers.Text = readers.ToString();
            int unreturnedBooksCount = CountUnreturnedBooks();
            label_BorBooks.Text=unreturnedBooksCount.ToString();
            int books = (int)_context.Books.Max(B => B.id);
            label_Books.Text=totalBooks.ToString();
        }

        private void button_poisk_Click(object sender, EventArgs e)
        {
            Poisk poisk = new Poisk(new librariesEntities(), _user);
            Hide();
            poisk.ShowDialog();
        }

        private void button_data_Click(object sender, EventArgs e)
        {
            AddMess mes = new AddMess(new librariesEntities(), _user);
            Hide();
            mes.ShowDialog();
        }

        private void button_readers_Click(object sender, EventArgs e)
        {
            ListReaders list = new ListReaders (new librariesEntities(), _user);
            Hide();
            list.ShowDialog();
        }

        private void button_brbooks_Click(object sender, EventArgs e)
        {
            BorrBooks brBooks = new BorrBooks(new librariesEntities(), _user);
            Hide();
            brBooks.ShowDialog();

        }

        private void label_librarian_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Librarian librarian = new Librarian(new librariesEntities(), _user);
            Hide();
            librarian.ShowDialog();
        }

        private void button_rtbooks_Click(object sender, EventArgs e)
        {
            RetBooks retBooks = new RetBooks(new librariesEntities(), _user);
            Hide();
            retBooks.ShowDialog();
        }
    }
}
