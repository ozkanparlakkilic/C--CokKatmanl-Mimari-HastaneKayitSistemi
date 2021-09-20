
namespace HastaneInfo.WebFormsUI.PersonelForms
{
    partial class AddPersonelForm
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
            this.grbPersonel = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPersonelPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPersonelTcNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPersonelEmail = new System.Windows.Forms.TextBox();
            this.dtpAddPersonel = new System.Windows.Forms.DateTimePicker();
            this.btnAddPersonel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbPersonelWoman = new System.Windows.Forms.RadioButton();
            this.rbPersonelMan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersonelNationality = new System.Windows.Forms.ComboBox();
            this.txtPersonelSurname = new System.Windows.Forms.TextBox();
            this.txtPersonelName = new System.Windows.Forms.TextBox();
            this.grbPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPersonel
            // 
            this.grbPersonel.Controls.Add(this.label9);
            this.grbPersonel.Controls.Add(this.txtPersonelPassword);
            this.grbPersonel.Controls.Add(this.label8);
            this.grbPersonel.Controls.Add(this.txtPersonelTcNo);
            this.grbPersonel.Controls.Add(this.label7);
            this.grbPersonel.Controls.Add(this.txtPersonelEmail);
            this.grbPersonel.Controls.Add(this.dtpAddPersonel);
            this.grbPersonel.Controls.Add(this.btnAddPersonel);
            this.grbPersonel.Controls.Add(this.label5);
            this.grbPersonel.Controls.Add(this.rbPersonelWoman);
            this.grbPersonel.Controls.Add(this.rbPersonelMan);
            this.grbPersonel.Controls.Add(this.label4);
            this.grbPersonel.Controls.Add(this.label3);
            this.grbPersonel.Controls.Add(this.label2);
            this.grbPersonel.Controls.Add(this.label1);
            this.grbPersonel.Controls.Add(this.cmbPersonelNationality);
            this.grbPersonel.Controls.Add(this.txtPersonelSurname);
            this.grbPersonel.Controls.Add(this.txtPersonelName);
            this.grbPersonel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonel.Location = new System.Drawing.Point(175, 85);
            this.grbPersonel.Name = "grbPersonel";
            this.grbPersonel.Size = new System.Drawing.Size(473, 475);
            this.grbPersonel.TabIndex = 4;
            this.grbPersonel.TabStop = false;
            this.grbPersonel.Text = "ADD PERSONEL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "PASSWORD";
            // 
            // txtPersonelPassword
            // 
            this.txtPersonelPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtPersonelPassword.Location = new System.Drawing.Point(246, 220);
            this.txtPersonelPassword.Name = "txtPersonelPassword";
            this.txtPersonelPassword.PasswordChar = '*';
            this.txtPersonelPassword.Size = new System.Drawing.Size(121, 26);
            this.txtPersonelPassword.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "TC NO";
            // 
            // txtPersonelTcNo
            // 
            this.txtPersonelTcNo.Location = new System.Drawing.Point(245, 53);
            this.txtPersonelTcNo.Name = "txtPersonelTcNo";
            this.txtPersonelTcNo.Size = new System.Drawing.Size(121, 26);
            this.txtPersonelTcNo.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "EMAIL";
            // 
            // txtPersonelEmail
            // 
            this.txtPersonelEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtPersonelEmail.Location = new System.Drawing.Point(245, 180);
            this.txtPersonelEmail.Name = "txtPersonelEmail";
            this.txtPersonelEmail.Size = new System.Drawing.Size(121, 26);
            this.txtPersonelEmail.TabIndex = 18;
            // 
            // dtpAddPersonel
            // 
            this.dtpAddPersonel.Location = new System.Drawing.Point(245, 256);
            this.dtpAddPersonel.Name = "dtpAddPersonel";
            this.dtpAddPersonel.Size = new System.Drawing.Size(119, 26);
            this.dtpAddPersonel.TabIndex = 16;
            // 
            // btnAddPersonel
            // 
            this.btnAddPersonel.Location = new System.Drawing.Point(157, 391);
            this.btnAddPersonel.Name = "btnAddPersonel";
            this.btnAddPersonel.Size = new System.Drawing.Size(132, 46);
            this.btnAddPersonel.TabIndex = 3;
            this.btnAddPersonel.Text = "Add Personel";
            this.btnAddPersonel.UseVisualStyleBackColor = true;
            this.btnAddPersonel.Click += new System.EventHandler(this.btnAddPersonel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "YEAR_OF_BIRTH";
            // 
            // rbPersonelWoman
            // 
            this.rbPersonelWoman.AutoSize = true;
            this.rbPersonelWoman.Location = new System.Drawing.Point(315, 342);
            this.rbPersonelWoman.Name = "rbPersonelWoman";
            this.rbPersonelWoman.Size = new System.Drawing.Size(87, 23);
            this.rbPersonelWoman.TabIndex = 10;
            this.rbPersonelWoman.TabStop = true;
            this.rbPersonelWoman.Text = "Woman";
            this.rbPersonelWoman.UseVisualStyleBackColor = true;
            // 
            // rbPersonelMan
            // 
            this.rbPersonelMan.AutoSize = true;
            this.rbPersonelMan.Location = new System.Drawing.Point(245, 342);
            this.rbPersonelMan.Name = "rbPersonelMan";
            this.rbPersonelMan.Size = new System.Drawing.Size(63, 23);
            this.rbPersonelMan.TabIndex = 9;
            this.rbPersonelMan.TabStop = true;
            this.rbPersonelMan.Text = "Man";
            this.rbPersonelMan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "NATIONALITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "SURNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME";
            // 
            // cmbPersonelNationality
            // 
            this.cmbPersonelNationality.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonelNationality.FormattingEnabled = true;
            this.cmbPersonelNationality.Items.AddRange(new object[] {
            "TURKEY",
            "FRANCE",
            "UNITED KINGDOM"});
            this.cmbPersonelNationality.Location = new System.Drawing.Point(246, 300);
            this.cmbPersonelNationality.Name = "cmbPersonelNationality";
            this.cmbPersonelNationality.Size = new System.Drawing.Size(121, 23);
            this.cmbPersonelNationality.TabIndex = 2;
            // 
            // txtPersonelSurname
            // 
            this.txtPersonelSurname.Location = new System.Drawing.Point(245, 138);
            this.txtPersonelSurname.Name = "txtPersonelSurname";
            this.txtPersonelSurname.Size = new System.Drawing.Size(121, 26);
            this.txtPersonelSurname.TabIndex = 1;
            // 
            // txtPersonelName
            // 
            this.txtPersonelName.Location = new System.Drawing.Point(245, 94);
            this.txtPersonelName.Name = "txtPersonelName";
            this.txtPersonelName.Size = new System.Drawing.Size(121, 26);
            this.txtPersonelName.TabIndex = 0;
            // 
            // AddPersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 690);
            this.Controls.Add(this.grbPersonel);
            this.Name = "AddPersonelForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddPersonelForm_Load);
            this.grbPersonel.ResumeLayout(false);
            this.grbPersonel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPersonelEmail;
        private System.Windows.Forms.DateTimePicker dtpAddPersonel;
        private System.Windows.Forms.Button btnAddPersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbPersonelWoman;
        private System.Windows.Forms.RadioButton rbPersonelMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPersonelNationality;
        private System.Windows.Forms.TextBox txtPersonelSurname;
        private System.Windows.Forms.TextBox txtPersonelName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPersonelTcNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPersonelPassword;
    }
}