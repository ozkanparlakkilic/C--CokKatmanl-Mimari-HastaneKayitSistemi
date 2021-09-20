
namespace HastaneInfo.WebFormsUI
{
    partial class PersonelOperationForm
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
            this.btnDeletePersonel = new System.Windows.Forms.Button();
            this.btnAddPersonel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeletePersonel
            // 
            this.btnDeletePersonel.Location = new System.Drawing.Point(65, 84);
            this.btnDeletePersonel.Name = "btnDeletePersonel";
            this.btnDeletePersonel.Size = new System.Drawing.Size(132, 46);
            this.btnDeletePersonel.TabIndex = 26;
            this.btnDeletePersonel.Text = "Delete Personel";
            this.btnDeletePersonel.UseVisualStyleBackColor = true;
            this.btnDeletePersonel.Click += new System.EventHandler(this.btnDeletePersonel_Click);
            // 
            // btnAddPersonel
            // 
            this.btnAddPersonel.Location = new System.Drawing.Point(244, 84);
            this.btnAddPersonel.Name = "btnAddPersonel";
            this.btnAddPersonel.Size = new System.Drawing.Size(162, 46);
            this.btnAddPersonel.TabIndex = 25;
            this.btnAddPersonel.Text = "Add Personel";
            this.btnAddPersonel.UseVisualStyleBackColor = true;
            this.btnAddPersonel.Click += new System.EventHandler(this.btnAddPersonel_Click);
            // 
            // PersonelOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 221);
            this.Controls.Add(this.btnDeletePersonel);
            this.Controls.Add(this.btnAddPersonel);
            this.Name = "PersonelOperationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeletePersonel;
        private System.Windows.Forms.Button btnAddPersonel;
    }
}
