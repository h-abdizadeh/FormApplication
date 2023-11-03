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
    public partial class AllBooksForm : Form
    {
        public AllBooksForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Manage().GetBooks();
            DataGridTitles();
        }

        private void DataGridTitles()
        {
            dataGridView1.Columns[0].HeaderText = "ردیف";
            dataGridView1.Columns[1].HeaderText = "عنوان";
            dataGridView1.Columns[2].HeaderText = "نویسنده";
            dataGridView1.Columns[3].HeaderText = "انتشارات";
            dataGridView1.Columns[4].HeaderText = "گروه";
            dataGridView1.Columns[5].HeaderText = "وضعیت";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                new Manage().GetBooks(textSearch.Text);

            DataGridTitles();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                var book = new Manage().GetBook(id);

                var form = new AddEditForm();
                form.tmpBook = book;
                form.ShowDialog();

            }
            catch (Exception)
            {

                //throw;

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                //MessageBox.Show(id.ToString());

                if (new Manage().DeleteBook(id))
                {
                    MessageBox.Show("حذف موفق");
                    dataGridView1.DataSource = new Manage().GetBooks();
                }
                else
                    MessageBox.Show("حذف ناموفق");
            }
            catch (Exception)
            {
                MessageBox.Show("سطر مورد نظر را انتخاب کنید");
                //throw;
            }
        }
    }
}
