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
    public partial class AddBookW : Form
    {
        private readonly librariesEntities _context;
        private readonly Librarians _user;
        public AddBookW(librariesEntities context, Librarians user)
        {
            InitializeComponent();
            _user = user;
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
            FillComboBoxes();
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

        private void ClearFields()
        {
            textBox_title.Text = "";
            comboBoxAuthor.SelectedIndex = -1;
            comboBoxPublishing.SelectedIndex = -1;
            textBox_year.Text = "";
            comboBoxGenre.SelectedIndex = -1;
            textBox_quantity.Text = "";
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            int books = (int)_context.Books.Max(B => B.id);
            if (!ValidateInput()) return;
            Books book = new Books
            {
                id = books + 1,
                title = textBox_title.Text,
                author_id = GetIdFromName(comboBoxAuthor.Text, "Authors"),
                publishing_id = GetIdFromName(comboBoxPublishing.Text, "Publishing"),
                release_year = int.Parse(textBox_year.Text),
                genre_id = GetIdFromName(comboBoxGenre.Text, "Genres"),
                quantity = int.Parse(textBox_quantity.Text),
                status = "Available"
            };

            if (_context.Books.Any(b => b.title == book.title && b.release_year == book.release_year))
            {
                MessageBox.Show("Книга уже существует.");
                return;
            }

            _context.Books.Add(book);
            _context.SaveChanges();

            MessageBox.Show("Книга успешно добавлена.");
            ClearFields();
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
                        author = new Authors { id= auth + 1, full_name = name };
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
                        publishing = new Publishing { id = p+1, name = name };
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
                        genre = new Genres { id=g+1, genre = name };
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

            foreach (char c in textBox_title.Text)
            {
                if (!char.IsLetter(c) || !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Ввод должен содержать только английские символы.");
                    return false;
                }
            }

            foreach (char c in comboBoxAuthor.Text)
            {
                if (!char.IsLetter(c) || !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Ввод должен содержать только английские символы.");
                    return false;
                }
            }

            foreach (char c in comboBoxGenre.Text)
            {
                if (!char.IsLetter(c) || !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Ввод должен содержать только английские символы.");
                    return false;
                }
            }

            foreach (char c in comboBoxPublishing.Text)
            {
                if (!char.IsLetter(c) || !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Ввод должен содержать только английские символы.");
                    return false;
                }
            }

            return true;
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            MainW main = new MainW(new librariesEntities(), _user);
            Hide();
            main.ShowDialog();
        }
    }
}
