using BookStore.Database;
using BookStore.Models;
namespace BookStore;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //1
        var form = new AllBooksForm();
        form.MdiParent = this;
        form.Show();
    }

    private void ثبتکتابToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new AddEditForm();
        form.MdiParent = this;
        form.Show();
    }
}