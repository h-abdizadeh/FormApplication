namespace FardaTaxi
{
    partial class AddUserForm
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
            textLanme = new TextBox();
            textPhone = new TextBox();
            textAddress = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // textFname
            // 
            textFname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textFname.Location = new Point(51, 53);
            textFname.MaxLength = 15;
            textFname.Name = "textFname";
            textFname.PlaceholderText = "نام";
            textFname.RightToLeft = RightToLeft.Yes;
            textFname.Size = new Size(233, 34);
            textFname.TabIndex = 0;
            // 
            // textLanme
            // 
            textLanme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textLanme.Location = new Point(51, 93);
            textLanme.MaxLength = 25;
            textLanme.Name = "textLanme";
            textLanme.PlaceholderText = "نام خانوادگی";
            textLanme.RightToLeft = RightToLeft.Yes;
            textLanme.Size = new Size(233, 34);
            textLanme.TabIndex = 1;
            // 
            // textPhone
            // 
            textPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPhone.Location = new Point(51, 133);
            textPhone.MaxLength = 11;
            textPhone.Name = "textPhone";
            textPhone.PlaceholderText = "شماره تماس";
            textPhone.RightToLeft = RightToLeft.Yes;
            textPhone.Size = new Size(233, 34);
            textPhone.TabIndex = 2;
            // 
            // textAddress
            // 
            textAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textAddress.Location = new Point(51, 173);
            textAddress.MaxLength = 250;
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.PlaceholderText = "نشانی";
            textAddress.RightToLeft = RightToLeft.Yes;
            textAddress.Size = new Size(233, 142);
            textAddress.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(51, 363);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "ثبت";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 450);
            Controls.Add(btnSubmit);
            Controls.Add(textAddress);
            Controls.Add(textPhone);
            Controls.Add(textLanme);
            Controls.Add(textFname);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ثبت مشترک جدید";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFname;
        private TextBox textLanme;
        private TextBox textPhone;
        private TextBox textAddress;
        private Button btnSubmit;
    }
}