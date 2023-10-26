namespace FardaTaxi
{
    partial class DriverForm
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
            dataGridView1 = new DataGridView();
            btnAddDriver = new Button();
            btnDrivers = new Button();
            groupBox1 = new GroupBox();
            textSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(592, 578);
            dataGridView1.TabIndex = 7;
            // 
            // btnAddDriver
            // 
            btnAddDriver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddDriver.Location = new Point(12, 63);
            btnAddDriver.Name = "btnAddDriver";
            btnAddDriver.Size = new Size(159, 40);
            btnAddDriver.TabIndex = 6;
            btnAddDriver.Text = "ثبت راننده جدید";
            btnAddDriver.UseVisualStyleBackColor = true;
            // 
            // btnDrivers
            // 
            btnDrivers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDrivers.Location = new Point(12, 21);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(159, 40);
            btnDrivers.TabIndex = 5;
            btnDrivers.Text = "نمایش رانندگان";
            btnDrivers.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textSearch);
            groupBox1.Location = new Point(177, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(433, 91);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // textSearch
            // 
            textSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSearch.Location = new Point(11, 32);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "کد راننده یا نام خانوادگی";
            textSearch.Size = new Size(411, 34);
            textSearch.TabIndex = 0;
            textSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // DriverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 713);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddDriver);
            Controls.Add(btnDrivers);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "DriverForm";
            Text = "رانندگان";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddDriver;
        private Button btnDrivers;
        private GroupBox groupBox1;
        private TextBox textSearch;
    }
}