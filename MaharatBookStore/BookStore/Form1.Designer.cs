namespace BookStore
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
            اToolStripMenuItem = new ToolStripMenuItem();
            ثبتکتابToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { اToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1109, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // اToolStripMenuItem
            // 
            اToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ثبتکتابToolStripMenuItem });
            اToolStripMenuItem.Name = "اToolStripMenuItem";
            اToolStripMenuItem.Size = new Size(47, 24);
            اToolStripMenuItem.Text = "ابزار";
            // 
            // ثبتکتابToolStripMenuItem
            // 
            ثبتکتابToolStripMenuItem.Name = "ثبتکتابToolStripMenuItem";
            ثبتکتابToolStripMenuItem.Size = new Size(224, 26);
            ثبتکتابToolStripMenuItem.Text = "ثبت کتاب";
            ثبتکتابToolStripMenuItem.Click += ثبتکتابToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 607);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "کتابسرای دانش";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem اToolStripMenuItem;
        private ToolStripMenuItem ثبتکتابToolStripMenuItem;
    }
}