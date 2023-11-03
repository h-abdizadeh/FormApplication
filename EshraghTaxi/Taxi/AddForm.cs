
using Taxi.Database;
using Taxi.Models;

namespace Taxi;

public partial class AddForm : Form
{
    public AddForm()
    {
        InitializeComponent();
    }
    public User tmpUser { get; set; }

    private void btnAdd_Click(object sender, EventArgs e)
    {

        if (btnAdd.Text == "ویرایش")
        {
            var user = new User()
            {
                Id = tmpUser.Id,
                Fname = textFname.Text,
                Lname = textLname.Text,
                Mobile = textMobile.Text,
                Address = textAddress.Text,
                Code = tmpUser.Code,
            };

            var result = new Manage().EdiUser(user);
            if (result)
                MessageBox.Show("ویرایش موفق");
            else
                MessageBox.Show("ویرایش ناموفق");
        }
        else
        {
            //1: connect to dbcontext
            using (var context = new DatabaseContext())
            {
                //2: create model
                var user = new User()
                {
                    Fname = textFname.Text,
                    Lname = textLname.Text,
                    Mobile = textMobile.Text,
                    Address = textAddress.Text,
                    Code = new Random().Next(100, 1000).ToString()
                };

                //3: add to db
                context.Users.Add(user);

                //4: save db
                context.SaveChanges();
            }
        }

    }

    private void AddForm_Load(object sender, EventArgs e)
    {
        if (tmpUser != null)
        {
            textFname.Text = tmpUser.Fname;
            textLname.Text = tmpUser.Lname;
            textMobile.Text = tmpUser.Mobile;
            textAddress.Text = tmpUser.Address;


            btnAdd.Text = "ویرایش";
        }
    }
}
