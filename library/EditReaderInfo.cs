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
    public partial class EditReaderInfo : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        private readonly Readers _reader;
        public EditReaderInfo(librariesEntities context, Librarians user, Readers reader)
        {
            InitializeComponent();
            _reader = reader;
            _user = user;
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
            FillReaderInfo();
        }

        void FillReaderInfo()
        {
            textBox_fname.Text = _reader.first_name;
            textBox_lname.Text = _reader.last_name;
            phoneNumberTextBox.Text = _reader.phone_number;
            dateTimePicker1.Value = _reader.birthday.Date;
        }

        private void button_edite_Click(object sender, EventArgs e)
        {
            string firstName = textBox_fname.Text;
            string lastName = textBox_lname.Text;
            string phoneNumber = phoneNumberTextBox.Text;

            if (!IsAllEnglish(firstName) || !IsAllEnglish(lastName))
            {
                MessageBox.Show("Имя и фамилия должны содержать только английские буквы");
                return;
            }

            if (phoneNumber.Length != 11 || !phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Номер телефона должен состоять из 11 цифр");
                return;
            }

            _reader.first_name = firstName;
            _reader.last_name = lastName;
            _reader.phone_number = phoneNumber;

            _context.SaveChanges();

            MessageBox.Show("Данные читателя успешно обновлены");
            Close();
        }

        private bool IsAllEnglish(string text)
        {
            return text.All(c => (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'));
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ReaderInfo info = new ReaderInfo(new librariesEntities(), _user, _reader);
            Hide();
            info.ShowDialog();
        }
    }
}
