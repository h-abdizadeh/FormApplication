using BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AddEditForm : Form
    {
        public Book tmpBook { get; set; }
        public AddEditForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {


            var book = new Book()
            {
                Name = textName.Text,
                Writer = textWriter.Text,
                Publisher = textPublisher.Text,
                //Cover=??,
                GroupId =
                new Manage().GetGroupId((string)comboGroup.SelectedItem)
            };

            var manage = new Manage();

            if (buttonSubmit.Text == "ثبت")
            {
                //add book
                var result = manage.AddBook(book);

                if (result)
                    MessageBox.Show("ثبت موفق");
                else
                    MessageBox.Show("خطای ثبت");
            }
            else
            {
                book.Id = tmpBook.Id;
                book.NotExists = tmpBook.NotExists;

                var result = manage.EditBook(book);

                if (result)
                    MessageBox.Show("ویرایش موفق");
                else
                    MessageBox.Show("خطای ویرایش");
            }


        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            var groups = new Manage().GetGroups();

            foreach (var item in groups)
            {
                comboGroup.Items.Add(item.Name);
            }

            if (tmpBook != null)
            {
                textName.Text = tmpBook.Name;
                textWriter.Text = tmpBook.Writer;
                textPublisher.Text = tmpBook.Publisher;
                comboGroup.Text = new Manage().GetGroup(tmpBook.Id);

                buttonSubmit.Text = "ویرایش";
            }
        }

        private void buttonImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Image File(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox1.BackgroundImage = new Bitmap(openFile.FileName);
            }
        }
    }
}
