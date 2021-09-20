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

namespace HastaneInfo.WebFormsUI.LoginAndRegister.MemberLogin
{
    public partial class MemberForgetPasswordForm : Form
    {
        public static string email;
        private LoginForm _loginForm;
        private MemberChangePasswordForm memberChangePasswordForm;

        public MemberForgetPasswordForm(IMemberService memberService, LoginForm loginForm)
        {
            _memberService = memberService;
            _loginForm = loginForm;
            memberChangePasswordForm = new MemberChangePasswordForm(_memberService, this, _loginForm);
            InitializeComponent();
        }

        private readonly IMemberService _memberService;
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (_memberService.CheckTcNoAndMail(txtMemberTcNo.Text, txtMemberEmail.Text).Count != 0)
            {
                email = txtMemberEmail.Text;
                memberChangePasswordForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tc No ya da email hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Hide();
        }

        private void MemberForgetPasswordForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
