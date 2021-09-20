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
using HastaneInfo.WebFormsUI.Utilities.HashPassword;
using HastaneInfo.WebFormsUI.Utilities.PasswordsEqualCheck;

namespace HastaneInfo.WebFormsUI.LoginAndRegister.MemberLogin
{
    public partial class MemberChangePasswordForm : Form
    {
        private MemberForgetPasswordForm _memberForgetPasswordForm;
        private LoginForm _loginForm;
        private bool check;
        public MemberChangePasswordForm(IMemberService memberService, MemberForgetPasswordForm memberForgetPasswordForm, LoginForm loginForm)
        {
            _memberService = memberService;
            _memberForgetPasswordForm = memberForgetPasswordForm;
            _loginForm = loginForm;
            InitializeComponent();
        }

        private IMemberService _memberService;
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            check = new PasswordsEqualCheck().CheckPasswordsToEqual(txtNewPassword.Text, txtNewPasswordAgain.Text);

            if (check)
            {
                var password = new HashPassword().hashPasswordText(txtNewPassword);
                var email = ForgetPasswordForm.email;

                List<Entities.Concrete.Member> members = _memberService.CheckMail(email);

                foreach (var member in members)
                {
                    _memberService.Update(new Entities.Concrete.Member()
                    {
                        ID = member.ID,
                        TC_NO = member.TC_NO,
                        MEMBER_NAME = member.MEMBER_NAME,
                        MEMBER_SURNAME = member.MEMBER_SURNAME,
                        EMAIL = email,
                        PASSWORD = password
                    });

                    DialogResult option = MessageBox.Show("Şifre başarıyla Güncellendi", "Success", MessageBoxButtons.OK);

                    if (option == DialogResult.OK)
                    {
                        _loginForm.Show();
                        this.Hide();
                    }

                }
            }
            else
            {
                MessageBox.Show("Şifreler aynı değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _memberForgetPasswordForm.Show();
            this.Hide();
        }

        private void MemberChangePasswordForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
