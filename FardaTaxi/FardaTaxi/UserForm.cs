using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FardaTaxi
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var form = new AddUserForm();
            form.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var users = new Manage().GetUsers();
            dataGridView1.DataSource = users;
            DataGridTitle();

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            var users = new Manage().GetUsers();
            dataGridView1.DataSource = users;
            DataGridTitle();


        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Manage().GetUsers(textSearch.Text);
            DataGridTitle();
        }

        void DataGridTitle()
        {
            dataGridView1.Columns[0].HeaderText = "کد اشتراک";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[3].HeaderText = "موبایل";
            dataGridView1.Columns[4].HeaderText = "نشانی";

        }

        private void deleteMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                //MessageBox.Show(id.ToString());

                var result = new Manage().DeleteUser(id);
                if (result)
                {
                    MessageBox.Show("حذف موفق");
                    dataGridView1.DataSource=new Manage().GetUsers();
                    DataGridTitle();
                }
                else
                    MessageBox.Show("حذف ناموفق");

            }
            catch (Exception)
            {

                //throw;
                MessageBox.Show("سطر را انتخاب کنید");
            }
        }
    }
}
