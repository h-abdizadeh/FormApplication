namespace BookStore
{
    partial class AddEditForm
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
            textName = new TextBox();
            textWriter = new TextBox();
            textPublisher = new TextBox();
            comboGroup = new ComboBox();
            buttonSubmit = new Button();
            buttonImg = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textName
            // 
            textName.BorderStyle = BorderStyle.FixedSingle;
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(57, 47);
            textName.Name = "textName";
            textName.PlaceholderText = "عنوان";
            textName.RightToLeft = RightToLeft.Yes;
            textName.Size = new Size(276, 34);
            textName.TabIndex = 0;
            // 
            // textWriter
            // 
            textWriter.BorderStyle = BorderStyle.FixedSingle;
            textWriter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textWriter.Location = new Point(57, 87);
            textWriter.Name = "textWriter";
            textWriter.PlaceholderText = "نویسنده";
            textWriter.RightToLeft = RightToLeft.Yes;
            textWriter.Size = new Size(276, 34);
            textWriter.TabIndex = 1;
            // 
            // textPublisher
            // 
            textPublisher.BorderStyle = BorderStyle.FixedSingle;
            textPublisher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPublisher.Location = new Point(57, 127);
            textPublisher.Name = "textPublisher";
            textPublisher.PlaceholderText = "انتشارات";
            textPublisher.RightToLeft = RightToLeft.Yes;
            textPublisher.Size = new Size(276, 34);
            textPublisher.TabIndex = 2;
            // 
            // comboGroup
            // 
            comboGroup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboGroup.FormattingEnabled = true;
            comboGroup.Location = new Point(57, 167);
            comboGroup.Name = "comboGroup";
            comboGroup.RightToLeft = RightToLeft.Yes;
            comboGroup.Size = new Size(276, 36);
            comboGroup.TabIndex = 3;
            comboGroup.Text = "انتخاب گروه";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(57, 629);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(276, 57);
            buttonSubmit.TabIndex = 4;
            buttonSubmit.Text = "ثبت";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonImg
            // 
            buttonImg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImg.Location = new Point(57, 209);
            buttonImg.Name = "buttonImg";
            buttonImg.Size = new Size(276, 57);
            buttonImg.TabIndex = 5;
            buttonImg.Text = "انتخاب تصویر";
            buttonImg.UseVisualStyleBackColor = true;
            buttonImg.Click += buttonImg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(57, 272);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 244);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 713);
            Controls.Add(pictureBox1);
            Controls.Add(buttonImg);
            Controls.Add(buttonSubmit);
            Controls.Add(comboGroup);
            Controls.Add(textPublisher);
            Controls.Add(textWriter);
            Controls.Add(textName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AddEditForm";
            Text = "ثبت و ویرایش کتاب ها";
            Load += AddEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private TextBox textWriter;
        private TextBox textPublisher;
        private ComboBox comboGroup;
        private Button buttonSubmit;
        private Button buttonImg;
        private PictureBox pictureBox1;
    }
}