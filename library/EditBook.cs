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
    public partial class EditBook : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        private readonly Books _book;
        public EditBook(librariesEntities context, Librarians user, Books book)
        {
            InitializeComponent();
            _user = user;
            _book = book;
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
            FillComboBoxes();
            FillBook();
        }

        void FillBook()
        {
            textBox_title.Text = _book.title;
            comboBoxAuthor.Text = _book.Authors.full_name;
            comboBoxGenre.Text = _book.Genres.genre;
            comboBoxPublishing.Text = _book.Publishing.name;
            textBox_year.Text = _book.release_year.ToString();
            textBox_quantity.Text=_book.quantity.ToString();    
        }

        private void FillComboBoxes()
        {
            foreach (var genre in _context.Genres)
            {
                comboBoxGenre.Items.Add(genre.genre);
            }

            int selectionStart;
            comboBoxAuthor.TextChanged += (sender, e) =>
            {
                selectionStart = comboBoxAuthor.SelectionStart;
                string inputText = comboBoxAuthor.Text.ToLower();
                comboBoxAuthor.Items.Clear();

                foreach (var author in _context.Authors)
                {
                    if (author.full_name.ToLower().Contains(inputText))
                    {
                        comboBoxAuthor.Items.Add(author.full_name);
                    }
                }

                comboBoxAuthor.DroppedDown = true;
                comboBoxAuthor.SelectionStart = selectionStart;
            };


            foreach (var publishing in _context.Publishing)
            {
                comboBoxPublishing.Items.Add(publishing.name);
            }
        }

        private int GetIdFromName(string name, string tableName)
        {
            int id = 0;
            switch (tableName)
            {
                case "Authors":
                    int auth = (int)_context.Authors.Max(B => B.id);
                    Authors author = _context.Authors.FirstOrDefault(a => a.full_name == name);
                    if (author == null)
                    {
                        author = new Authors { id = auth + 1, full_name = name };
                        _context.Authors.Add(author);
                        _context.SaveChanges();
                    }
                    id = author.id;
                    break;

                case "Publishing":
                    int p = (int)_context.Publishing.Max(P => P.id);
                    Publishing publishing = _context.Publishing.FirstOrDefault(P => P.name == name);
                    if (publishing == null)
                    {
                        publishing = new Publishing { id = p + 1, name = name };
                        _context.Publishing.Add(publishing);
                        _context.SaveChanges();
                    }
                    id = publishing.id;
                    break;

                case "Genres":
                    Genres genre = _context.Genres.FirstOrDefault(G => G.genre == name);
                    int g = (int)_context.Genres.Max(G => G.id);
                    if (genre == null)
                    {
                        genre = new Genres { id = g + 1, genre = name };
                        _context.Genres.Add(genre);
                        _context.SaveChanges();
                    }
                    id = genre.id;
                    break;

                default:
                    break;
            }

            return id;
        }


        private void button_back_Click(object sender, EventArgs e)
        {

            MainW main = new MainW(new librariesEntities(), _user);
            Hide();
            main.ShowDialog();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox_title.Text) || string.IsNullOrWhiteSpace(textBox_year.Text))
            {
                MessageBox.Show("Введите название книги и год выпуска.");
                return false;
            }

            if (!int.TryParse(textBox_quantity.Text, out _))
            {
                MessageBox.Show("Введите корректное количество экземпляров книги.");
                return false;
            }

            if (!int.TryParse(textBox_year.Text, out _))
            {
                MessageBox.Show("Введите корректный год выпуска.");
                return false;
            }

            if (!Regex.IsMatch(textBox_title.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Название книги должно содержать только буквы и цифры на английском.");
                return false;
            }

            if (!Regex.IsMatch(comboBoxAuthor.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Имя автора должно содержать только буквы на английском.");
                return false;
            }

            if (!Regex.IsMatch(comboBoxGenre.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Жанр должен содержать только буквы на английском.");
                return false;
            }

            if (!Regex.IsMatch(comboBoxPublishing.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Издательство должно содержать только буквы на английском.");
                return false;
            }

            return true;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (_book != null)
            {
                _book.title = textBox_title.Text;
                _book.author_id = GetIdFromName(comboBoxAuthor.Text, "Authors");
                _book.publishing_id = GetIdFromName(comboBoxPublishing.Text, "Publishing");
                _book.release_year = int.Parse(textBox_year.Text);
                _book.genre_id = GetIdFromName(comboBoxGenre.Text, "Genres");
                _book.quantity = int.Parse(textBox_quantity.Text);

                _context.SaveChanges();

                MessageBox.Show("Данные книги изменены.");
                Close();
            }
            else
            {
                MessageBox.Show("Книга с таким ID не найдена.");
            }
        }
    }
}
