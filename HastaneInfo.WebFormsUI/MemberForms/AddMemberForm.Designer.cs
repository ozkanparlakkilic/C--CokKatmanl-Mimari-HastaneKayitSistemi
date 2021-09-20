
namespace HastaneInfo.WebFormsUI.MemberForms
{
    partial class AddMemberForm
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
            this.txtMemberPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMemberTcNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberSurname = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.grbMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMember
            // 
            this.grbMember.Controls.Add(this.label4);
            this.grbMember.Controls.Add(this.txtMemberPassword);
            this.grbMember.Controls.Add(this.label3);
            this.grbMember.Controls.Add(this.txtMemberUsername);
            this.grbMember.Controls.Add(this.label8);
            this.grbMember.Controls.Add(this.txtMemberTcNo);
            this.grbMember.Controls.Add(this.label7);
            this.grbMember.Controls.Add(this.txtMemberEmail);
            this.grbMember.Controls.Add(this.btnAddMember);
            this.grbMember.Controls.Add(this.label2);
            this.grbMember.Controls.Add(this.label1);
            this.grbMember.Controls.Add(this.txtMemberSurname);
            this.grbMember.Controls.Add(this.txtMemberName);
            this.grbMember.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMember.Location = new System.Drawing.Point(94, 62);
            this.grbMember.Name = "grbMember";
            this.grbMember.Size = new System.Drawing.Size(473, 395);
            this.grbMember.TabIndex = 90;
            this.grbMember.TabStop = false;
            this.grbMember.Text = "ADD MEMBER";
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
            // txtMemberPassword
            // 
            this.txtMemberPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtMemberPassword.Location = new System.Drawing.Point(287, 262);
            this.txtMemberPassword.Name = "txtMemberPassword";
            this.txtMemberPassword.PasswordChar = '*';
            this.txtMemberPassword.Size = new System.Drawing.Size(121, 26);
            this.txtMemberPassword.TabIndex = 42;
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
            // txtMemberUsername
            // 
            this.txtMemberUsername.Location = new System.Drawing.Point(286, 172);
            this.txtMemberUsername.Name = "txtMemberUsername";
            this.txtMemberUsername.Size = new System.Drawing.Size(121, 26);
            this.txtMemberUsername.TabIndex = 40;
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
            // txtMemberTcNo
            // 
            this.txtMemberTcNo.Location = new System.Drawing.Point(286, 37);
            this.txtMemberTcNo.Name = "txtMemberTcNo";
            this.txtMemberTcNo.Size = new System.Drawing.Size(121, 26);
            this.txtMemberTcNo.TabIndex = 38;
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
            // txtMemberEmail
            // 
            this.txtMemberEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtMemberEmail.Location = new System.Drawing.Point(287, 217);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.Size = new System.Drawing.Size(121, 26);
            this.txtMemberEmail.TabIndex = 36;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(173, 320);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(132, 46);
            this.btnAddMember.TabIndex = 26;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
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
            // txtMemberSurname
            // 
            this.txtMemberSurname.Location = new System.Drawing.Point(286, 127);
            this.txtMemberSurname.Name = "txtMemberSurname";
            this.txtMemberSurname.Size = new System.Drawing.Size(121, 26);
            this.txtMemberSurname.TabIndex = 23;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(286, 82);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(121, 26);
            this.txtMemberName.TabIndex = 22;
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 538);
            this.Controls.Add(this.grbMember);
            this.Name = "AddMemberForm";
            this.Text = "AddMemberForm";
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            this.grbMember.ResumeLayout(false);
            this.grbMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMemberTcNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberSurname;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemberPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemberUsername;
    }
}