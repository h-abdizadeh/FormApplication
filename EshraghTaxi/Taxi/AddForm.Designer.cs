namespace Taxi
{
    partial class AddForm
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
            textFname = new TextBox();
            textMobile = new TextBox();
            textLname = new TextBox();
            textAddress = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // textFname
            // 
            textFname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textFname.Location = new Point(48, 41);
            textFname.MaxLength = 25;
            textFname.Name = "textFname";
            textFname.PlaceholderText = "نام";
            textFname.RightToLeft = RightToLeft.Yes;
            textFname.Size = new Size(264, 34);
            textFname.TabIndex = 0;
            // 
            // textMobile
            // 
            textMobile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textMobile.Location = new Point(48, 121);
            textMobile.MaxLength = 11;
            textMobile.Name = "textMobile";
            textMobile.PlaceholderText = "شماره موبایل";
            textMobile.RightToLeft = RightToLeft.Yes;
            textMobile.Size = new Size(264, 34);
            textMobile.TabIndex = 1;
            // 
            // textLname
            // 
            textLname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textLname.Location = new Point(48, 81);
            textLname.MaxLength = 25;
            textLname.Name = "textLname";
            textLname.PlaceholderText = "نام خانوادگی";
            textLname.RightToLeft = RightToLeft.Yes;
            textLname.Size = new Size(264, 34);
            textLname.TabIndex = 2;
            // 
            // textAddress
            // 
            textAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textAddress.Location = new Point(48, 161);
            textAddress.MaxLength = 210;
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.PlaceholderText = "آدرس";
            textAddress.RightToLeft = RightToLeft.Yes;
            textAddress.Size = new Size(264, 117);
            textAddress.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(48, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ثبت";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 390);
            Controls.Add(btnAdd);
            Controls.Add(textAddress);
            Controls.Add(textLname);
            Controls.Add(textMobile);
            Controls.Add(textFname);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ثبت مشترک جدید";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFname;
        private TextBox textMobile;
        private TextBox textLname;
        private TextBox textAddress;
        private Button btnAdd;
    }
}