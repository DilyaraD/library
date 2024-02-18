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
    public partial class ListReaders : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        private Readers _reader;

        public ListReaders(librariesEntities context, Librarians user)
        {
            InitializeComponent();
            _user = user;
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
            FillContext();
            button1.Visible = false;
        }

        void FillContext() 
        {
            foreach (var readers in _context.Readers)
            {
                listBox1.Items.Add(readers.first_name + " " + readers.last_name);
            }
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            listBox1.Items.Clear();
            var results = _context.Readers.Where(R => R.first_name.Contains(searchText) || R.last_name.Contains(searchText)).ToList();
            foreach (var result in results)
            {
                listBox1.Items.Add(result.first_name + " " + result.last_name);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            MainW main = new MainW(new librariesEntities(), _user);
            Hide();
            main.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string reader = listBox1.SelectedItem.ToString();
                _reader = _context.Readers.Where(R => R.first_name + " " + R.last_name == reader).FirstOrDefault();

                if (_reader != null)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Имя");
                    dataTable.Columns.Add(_reader.first_name);
                    dataTable.Rows.Add("Фамилия", _reader.last_name);
                    dataTable.Rows.Add("День рождения", _reader.birthday.ToShortDateString());
                    dataTable.Rows.Add("Номер телефона", _reader.phone_number.ToString());
                    button1.Visible = true;
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_reader != null)
            {
                ReaderInfo r = new ReaderInfo(new librariesEntities(), _user, _reader);
                Hide();
                r.ShowDialog();
            }
        }
    }
}
