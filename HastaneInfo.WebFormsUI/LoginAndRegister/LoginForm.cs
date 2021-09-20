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
using HastaneInfo.WebFormsUI.LoginAndRegister;
using HastaneInfo.WebFormsUI.LoginAndRegister.Member;
using HastaneInfo.WebFormsUI.LoginAndRegister.MemberLogin;
using HastaneInfo.WebFormsUI.LoginAndRegister.Personel;
using HastaneInfo.WebFormsUI.OperationForm;
using HastaneInfo.WebFormsUI.RandevuForms;
using HastaneInfo.WebFormsUI.Utilities.HashPassword;

namespace HastaneInfo.WebFormsUI
{
    public partial class LoginForm : Form
    {
        private RegisterForm registerForm;
        private ForgetPasswordForm forgetPasswordForm;
        private MemberForgetPasswordForm _memberForgetPasswordForm;
        private MemberRegisterForm memberRegisterForm;
        public static string email;
        public static string password;
        public LoginForm()
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            _memberService = InstanceFactory.GetInstance<IMemberService>();
            registerForm = new RegisterForm(this);
            memberRegisterForm = new MemberRegisterForm(this);
            forgetPasswordForm = new ForgetPasswordForm(_personelService, this);
            _memberForgetPasswordForm = new MemberForgetPasswordForm(_memberService, this);
        }
        private IPersonelService _personelService;
        private IMemberService _memberService;
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string hashPassword = new HashPassword().hashPasswordText(txtPassword);
            if (_personelService.Login(txtUserName.Text, hashPassword, "ADMIN").Count != 0)
            {

                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else if (_personelService.Login(txtUserName.Text, hashPassword, "AUTHORIZED").Count != 0)
            {
                PersonelOperationForm form1 = new PersonelOperationForm();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            this.Hide();
        }

        private void iconBtnClearFields_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetPasswordForm.Show();
            this.Hide();
        }

        private void ıconBtnMemberLogin_Click(object sender, EventArgs e)
        {
            panelPersonelLogin.Visible = true;
            panelMemberLogin.Visible = false;
        }

        private void ıconBtnClearMemberText_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnMemberRegister_Click(object sender, EventArgs e)
        {
            memberRegisterForm.Show();
            this.Hide();
        }

        private void btnMemberLogIn_Click(object sender, EventArgs e)
        {
            string hashPasswordMember = new HashPassword().hashPasswordText(txtMemberPassword);
            if (_memberService.Login(txtMemberEmail.Text, hashPasswordMember).Count != 0)
            {
                password = hashPasswordMember;
                email = txtMemberEmail.Text;
                RandevuForm randevuForm = new RandevuForm();
                randevuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ıconBtnMemberExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ıconBtnPersonelLogin_Click(object sender, EventArgs e)
        {
            panelPersonelLogin.Visible = false;
            panelMemberLogin.Visible = true;
        }
    }

}
