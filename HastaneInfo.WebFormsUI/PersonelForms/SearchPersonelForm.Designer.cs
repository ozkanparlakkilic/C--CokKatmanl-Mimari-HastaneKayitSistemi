
namespace HastaneInfo.WebFormsUI.PersonelForms
{
    partial class SearchPersonelForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchPersonelTcNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchPersonelEmail = new System.Windows.Forms.TextBox();
            this.cmbSearchPosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbSearchPersonelWoman = new System.Windows.Forms.RadioButton();
            this.rbSearchPersonelMan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchPersonelNationality = new System.Windows.Forms.ComboBox();
            this.txtSearchPersonelSurname = new System.Windows.Forms.TextBox();
            this.txtSearchPersonelName = new System.Windows.Forms.TextBox();
            this.dgwSearchPersonel = new System.Windows.Forms.DataGridView();
            this.grbPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearchPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonel
            // 
            this.grbPersonel.Controls.Add(this.label5);
            this.grbPersonel.Controls.Add(this.txtSearchPersonelTcNo);
            this.grbPersonel.Controls.Add(this.label7);
            this.grbPersonel.Controls.Add(this.txtSearchPersonelEmail);
            this.grbPersonel.Controls.Add(this.cmbSearchPosition);
            this.grbPersonel.Controls.Add(this.label6);
            this.grbPersonel.Controls.Add(this.rbSearchPersonelWoman);
            this.grbPersonel.Controls.Add(this.rbSearchPersonelMan);
            this.grbPersonel.Controls.Add(this.label4);
            this.grbPersonel.Controls.Add(this.label3);
            this.grbPersonel.Controls.Add(this.label2);
            this.grbPersonel.Controls.Add(this.label1);
            this.grbPersonel.Controls.Add(this.cmbSearchPersonelNationality);
            this.grbPersonel.Controls.Add(this.txtSearchPersonelSurname);
            this.grbPersonel.Controls.Add(this.txtSearchPersonelName);
            this.grbPersonel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonel.Location = new System.Drawing.Point(189, 261);
            this.grbPersonel.Name = "grbPersonel";
            this.grbPersonel.Size = new System.Drawing.Size(383, 346);
            this.grbPersonel.TabIndex = 28;
            this.grbPersonel.TabStop = false;
            this.grbPersonel.Text = "SEARCH PERSONEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "TC NO";
            // 
            // txtSearchPersonelTcNo
            // 
            this.txtSearchPersonelTcNo.Location = new System.Drawing.Point(205, 25);
            this.txtSearchPersonelTcNo.Name = "txtSearchPersonelTcNo";
            this.txtSearchPersonelTcNo.Size = new System.Drawing.Size(121, 26);
            this.txtSearchPersonelTcNo.TabIndex = 24;
            this.txtSearchPersonelTcNo.TextChanged += new System.EventHandler(this.txtSearchPersonelTcNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "EMAIL";
            // 
            // txtSearchPersonelEmail
            // 
            this.txtSearchPersonelEmail.Location = new System.Drawing.Point(205, 146);
            this.txtSearchPersonelEmail.Name = "txtSearchPersonelEmail";
            this.txtSearchPersonelEmail.Size = new System.Drawing.Size(121, 26);
            this.txtSearchPersonelEmail.TabIndex = 22;
            // 
            // cmbSearchPosition
            // 
            this.cmbSearchPosition.FormattingEnabled = true;
            this.cmbSearchPosition.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "AUTHORIZED",
            "WORKER"});
            this.cmbSearchPosition.Location = new System.Drawing.Point(205, 266);
            this.cmbSearchPosition.Name = "cmbSearchPosition";
            this.cmbSearchPosition.Size = new System.Drawing.Size(121, 27);
            this.cmbSearchPosition.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "POSITION";
            // 
            // rbSearchPersonelWoman
            // 
            this.rbSearchPersonelWoman.AutoSize = true;
            this.rbSearchPersonelWoman.Location = new System.Drawing.Point(273, 227);
            this.rbSearchPersonelWoman.Name = "rbSearchPersonelWoman";
            this.rbSearchPersonelWoman.Size = new System.Drawing.Size(87, 23);
            this.rbSearchPersonelWoman.TabIndex = 10;
            this.rbSearchPersonelWoman.TabStop = true;
            this.rbSearchPersonelWoman.Text = "Woman";
            this.rbSearchPersonelWoman.UseVisualStyleBackColor = true;
            // 
            // rbSearchPersonelMan
            // 
            this.rbSearchPersonelMan.AutoSize = true;
            this.rbSearchPersonelMan.Location = new System.Drawing.Point(205, 227);
            this.rbSearchPersonelMan.Name = "rbSearchPersonelMan";
            this.rbSearchPersonelMan.Size = new System.Drawing.Size(63, 23);
            this.rbSearchPersonelMan.TabIndex = 9;
            this.rbSearchPersonelMan.TabStop = true;
            this.rbSearchPersonelMan.Text = "Man";
            this.rbSearchPersonelMan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "NATIONALITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "SURNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME";
            // 
            // cmbSearchPersonelNationality
            // 
            this.cmbSearchPersonelNationality.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchPersonelNationality.FormattingEnabled = true;
            this.cmbSearchPersonelNationality.Items.AddRange(new object[] {
            "TURKEY",
            "FRANCE",
            "UNITED KINGDOM"});
            this.cmbSearchPersonelNationality.Location = new System.Drawing.Point(205, 187);
            this.cmbSearchPersonelNationality.Name = "cmbSearchPersonelNationality";
            this.cmbSearchPersonelNationality.Size = new System.Drawing.Size(121, 23);
            this.cmbSearchPersonelNationality.TabIndex = 2;
            // 
            // txtSearchPersonelSurname
            // 
            this.txtSearchPersonelSurname.Location = new System.Drawing.Point(205, 106);
            this.txtSearchPersonelSurname.Name = "txtSearchPersonelSurname";
            this.txtSearchPersonelSurname.Size = new System.Drawing.Size(121, 26);
            this.txtSearchPersonelSurname.TabIndex = 1;
            // 
            // txtSearchPersonelName
            // 
            this.txtSearchPersonelName.Location = new System.Drawing.Point(205, 66);
            this.txtSearchPersonelName.Name = "txtSearchPersonelName";
            this.txtSearchPersonelName.Size = new System.Drawing.Size(121, 26);
            this.txtSearchPersonelName.TabIndex = 0;
            // 
            // dgwSearchPersonel
            // 
            this.dgwSearchPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSearchPersonel.Location = new System.Drawing.Point(103, 70);
            this.dgwSearchPersonel.Name = "dgwSearchPersonel";
            this.dgwSearchPersonel.Size = new System.Drawing.Size(565, 150);
            this.dgwSearchPersonel.TabIndex = 27;
            // 
            // SearchPersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 680);
            this.Controls.Add(this.grbPersonel);
            this.Controls.Add(this.dgwSearchPersonel);
            this.Name = "SearchPersonelForm";
            this.Text = "SearchPersonelForm";
            this.Load += new System.EventHandler(this.SearchPersonelForm_Load);
            this.grbPersonel.ResumeLayout(false);
            this.grbPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearchPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchPersonelEmail;
        private System.Windows.Forms.ComboBox cmbSearchPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbSearchPersonelWoman;
        private System.Windows.Forms.RadioButton rbSearchPersonelMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchPersonelNationality;
        private System.Windows.Forms.TextBox txtSearchPersonelSurname;
        private System.Windows.Forms.TextBox txtSearchPersonelName;
        private System.Windows.Forms.DataGridView dgwSearchPersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchPersonelTcNo;
    }
}