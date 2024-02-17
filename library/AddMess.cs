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
    public partial class AddMess : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        public AddMess(librariesEntities context, Librarians user)
        {
            InitializeComponent();
            _user = user;
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            AddAuthW auth = new AddAuthW(new librariesEntities(), _user);
            Hide();
            auth.ShowDialog();
        }

        private void button_book_Click(object sender, EventArgs e)
        {
            AddBookW book = new AddBookW(new librariesEntities(), _user);
            Hide();
            book.ShowDialog();
        }
    }
}
