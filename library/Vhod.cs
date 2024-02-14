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

namespace library
{
    public partial class Vhod : Form
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_passw.Text;
            Librarians user;
            using (var context = new librariesEntities())
            {
                user = context.Librarians.FirstOrDefault(u => u.loginn == login && u.passwordd == password);
            }
            if (user != null)
            {
                MessageBox.Show("Вы успешно авторизовались!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainW mainw = new MainW(new librariesEntities(), user);
                Hide();
                mainw.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неправильный email или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
