using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi.Database;
using Taxi.Migrations;
using Taxi.Models;

namespace Taxi
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Image File(*.png;)|*.png"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = new Bitmap(openFile.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image logo=pictureBox1.BackgroundImage;

            var imgName = "AppLogo.png";
            var imgPath = "Images\\";

            if (!Directory.Exists(imgPath))
                Directory.CreateDirectory(imgPath);

            logo.Save(imgPath + imgName);

            using(var context=new DatabaseContext())
            {
                var setting = new Setting()
                {
                    Logo = imgName
                };

                context.Settings.Add(setting);
                context.SaveChanges();
            }
        }
    }
}
