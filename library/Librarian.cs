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
        }


    }
}
