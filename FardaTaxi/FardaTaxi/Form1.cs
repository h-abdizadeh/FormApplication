namespace FardaTaxi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var usrFrm = new UserForm();
            usrFrm.MdiParent = this;
            usrFrm.Show();
        }

        private void —«‰‰œê«‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var drvFrm = new DriverForm();
            drvFrm.MdiParent = this;
            drvFrm.Show();
        }
    }
}