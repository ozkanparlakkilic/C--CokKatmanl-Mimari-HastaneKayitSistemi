
namespace HastaneInfo.WebFormsUI.MemberForms
{
    partial class UpdateMemberForm
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
            this.grbMember = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateMemberPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateMemberUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdateMemberTcNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateMemberEmail = new System.Windows.Forms.TextBox();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateMemberSurname = new System.Windows.Forms.TextBox();
            this.txtUpdateMemberName = new System.Windows.Forms.TextBox();
            this.dgwMember = new System.Windows.Forms.DataGridView();
            this.grbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).BeginInit();
            this.SuspendLayout();
            // 
            // grbMember
            // 
            this.grbMember.Controls.Add(this.label4);
            this.grbMember.Controls.Add(this.txtUpdateMemberPassword);
            this.grbMember.Controls.Add(this.label3);
            this.grbMember.Controls.Add(this.txtUpdateMemberUsername);
            this.grbMember.Controls.Add(this.label8);
            this.grbMember.Controls.Add(this.txtUpdateMemberTcNo);
            this.grbMember.Controls.Add(this.label7);
            this.grbMember.Controls.Add(this.txtUpdateMemberEmail);
            this.grbMember.Controls.Add(this.btnUpdateMember);
            this.grbMember.Controls.Add(this.label2);
            this.grbMember.Controls.Add(this.label1);
            this.grbMember.Controls.Add(this.txtUpdateMemberSurname);
            this.grbMember.Controls.Add(this.txtUpdateMemberName);
            this.grbMember.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMember.Location = new System.Drawing.Point(172, 227);
            this.grbMember.Name = "grbMember";
            this.grbMember.Size = new System.Drawing.Size(473, 395);
            this.grbMember.TabIndex = 91;
            this.grbMember.TabStop = false;
            this.grbMember.Text = "UPDATE MEMBER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "PASSWORD";
            // 
            // txtUpdateMemberPassword
            // 
            this.txtUpdateMemberPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtUpdateMemberPassword.Location = new System.Drawing.Point(287, 262);
            this.txtUpdateMemberPassword.Name = "txtUpdateMemberPassword";
            this.txtUpdateMemberPassword.PasswordChar = '*';
            this.txtUpdateMemberPassword.Size = new System.Drawing.Size(121, 26);
            this.txtUpdateMemberPassword.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "USERNAME";
            // 
            // txtUpdateMemberUsername
            // 
            this.txtUpdateMemberUsername.Location = new System.Drawing.Point(286, 172);
            this.txtUpdateMemberUsername.Name = "txtUpdateMemberUsername";
            this.txtUpdateMemberUsername.Size = new System.Drawing.Size(121, 26);
            this.txtUpdateMemberUsername.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "TC NO";
            // 
            // txtUpdateMemberTcNo
            // 
            this.txtUpdateMemberTcNo.Location = new System.Drawing.Point(286, 37);
            this.txtUpdateMemberTcNo.Name = "txtUpdateMemberTcNo";
            this.txtUpdateMemberTcNo.Size = new System.Drawing.Size(121, 26);
            this.txtUpdateMemberTcNo.TabIndex = 38;
            this.txtUpdateMemberTcNo.TextChanged += new System.EventHandler(this.txtUpdateMemberTcNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "EMAIL";
            // 
            // txtUpdateMemberEmail
            // 
            this.txtUpdateMemberEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtUpdateMemberEmail.Location = new System.Drawing.Point(287, 217);
            this.txtUpdateMemberEmail.Name = "txtUpdateMemberEmail";
            this.txtUpdateMemberEmail.Size = new System.Drawing.Size(121, 26);
            this.txtUpdateMemberEmail.TabIndex = 36;
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(164, 320);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(156, 46);
            this.btnUpdateMember.TabIndex = 26;
            this.btnUpdateMember.Text = "Update Member";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "SURNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "NAME";
            // 
            // txtUpdateMemberSurname
            // 
            this.txtUpdateMemberSurname.Location = new System.Drawing.Point(286, 127);
            this.txtUpdateMemberSurname.Name = "txtUpdateMemberSurname";
            this.txtUpdateMemberSurname.Size = new System.Drawing.Size(121, 26);
            this.txtUpdateMemberSurname.TabIndex = 23;
            // 
            // txtUpdateMemberName
            // 
            this.txtUpdateMemberName.Location = new System.Drawing.Point(286, 82);
            this.txtUpdateMemberName.Name = "txtUpdateMemberName";
            this.txtUpdateMemberName.Size = new System.Drawing.Size(121, 26);
            this.txtUpdateMemberName.TabIndex = 22;
            // 
            // dgwMember
            // 
            this.dgwMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMember.Location = new System.Drawing.Point(77, 22);
            this.dgwMember.Name = "dgwMember";
            this.dgwMember.Size = new System.Drawing.Size(656, 150);
            this.dgwMember.TabIndex = 93;
            this.dgwMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMember_CellClick);
            // 
            // UpdateMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.dgwMember);
            this.Controls.Add(this.grbMember);
            this.Name = "UpdateMemberForm";
            this.Text = "UpdateMemberForm";
            this.Load += new System.EventHandler(this.UpdateMemberForm_Load);
            this.grbMember.ResumeLayout(false);
            this.grbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateMemberPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateMemberUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateMemberTcNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateMemberEmail;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdateMemberSurname;
        private System.Windows.Forms.TextBox txtUpdateMemberName;
        private System.Windows.Forms.DataGridView dgwMember;
    }
}