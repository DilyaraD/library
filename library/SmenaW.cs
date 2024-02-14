using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace library
{
    public partial class SmenaW : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        public SmenaW(librariesEntities context, Librarians user)
        {
            InitializeComponent();
            _user = user;
            _context = context;
        }

        private void button_yes_Click(object sender, EventArgs e)
        {
            int shift_number = (int)_context.Shifts.Max(S => S.shift_number);
            DateTime r= DateTime.Now;

            var Shift = new Shifts
            {
                shift_number = shift_number + 1,
                start_time = DateTime.Now,
                end_time = r.AddHours(8),
                librarian_id = _user.id,
        };
            _context.Shifts.Add(Shift);
            _context.SaveChanges();

            MessageBox.Show("Ваша смена началась! Хорошего дня!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void button_no_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
