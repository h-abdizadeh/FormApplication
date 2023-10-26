using FardaTaxi.Models;

namespace FardaTaxi;

public partial class AddUserForm : Form
{
    public AddUserForm()
    {
        InitializeComponent();
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        var user = new User()
        {
            Id = new Random().Next(100, 1000),
            Fname = textFname.Text,
            Lname = textLanme.Text,
            Phone = textPhone.Text,
            Address = textAddress.Text,
        };

        var result = new Manage().AddUser(user);

        if (result)
            MessageBox.Show("ثبت موفق");
        else
            MessageBox.Show("خطا در ثبت");
    }
}
