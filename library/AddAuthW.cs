using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class AddAuthW : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        public AddAuthW(librariesEntities context, Librarians user)
        {
            InitializeComponent();
            _user = user;
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ClearFields()
        {
            textBox_fname.Text = "";
            textBox_lname.Text = "";
            phoneNumberTextBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTextBox.Text;
            if (!Regex.IsMatch(textBox_fname.Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(textBox_lname.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Имя и фамилия должны содержать только английские символы");
                return;
            }
            if (phoneNumber.Length != 11)
            {
                MessageBox.Show("Номер телефона должен содержать 11 цифр");
                foreach (char c in phoneNumber)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("Номер телефона должен содержать только цифры");
                        return;
                    }
                }
            }
            else
            {
                int readers = (int)_context.Readers.Max(R => R.id);
                Readers reader = new Readers
                {
                    id = readers + 1,
                    first_name = textBox_fname.Text,
                    last_name = textBox_lname.Text,
                    birthday = Convert.ToDateTime(dateTimePicker1.Value),
                    phone_number = phoneNumber.ToString()
                };

                if (_context.Readers.Any(R => R.first_name == reader.first_name && R.last_name == reader.last_name && R.birthday == reader.birthday))
                {
                    MessageBox.Show("Читатель уже есть в бд.");
                    return;
                }
                else
                {
                    _context.Readers.Add(reader);
                    _context.SaveChanges();

                    MessageBox.Show("Читатель успешно добавлен.");
                    ClearFields();
                }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            
                MainW main = new MainW(new librariesEntities(), _user);
                Hide();
                main.ShowDialog();
            
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
