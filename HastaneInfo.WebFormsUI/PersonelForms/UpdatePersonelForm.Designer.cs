
namespace HastaneInfo.WebFormsUI.PersonelForms
{
    partial class UpdatePersonelForm
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
            this.dgwUpdatePersonel = new System.Windows.Forms.DataGridView();
            this.grbPersonel = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPersonelUpdatePassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdatePersonelTcNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdatePersonelEmail = new System.Windows.Forms.TextBox();
            this.dtpUpdatePersonel = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rbUpdatePersonelWoman = new System.Windows.Forms.RadioButton();
            this.rbUpdatePersonelMan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUpdatePersonelNationality = new System.Windows.Forms.ComboBox();
            this.txtUpdatePersonelSurname = new System.Windows.Forms.TextBox();
            this.txtUpdatePersonelName = new System.Windows.Forms.TextBox();
            this.btnUpdatePersonel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdatePersonel)).BeginInit();
            this.grbPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUpdatePersonel
            // 
            this.dgwUpdatePersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUpdatePersonel.Location = new System.Drawing.Point(140, 37);
            this.dgwUpdatePersonel.Name = "dgwUpdatePersonel";
            this.dgwUpdatePersonel.Size = new System.Drawing.Size(513, 150);
            this.dgwUpdatePersonel.TabIndex = 29;
            this.dgwUpdatePersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUpdatePersonel_CellClick);
            // 
            // grbPersonel
            // 
            this.grbPersonel.Controls.Add(this.label9);
            this.grbPersonel.Controls.Add(this.txtPersonelUpdatePassword);
            this.grbPersonel.Controls.Add(this.btnUpdatePersonel);
            this.grbPersonel.Controls.Add(this.label8);
            this.grbPersonel.Controls.Add(this.txtUpdatePersonelTcNo);
            this.grbPersonel.Controls.Add(this.label7);
            this.grbPersonel.Controls.Add(this.txtUpdatePersonelEmail);
            this.grbPersonel.Controls.Add(this.dtpUpdatePersonel);
            this.grbPersonel.Controls.Add(this.label5);
            this.grbPersonel.Controls.Add(this.rbUpdatePersonelWoman);
            this.grbPersonel.Controls.Add(this.rbUpdatePersonelMan);
            this.grbPersonel.Controls.Add(this.label4);
            this.grbPersonel.Controls.Add(this.label3);
            this.grbPersonel.Controls.Add(this.label2);
            this.grbPersonel.Controls.Add(this.label1);
            this.grbPersonel.Controls.Add(this.cmbUpdatePersonelNationality);
            this.grbPersonel.Controls.Add(this.txtUpdatePersonelSurname);
            this.grbPersonel.Controls.Add(this.txtUpdatePersonelName);
            this.grbPersonel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonel.Location = new System.Drawing.Point(181, 207);
            this.grbPersonel.Name = "grbPersonel";
            this.grbPersonel.Size = new System.Drawing.Size(444, 465);
            this.grbPersonel.TabIndex = 28;
            this.grbPersonel.TabStop = false;
            this.grbPersonel.Text = "UPDATE PERSONEL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "PASSWORD";
            // 
            // txtPersonelUpdatePassword
            // 
            this.txtPersonelUpdatePassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtPersonelUpdatePassword.Enabled = false;
            this.txtPersonelUpdatePassword.Location = new System.Drawing.Point(281, 212);
            this.txtPersonelUpdatePassword.Name = "txtPersonelUpdatePassword";
            this.txtPersonelUpdatePassword.PasswordChar = '*';
            this.txtPersonelUpdatePassword.Size = new System.Drawing.Size(121, 26);
            this.txtPersonelUpdatePassword.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "TC NO";
            // 
            // txtUpdatePersonelTcNo
            // 
            this.txtUpdatePersonelTcNo.Location = new System.Drawing.Point(281, 40);
            this.txtUpdatePersonelTcNo.Name = "txtUpdatePersonelTcNo";
            this.txtUpdatePersonelTcNo.Size = new System.Drawing.Size(121, 26);
            this.txtUpdatePersonelTcNo.TabIndex = 24;
            this.txtUpdatePersonelTcNo.TextChanged += new System.EventHandler(this.txtUpdatePersonelTcNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "EMAIL";
            // 
            // txtUpdatePersonelEmail
            // 
            this.txtUpdatePersonelEmail.Location = new System.Drawing.Point(281, 171);
            this.txtUpdatePersonelEmail.Name = "txtUpdatePersonelEmail";
            this.txtUpdatePersonelEmail.Size = new System.Drawing.Size(121, 26);
            this.txtUpdatePersonelEmail.TabIndex = 22;
            // 
            // dtpUpdatePersonel
            // 
            this.dtpUpdatePersonel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdatePersonel.Location = new System.Drawing.Point(281, 264);
            this.dtpUpdatePersonel.Name = "dtpUpdatePersonel";
            this.dtpUpdatePersonel.Size = new System.Drawing.Size(121, 26);
            this.dtpUpdatePersonel.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "YEAR_OF_BIRTH";
            // 
            // rbUpdatePersonelWoman
            // 
            this.rbUpdatePersonelWoman.AutoSize = true;
            this.rbUpdatePersonelWoman.Location = new System.Drawing.Point(347, 351);
            this.rbUpdatePersonelWoman.Name = "rbUpdatePersonelWoman";
            this.rbUpdatePersonelWoman.Size = new System.Drawing.Size(87, 23);
            this.rbUpdatePersonelWoman.TabIndex = 10;
            this.rbUpdatePersonelWoman.TabStop = true;
            this.rbUpdatePersonelWoman.Text = "Woman";
            this.rbUpdatePersonelWoman.UseVisualStyleBackColor = true;
            // 
            // rbUpdatePersonelMan
            // 
            this.rbUpdatePersonelMan.AutoSize = true;
            this.rbUpdatePersonelMan.Location = new System.Drawing.Point(278, 351);
            this.rbUpdatePersonelMan.Name = "rbUpdatePersonelMan";
            this.rbUpdatePersonelMan.Size = new System.Drawing.Size(63, 23);
            this.rbUpdatePersonelMan.TabIndex = 9;
            this.rbUpdatePersonelMan.TabStop = true;
            this.rbUpdatePersonelMan.Text = "Man";
            this.rbUpdatePersonelMan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "NATIONALITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "SURNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME";
            // 
            // cmbUpdatePersonelNationality
            // 
            this.cmbUpdatePersonelNationality.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdatePersonelNationality.FormattingEnabled = true;
            this.cmbUpdatePersonelNationality.Items.AddRange(new object[] {
            "TURKEY",
            "FRANCE",
            "UNITED KINGDOM"});
            this.cmbUpdatePersonelNationality.Location = new System.Drawing.Point(281, 306);
            this.cmbUpdatePersonelNationality.Name = "cmbUpdatePersonelNationality";
            this.cmbUpdatePersonelNationality.Size = new System.Drawing.Size(121, 23);
            this.cmbUpdatePersonelNationality.TabIndex = 2;
            // 
            // txtUpdatePersonelSurname
            // 
            this.txtUpdatePersonelSurname.Location = new System.Drawing.Point(281, 128);
            this.txtUpdatePersonelSurname.Name = "txtUpdatePersonelSurname";
            this.txtUpdatePersonelSurname.Size = new System.Drawing.Size(121, 26);
            this.txtUpdatePersonelSurname.TabIndex = 1;
            // 
            // txtUpdatePersonelName
            // 
            this.txtUpdatePersonelName.Location = new System.Drawing.Point(281, 85);
            this.txtUpdatePersonelName.Name = "txtUpdatePersonelName";
            this.txtUpdatePersonelName.Size = new System.Drawing.Size(121, 26);
            this.txtUpdatePersonelName.TabIndex = 0;
            // 
            // btnUpdatePersonel
            // 
            this.btnUpdatePersonel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePersonel.Location = new System.Drawing.Point(133, 395);
            this.btnUpdatePersonel.Name = "btnUpdatePersonel";
            this.btnUpdatePersonel.Size = new System.Drawing.Size(166, 46);
            this.btnUpdatePersonel.TabIndex = 27;
            this.btnUpdatePersonel.Text = "Update Personel";
            this.btnUpdatePersonel.UseVisualStyleBackColor = true;
            this.btnUpdatePersonel.Click += new System.EventHandler(this.btnUpdatePersonel_Click);
            // 
            // UpdatePersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 737);
            this.Controls.Add(this.dgwUpdatePersonel);
            this.Controls.Add(this.grbPersonel);
            this.Name = "UpdatePersonelForm";
            this.Text = "UpdatePersonelForm";
            this.Load += new System.EventHandler(this.UpdatePersonelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdatePersonel)).EndInit();
            this.grbPersonel.ResumeLayout(false);
            this.grbPersonel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUpdatePersonel;
        private System.Windows.Forms.GroupBox grbPersonel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdatePersonelEmail;
        private System.Windows.Forms.DateTimePicker dtpUpdatePersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbUpdatePersonelWoman;
        private System.Windows.Forms.RadioButton rbUpdatePersonelMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUpdatePersonelNationality;
        private System.Windows.Forms.TextBox txtUpdatePersonelSurname;
        private System.Windows.Forms.TextBox txtUpdatePersonelName;
        private System.Windows.Forms.Button btnUpdatePersonel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdatePersonelTcNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPersonelUpdatePassword;
    }
}