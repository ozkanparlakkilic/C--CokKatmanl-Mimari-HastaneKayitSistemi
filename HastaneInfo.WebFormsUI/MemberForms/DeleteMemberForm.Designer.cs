
namespace HastaneInfo.WebFormsUI.MemberForms
{
    partial class DeleteMemberForm
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
            this.dgwMember = new System.Windows.Forms.DataGridView();
            this.grbMember = new System.Windows.Forms.GroupBox();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeleteMemberTcNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeleteMemberName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).BeginInit();
            this.grbMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMember
            // 
            this.dgwMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMember.Location = new System.Drawing.Point(76, 46);
            this.dgwMember.Name = "dgwMember";
            this.dgwMember.Size = new System.Drawing.Size(656, 150);
            this.dgwMember.TabIndex = 94;
            // 
            // grbMember
            // 
            this.grbMember.Controls.Add(this.btnDeleteMember);
            this.grbMember.Controls.Add(this.label8);
            this.grbMember.Controls.Add(this.txtDeleteMemberTcNo);
            this.grbMember.Controls.Add(this.label1);
            this.grbMember.Controls.Add(this.txtDeleteMemberName);
            this.grbMember.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMember.Location = new System.Drawing.Point(183, 228);
            this.grbMember.Name = "grbMember";
            this.grbMember.Size = new System.Drawing.Size(419, 195);
            this.grbMember.TabIndex = 93;
            this.grbMember.TabStop = false;
            this.grbMember.Text = "DELETE MEMBER";
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(135, 129);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(144, 46);
            this.btnDeleteMember.TabIndex = 40;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "TC NO";
            // 
            // txtDeleteMemberTcNo
            // 
            this.txtDeleteMemberTcNo.Location = new System.Drawing.Point(256, 38);
            this.txtDeleteMemberTcNo.Name = "txtDeleteMemberTcNo";
            this.txtDeleteMemberTcNo.Size = new System.Drawing.Size(121, 26);
            this.txtDeleteMemberTcNo.TabIndex = 38;
            this.txtDeleteMemberTcNo.TextChanged += new System.EventHandler(this.txtDeleteMemberTcNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "NAME";
            // 
            // txtDeleteMemberName
            // 
            this.txtDeleteMemberName.Location = new System.Drawing.Point(256, 83);
            this.txtDeleteMemberName.Name = "txtDeleteMemberName";
            this.txtDeleteMemberName.Size = new System.Drawing.Size(121, 26);
            this.txtDeleteMemberName.TabIndex = 22;
            // 
            // DeleteMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwMember);
            this.Controls.Add(this.grbMember);
            this.Name = "DeleteMemberForm";
            this.Text = "DeleteMemberForm";
            this.Load += new System.EventHandler(this.DeleteMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).EndInit();
            this.grbMember.ResumeLayout(false);
            this.grbMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMember;
        private System.Windows.Forms.GroupBox grbMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeleteMemberTcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeleteMemberName;
        private System.Windows.Forms.Button btnDeleteMember;
    }
}