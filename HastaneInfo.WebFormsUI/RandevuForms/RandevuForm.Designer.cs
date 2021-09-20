
namespace HastaneInfo.WebFormsUI.RandevuForms
{
    partial class RandevuForm
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
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPoliclinics = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMemberTcNo = new System.Windows.Forms.TextBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDoctorName = new System.Windows.Forms.ComboBox();
            this.grbPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPersonel
            // 
            this.grbPersonel.Controls.Add(this.cmbHour);
            this.grbPersonel.Controls.Add(this.label6);
            this.grbPersonel.Controls.Add(this.label4);
            this.grbPersonel.Controls.Add(this.cmbPoliclinics);
            this.grbPersonel.Controls.Add(this.label1);
            this.grbPersonel.Controls.Add(this.txtMemberSurname);
            this.grbPersonel.Controls.Add(this.label2);
            this.grbPersonel.Controls.Add(this.txtMemberName);
            this.grbPersonel.Controls.Add(this.label8);
            this.grbPersonel.Controls.Add(this.txtMemberTcNo);
            this.grbPersonel.Controls.Add(this.dtpAppointmentDate);
            this.grbPersonel.Controls.Add(this.btnAppointment);
            this.grbPersonel.Controls.Add(this.label5);
            this.grbPersonel.Controls.Add(this.label3);
            this.grbPersonel.Controls.Add(this.cmbDoctorName);
            this.grbPersonel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonel.Location = new System.Drawing.Point(86, 43);
            this.grbPersonel.Name = "grbPersonel";
            this.grbPersonel.Size = new System.Drawing.Size(818, 496);
            this.grbPersonel.TabIndex = 5;
            this.grbPersonel.TabStop = false;
            this.grbPersonel.Text = "RANDEVU";
            // 
            // cmbHour
            // 
            this.cmbHour.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cmbHour.Location = new System.Drawing.Point(235, 296);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(121, 23);
            this.cmbHour.Sorted = true;
            this.cmbHour.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "APPOINTMENT HOUR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "DOCTOR NAME";
            // 
            // cmbPoliclinics
            // 
            this.cmbPoliclinics.FormattingEnabled = true;
            this.cmbPoliclinics.Items.AddRange(new object[] {
            "Çocuk Acil",
            "Çocuk Beyin",
            "Çocuk Cildiye",
            "Çocuk Diş",
            "Çocuk Ortopedi"});
            this.cmbPoliclinics.Location = new System.Drawing.Point(564, 56);
            this.cmbPoliclinics.Name = "cmbPoliclinics";
            this.cmbPoliclinics.Size = new System.Drawing.Size(121, 27);
            this.cmbPoliclinics.TabIndex = 28;
            this.cmbPoliclinics.SelectedIndexChanged += new System.EventHandler(this.cmbPoliclinics_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "SURNAME";
            // 
            // txtMemberSurname
            // 
            this.txtMemberSurname.Enabled = false;
            this.txtMemberSurname.Location = new System.Drawing.Point(162, 147);
            this.txtMemberSurname.Name = "txtMemberSurname";
            this.txtMemberSurname.Size = new System.Drawing.Size(112, 26);
            this.txtMemberSurname.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "NAME";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Location = new System.Drawing.Point(162, 102);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(112, 26);
            this.txtMemberName.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "TC NO";
            // 
            // txtMemberTcNo
            // 
            this.txtMemberTcNo.Enabled = false;
            this.txtMemberTcNo.Location = new System.Drawing.Point(162, 57);
            this.txtMemberTcNo.Name = "txtMemberTcNo";
            this.txtMemberTcNo.Size = new System.Drawing.Size(112, 26);
            this.txtMemberTcNo.TabIndex = 20;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(235, 247);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(113, 26);
            this.dtpAppointmentDate.TabIndex = 16;
            this.dtpAppointmentDate.ValueChanged += new System.EventHandler(this.dtpAddPersonel_ValueChanged);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(290, 393);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(227, 52);
            this.btnAppointment.TabIndex = 3;
            this.btnAppointment.Text = "Make an Appointment";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "APPOINTMENT DATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "POLICLINICS";
            // 
            // cmbDoctorName
            // 
            this.cmbDoctorName.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctorName.FormattingEnabled = true;
            this.cmbDoctorName.Location = new System.Drawing.Point(564, 102);
            this.cmbDoctorName.Name = "cmbDoctorName";
            this.cmbDoctorName.Size = new System.Drawing.Size(121, 23);
            this.cmbDoctorName.TabIndex = 2;
            this.cmbDoctorName.TextChanged += new System.EventHandler(this.cmbDoctorName_TextChanged);
            // 
            // RandevuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 605);
            this.Controls.Add(this.grbPersonel);
            this.Name = "RandevuForm";
            this.Text = "RandevuForm";
            this.Load += new System.EventHandler(this.RandevuForm_Load);
            this.grbPersonel.ResumeLayout(false);
            this.grbPersonel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMemberTcNo;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDoctorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPoliclinics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.ComboBox cmbHour;
    }
}