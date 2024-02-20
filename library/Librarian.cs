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
    public partial class Librarian : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        public Librarian(librariesEntities context, Librarians user)
        {
            InitializeComponent();
            _context = context;
            _user = user;
            this.StartPosition = FormStartPosition.CenterScreen;
            Fill();
        }

        void Fill()
        {
            label_name.Text = _user.first_name.ToString();
            label_lname.Text = _user.last_name.ToString();
            label_address.Text = _user.addresss.ToString();
            label_phone.Text =_user.phone_number.ToString();
            label_birth.Text=_user.birthday.ToShortDateString();
            label_login.Text = _user.loginn.ToString();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            MainW main = new MainW(new librariesEntities(), _user);
            Hide();
            main.ShowDialog();
        }
    }
}
