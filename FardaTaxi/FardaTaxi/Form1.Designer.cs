namespace FardaTaxi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ابزارToolStripMenuItem = new ToolStripMenuItem();
            مشترکانToolStripMenuItem = new ToolStripMenuItem();
            رانندگانToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ابزارToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ابزارToolStripMenuItem
            // 
            ابزارToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { مشترکانToolStripMenuItem, رانندگانToolStripMenuItem });
            ابزارToolStripMenuItem.Name = "ابزارToolStripMenuItem";
            ابزارToolStripMenuItem.Size = new Size(47, 24);
            ابزارToolStripMenuItem.Text = "ابزار";
            // 
            // مشترکانToolStripMenuItem
            // 
            مشترکانToolStripMenuItem.Name = "مشترکانToolStripMenuItem";
            مشترکانToolStripMenuItem.Size = new Size(224, 26);
            مشترکانToolStripMenuItem.Text = "مشترکان";
            // 
            // رانندگانToolStripMenuItem
            // 
            رانندگانToolStripMenuItem.Name = "رانندگانToolStripMenuItem";
            رانندگانToolStripMenuItem.Size = new Size(224, 26);
            رانندگانToolStripMenuItem.Text = "رانندگان";
            رانندگانToolStripMenuItem.Click += رانندگانToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "فردا تاکسی";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ابزارToolStripMenuItem;
        private ToolStripMenuItem مشترکانToolStripMenuItem;
        private ToolStripMenuItem رانندگانToolStripMenuItem;
    }
}