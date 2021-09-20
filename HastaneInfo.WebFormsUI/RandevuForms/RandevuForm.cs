using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneInfo.Business.Abstract;
using HastaneInfo.Business.DependencyResolvers.Ninject;
using HastaneInfo.Entities.Concrete;
using HastaneInfo.WebFormsUI.Utilities.FormDesignControl;
using HastaneInfo.WebFormsUI.Utilities.HashPassword;

namespace HastaneInfo.WebFormsUI.RandevuForms
{
    public partial class RandevuForm : Form
    {
        private List<string> removeItems = new List<string>();
        public RandevuForm()
        {
            InitializeComponent();
            _memberService = InstanceFactory.GetInstance<IMemberService>();
            _polyclinicService = InstanceFactory.GetInstance<IPolyclinicService>();
            _appointmentService = InstanceFactory.GetInstance<IAppointmentService>();
            textPush();
        }
        private IMemberService _memberService;
        private IPolyclinicService _polyclinicService;
        private IAppointmentService _appointmentService;

        public void hourCheck()
        {

            if (_appointmentService.DateCheckAppointment(cmbDoctorName.Text, dtpAppointmentDate.Text).Count > 0)
            {
                List<Appointment> appointments = _appointmentService.DateCheckAppointment(cmbDoctorName.Text, dtpAppointmentDate.Text);

                foreach (var appointment in appointments)
                {
                    cmbHour.Items.Remove(appointment.APPOINTMENT_HOUR);
                    removeItems.Add(appointment.APPOINTMENT_HOUR);
                }
            }
            else
            {

                if (removeItems != null)
                {
                    foreach (var item in removeItems)
                    {
                        int index = cmbHour.FindStringExact(item);
                        if (index < 0)
                        {
                            cmbHour.Items.Add(item);
                        }

                    }
                }


            }

        }

        void textPush()
        {
            string email = LoginForm.email;
            string password = LoginForm.password;

            List<Entities.Concrete.Member> members = _memberService.Login(email, password);

            foreach (var member in members)
            {
                txtMemberTcNo.Text = member.TC_NO;
                txtMemberName.Text = member.MEMBER_NAME;
                txtMemberSurname.Text = member.MEMBER_SURNAME;
            }
        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }

        private void cmbPoliclinics_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbPoliclinics.GetItemText(cmbPoliclinics.SelectedItem);

            List<Polyclinic> doctors = _polyclinicService.GetDoctor(selected);

            cmbDoctorName.Items.Clear();
            foreach (var doctor in doctors)
            {
                cmbDoctorName.Items.Add(doctor.DOCTOR_NAME);
            }

            hourCheck();
        }


        private void dtpAddPersonel_ValueChanged(object sender, EventArgs e)
        {
            hourCheck();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            _appointmentService.Add(new Appointment()
            {
                TC_NO = txtMemberTcNo.Text,
                MEMBER_NAME = txtMemberName.Text,
                MEMBER_SURNAME = txtMemberSurname.Text,
                POLYCLINICS_NAME = cmbPoliclinics.Text,
                DOCTOR_NAME = cmbDoctorName.Text,
                APPOINTMENT_DATE = dtpAppointmentDate.Text,
                APPOINTMENT_HOUR = cmbHour.Text
            });

            MessageBox.Show("Randevunuz başarıyla oluşturukdu");
        }

        private void cmbDoctorName_TextChanged(object sender, EventArgs e)
        {
            hourCheck();
        }
    }
}
