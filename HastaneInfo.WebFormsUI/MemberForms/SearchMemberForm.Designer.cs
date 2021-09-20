
namespace HastaneInfo.WebFormsUI.MemberForms
{
    partial class SearchMemberForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchMemberTcNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchMemberName = new System.Windows.Forms.TextBox();
            this.dgwMember = new System.Windows.Forms.DataGridView();
            this.grbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).BeginInit();
            this.SuspendLayout();
            // 
            // grbMember
            // 
            this.grbMember.Controls.Add(this.label8);
            this.grbMember.Controls.Add(this.txtSearchMemberTcNo);
            this.grbMember.Controls.Add(this.label1);
            this.grbMember.Controls.Add(this.txtSearchMemberName);
            this.grbMember.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMember.Location = new System.Drawing.Point(156, 198);
            this.grbMember.Name = "grbMember";
            this.grbMember.Size = new System.Drawing.Size(473, 149);
            this.grbMember.TabIndex = 91;
            this.grbMember.TabStop = false;
            this.grbMember.Text = "SEARCH MEMBER";
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
            // txtSearchMemberTcNo
            // 
            this.txtSearchMemberTcNo.Location = new System.Drawing.Point(286, 37);
            this.txtSearchMemberTcNo.Name = "txtSearchMemberTcNo";
            this.txtSearchMemberTcNo.Size = new System.Drawing.Size(121, 26);
            this.txtSearchMemberTcNo.TabIndex = 38;
            this.txtSearchMemberTcNo.TextChanged += new System.EventHandler(this.txtSearchMemberTcNo_TextChanged);
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
            // txtSearchMemberName
            // 
            this.txtSearchMemberName.Location = new System.Drawing.Point(286, 82);
            this.txtSearchMemberName.Name = "txtSearchMemberName";
            this.txtSearchMemberName.Size = new System.Drawing.Size(121, 26);
            this.txtSearchMemberName.TabIndex = 22;
            // 
            // dgwMember
            // 
            this.dgwMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMember.Location = new System.Drawing.Point(71, 26);
            this.dgwMember.Name = "dgwMember";
            this.dgwMember.Size = new System.Drawing.Size(656, 150);
            this.dgwMember.TabIndex = 92;
            // 
            // SearchMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.dgwMember);
            this.Controls.Add(this.grbMember);
            this.Name = "SearchMemberForm";
            this.Text = "SearchMemberForm";
            this.Load += new System.EventHandler(this.SearchMemberForm_Load);
            this.grbMember.ResumeLayout(false);
            this.grbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchMemberTcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchMemberName;
        private System.Windows.Forms.DataGridView dgwMember;
    }
}