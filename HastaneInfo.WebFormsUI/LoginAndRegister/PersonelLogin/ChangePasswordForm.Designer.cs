
namespace HastaneInfo.WebFormsUI.LoginAndRegister
{
    partial class ChangePasswordForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.grbPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPersonel
            // 
            this.grbPersonel.Controls.Add(this.btnBack);
            this.grbPersonel.Controls.Add(this.label8);
            this.grbPersonel.Controls.Add(this.txtNewPassword);
            this.grbPersonel.Controls.Add(this.label7);
            this.grbPersonel.Controls.Add(this.txtNewPasswordAgain);
            this.grbPersonel.Controls.Add(this.btnChangePassword);
            this.grbPersonel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonel.Location = new System.Drawing.Point(81, 46);
            this.grbPersonel.Name = "grbPersonel";
            this.grbPersonel.Size = new System.Drawing.Size(405, 256);
            this.grbPersonel.TabIndex = 7;
            this.grbPersonel.TabStop = false;
            this.grbPersonel.Text = "CHANGE PASSWORD";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(25, 159);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 46);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "NEW PASSWORD";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(245, 53);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(121, 26);
            this.txtNewPassword.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "NEW PASSWORD AGAIN";
            // 
            // txtNewPasswordAgain
            // 
            this.txtNewPasswordAgain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNewPasswordAgain.Location = new System.Drawing.Point(245, 96);
            this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            this.txtNewPasswordAgain.PasswordChar = '*';
            this.txtNewPasswordAgain.Size = new System.Drawing.Size(121, 26);
            this.txtNewPasswordAgain.TabIndex = 18;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(198, 159);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(168, 46);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 370);
            this.Controls.Add(this.grbPersonel);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.grbPersonel.ResumeLayout(false);
            this.grbPersonel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewPasswordAgain;
        private System.Windows.Forms.Button btnChangePassword;
    }
}