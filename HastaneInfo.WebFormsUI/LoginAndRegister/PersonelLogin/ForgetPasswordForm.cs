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
using HastaneInfo.WebFormsUI.Utilities.FormDesignControl;

namespace HastaneInfo.WebFormsUI.LoginAndRegister
{
    public partial class ForgetPasswordForm : Form
    {
        public static string email;
        private LoginForm _loginForm;
        private ChangePasswordForm changePasswordForm;
        public ForgetPasswordForm(IPersonelService personelService, LoginForm loginForm)
        {
            _personelService = personelService;
            _loginForm = loginForm;
            changePasswordForm = new ChangePasswordForm(_personelService, this, _loginForm);
            InitializeComponent();
        }

        private readonly IPersonelService _personelService;
        private void btnBack_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (_personelService.CheckTcNoAndMail(txtPersonelTcNo.Text, txtPersonelEmail.Text).Count != 0)
            {
                email = txtPersonelEmail.Text;
                changePasswordForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tc No ya da email hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
