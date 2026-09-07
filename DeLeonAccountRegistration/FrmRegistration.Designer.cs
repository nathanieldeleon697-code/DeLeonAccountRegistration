namespace DeLeonAccountRegistration
{
    partial class FrmRegistration
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
            lblStudentNo = new Label();
            lblProgram = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblMiddleName = new Label();
            lblAge = new Label();
            lblContactNo = new Label();
            lblAddress = new Label();
            txtStudentNo = new TextBox();
            cbProgram = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            txtContactNo = new TextBox();
            txtAddress = new TextBox();
            btnNext = new Button();
            SuspendLayout();
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblStudentNo.Location = new Point(23, 27);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(112, 23);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "Student No.:";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblProgram.Location = new Point(251, 27);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(85, 23);
            lblProgram.TabIndex = 2;
            lblProgram.Text = "Program:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblLastName.Location = new Point(23, 107);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(94, 23);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblFirstName.Location = new Point(206, 107);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 23);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblMiddleName.Location = new Point(389, 107);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(119, 23);
            lblMiddleName.TabIndex = 8;
            lblMiddleName.Text = "Middle Name";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblAge.Location = new Point(23, 187);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(47, 23);
            lblAge.TabIndex = 10;
            lblAge.Text = "Age:";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblContactNo.Location = new Point(206, 187);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(110, 23);
            lblContactNo.TabIndex = 12;
            lblContactNo.Text = "Contact No.:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblAddress.Location = new Point(23, 267);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(74, 23);
            lblAddress.TabIndex = 14;
            lblAddress.Text = "Address";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Segoe UI", 9.75F);
            txtStudentNo.Location = new Point(23, 56);
            txtStudentNo.Margin = new Padding(3, 4, 3, 4);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(205, 29);
            txtStudentNo.TabIndex = 1;
            // 
            // cbProgram
            // 
            cbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProgram.Font = new Font("Segoe UI", 9.75F);
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Computer Science", "BS in Information Technology", "BS in Computer Engineering" });
            cbProgram.Location = new Point(251, 56);
            cbProgram.Margin = new Padding(3, 4, 3, 4);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(308, 29);
            cbProgram.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.75F);
            txtLastName.Location = new Point(23, 136);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(171, 29);
            txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.75F);
            txtFirstName.Location = new Point(206, 136);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(171, 29);
            txtFirstName.TabIndex = 7;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 9.75F);
            txtMiddleName.Location = new Point(389, 136);
            txtMiddleName.Margin = new Padding(3, 4, 3, 4);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(171, 29);
            txtMiddleName.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 9.75F);
            txtAge.Location = new Point(23, 216);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(171, 29);
            txtAge.TabIndex = 11;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI", 9.75F);
            txtContactNo.Location = new Point(206, 216);
            txtContactNo.Margin = new Padding(3, 4, 3, 4);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(171, 29);
            txtContactNo.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.75F);
            txtAddress.Location = new Point(23, 296);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(537, 132);
            txtAddress.TabIndex = 15;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 10F);
            btnNext.Location = new Point(234, 447);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(114, 40);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(587, 508);
            Controls.Add(btnNext);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtContactNo);
            Controls.Add(lblContactNo);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(cbProgram);
            Controls.Add(lblProgram);
            Controls.Add(txtStudentNo);
            Controls.Add(lblStudentNo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnNext;
    }
}