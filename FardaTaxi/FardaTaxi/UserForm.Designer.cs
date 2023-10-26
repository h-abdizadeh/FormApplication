namespace FardaTaxi
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            textSearch = new TextBox();
            btnUsers = new Button();
            btnAddUser = new Button();
            dataGridView1 = new DataGridView();
            dataGridMenu = new ContextMenuStrip(components);
            deleteMenu = new ToolStripMenuItem();
            editMenu = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            dataGridMenu.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textSearch);
            groupBox1.Location = new Point(177, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(433, 91);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // textSearch
            // 
            textSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSearch.Location = new Point(11, 32);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "شماره اشتراک یا نام خانوادگی";
            textSearch.Size = new Size(411, 34);
            textSearch.TabIndex = 0;
            textSearch.TextAlign = HorizontalAlignment.Center;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsers.Location = new Point(12, 21);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(159, 40);
            btnUsers.TabIndex = 1;
            btnUsers.Text = "نمایش مشترکان";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUser.Location = new Point(12, 63);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(159, 40);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "ثبت مشترک جدید";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = dataGridMenu;
            dataGridView1.Location = new Point(12, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(592, 578);
            dataGridView1.TabIndex = 3;
            // 
            // dataGridMenu
            // 
            dataGridMenu.ImageScalingSize = new Size(20, 20);
            dataGridMenu.Items.AddRange(new ToolStripItem[] { deleteMenu, editMenu });
            dataGridMenu.Name = "dataGridMenu";
            dataGridMenu.Size = new Size(125, 52);
            // 
            // deleteMenu
            // 
            deleteMenu.Name = "deleteMenu";
            deleteMenu.Size = new Size(124, 24);
            deleteMenu.Text = "حذف";
            deleteMenu.Click += deleteMenu_Click;
            // 
            // editMenu
            // 
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(210, 24);
            editMenu.Text = "ویرایش";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(32, 19);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(32, 19);
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 713);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddUser);
            Controls.Add(btnUsers);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "UserForm";
            Text = "مشترکان";
            Load += UserForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            dataGridMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textSearch;
        private Button btnUsers;
        private Button btnAddUser;
        private DataGridView dataGridView1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ContextMenuStrip dataGridMenu;
        private ToolStripMenuItem deleteMenu;
        private ToolStripMenuItem editMenu;
    }
}