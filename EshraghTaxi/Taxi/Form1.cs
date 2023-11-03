using Taxi.Database;
using Taxi.Models;

namespace Taxi;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        dataGridView1.DataSource = new Manage().ShowUsers();
        DataGridTitle();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var form = new AddForm();
        form.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        dataGridView1.DataSource = new Manage().ShowUsers();
        DataGridTitle();
    }

    private void DataGridTitle()
    {
        dataGridView1.Columns[0].HeaderText = "ردیف";
        dataGridView1.Columns[1].HeaderText = "نام";
        dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
        dataGridView1.Columns[3].HeaderText = "موبایل";
        dataGridView1.Columns[4].HeaderText = "اشتراک";
        dataGridView1.Columns[5].HeaderText = "نشانی";
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        dataGridView1.DataSource = new Manage().ShowUsers(textBox1.Text);
        DataGridTitle();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        //MessageBox.Show("content");
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
        //MessageBox.Show(sender.ToString());
        //MessageBox.Show(e.ToString());
        try
        {
            var id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //MessageBox.Show(id.ToString());

            //var result = new Manage().DeleteUser(id);
            //if(result)

            if (new Manage().DeleteUser(id))
            {
                MessageBox.Show("با موفقیت حذف شد");
                dataGridView1.DataSource = new Manage().ShowUsers();
                DataGridTitle();
            }
            else
                MessageBox.Show("حذف ناموفق");

        }
        catch (Exception)
        {

            //throw;
            MessageBox.Show("سطر مورد نظر را انتخاب کنید");
        }


    }

    private async void editMenuItem_Click(object sender, EventArgs e)
    {
        //MessageBox.Show(id.ToString());
        try
        {
            var id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            var user = await new Manage().GetUser(id);

            var form = new AddForm();
            form.tmpUser = user;
            form.ShowDialog();
        }
        catch (Exception)
        {

            //throw;
            MessageBox.Show("سطر را انتخاب کنید");
        }
    }

    private void dataGridView1_DoubleClick(object sender, EventArgs e)
    {

    }

    private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            var id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            var user = await new Manage().GetUser(id);

            var userInfo = $"{user.Fname} \n" +
                $"{user.Lname} \n" +
                $"{user.Mobile} \n" +
                $"{user.Address} \n";

            MessageBox.Show(userInfo);
        }
        catch (Exception)
        {

            //throw;
            MessageBox.Show("سطر را انتخاب کنید");
        }
    }
}