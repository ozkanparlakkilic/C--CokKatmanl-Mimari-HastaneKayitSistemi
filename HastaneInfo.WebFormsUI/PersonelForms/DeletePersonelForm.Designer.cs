
namespace HastaneInfo.WebFormsUI.PersonelForms
{
    partial class DeletePersonelForm
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
            this.dgwRemovePersonel = new System.Windows.Forms.DataGridView();
            this.grbYazar = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemovePersonelTcNo = new System.Windows.Forms.TextBox();
            this.btnRemovePersonel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemovePersonelName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRemovePersonel)).BeginInit();
            this.grbYazar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwRemovePersonel
            // 
            this.dgwRemovePersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRemovePersonel.Location = new System.Drawing.Point(132, 23);
            this.dgwRemovePersonel.Name = "dgwRemovePersonel";
            this.dgwRemovePersonel.RowTemplate.Height = 30;
            this.dgwRemovePersonel.Size = new System.Drawing.Size(492, 150);
            this.dgwRemovePersonel.TabIndex = 30;
            // 
            // grbYazar
            // 
            this.grbYazar.Controls.Add(this.label8);
            this.grbYazar.Controls.Add(this.txtRemovePersonelTcNo);
            this.grbYazar.Controls.Add(this.btnRemovePersonel);
            this.grbYazar.Controls.Add(this.label1);
            this.grbYazar.Controls.Add(this.txtRemovePersonelName);
            this.grbYazar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbYazar.Location = new System.Drawing.Point(163, 228);
            this.grbYazar.Name = "grbYazar";
            this.grbYazar.Size = new System.Drawing.Size(431, 183);
            this.grbYazar.TabIndex = 29;
            this.grbYazar.TabStop = false;
            this.grbYazar.Text = "DELETE PERSONEL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "TC NO";
            // 
            // txtRemovePersonelTcNo
            // 
            this.txtRemovePersonelTcNo.Location = new System.Drawing.Point(270, 31);
            this.txtRemovePersonelTcNo.Name = "txtRemovePersonelTcNo";
            this.txtRemovePersonelTcNo.Size = new System.Drawing.Size(121, 26);
            this.txtRemovePersonelTcNo.TabIndex = 22;
            this.txtRemovePersonelTcNo.TextChanged += new System.EventHandler(this.txtRemovePersonelTcNo_TextChanged);
            // 
            // btnRemovePersonel
            // 
            this.btnRemovePersonel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePersonel.Location = new System.Drawing.Point(121, 118);
            this.btnRemovePersonel.Name = "btnRemovePersonel";
            this.btnRemovePersonel.Size = new System.Drawing.Size(166, 46);
            this.btnRemovePersonel.TabIndex = 28;
            this.btnRemovePersonel.Text = "Remove Personel";
            this.btnRemovePersonel.UseVisualStyleBackColor = true;
            this.btnRemovePersonel.Click += new System.EventHandler(this.btnRemovePersonel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME";
            // 
            // txtRemovePersonelName
            // 
            this.txtRemovePersonelName.Location = new System.Drawing.Point(270, 73);
            this.txtRemovePersonelName.Name = "txtRemovePersonelName";
            this.txtRemovePersonelName.Size = new System.Drawing.Size(121, 26);
            this.txtRemovePersonelName.TabIndex = 0;
            // 
            // DeletePersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 488);
            this.Controls.Add(this.dgwRemovePersonel);
            this.Controls.Add(this.grbYazar);
            this.Name = "DeletePersonelForm";
            this.Text = "DeletePersonelForm";
            this.Load += new System.EventHandler(this.DeletePersonelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRemovePersonel)).EndInit();
            this.grbYazar.ResumeLayout(false);
            this.grbYazar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRemovePersonel;
        private System.Windows.Forms.GroupBox grbYazar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemovePersonelTcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemovePersonelName;
        private System.Windows.Forms.Button btnRemovePersonel;
    }
}