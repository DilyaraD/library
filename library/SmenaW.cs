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
    public partial class SmenaW : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        public SmenaW(librariesEntities context, Librarians user)
        {
            InitializeComponent();
            _context = context;
        }

        private void button_yes_Click(object sender, EventArgs e)
        {

        }

        private void button_no_Click(object sender, EventArgs e)
        {

        }
    }
}
