using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HastaneInfo.Business.Abstract;
using HastaneInfo.WebFormsUI.Utilities.FormDesignControl;
using HastaneInfo.WebFormsUI.Utilities.HashPassword;
using HastaneInfo.WebFormsUI.Utilities.PasswordsEqualCheck;

namespace HastaneInfo.WebFormsUI.LoginAndRegister
{
    public partial class ChangePasswordForm : Form
    {
        private ForgetPasswordForm _forgetPasswordForm;
        private LoginForm _loginForm;
        private bool check;
        public ChangePasswordForm(IPersonelService personelService, ForgetPasswordForm forgetPasswordForm, LoginForm loginForm)
        {
            _personelService = personelService;
            _forgetPasswordForm = forgetPasswordForm;
            _loginForm = loginForm;
            InitializeComponent();
        }

        private IPersonelService _personelService;

        private void btnBack_Click(object sender, EventArgs e)
        {
            _forgetPasswordForm.Show();
            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            check = new PasswordsEqualCheck().CheckPasswordsToEqual(txtNewPassword.Text, txtNewPasswordAgain.Text);

            if (check)
            {
                var password = new HashPassword().hashPasswordText(txtNewPassword);
                var email = ForgetPasswordForm.email;

                List<Entities.Concrete.Personel> personel = _personelService.CheckMail(email);

                foreach (var updatedPersonel in personel)
                {
                    _personelService.Update(new Entities.Concrete.Personel()
                    {
                        ID = updatedPersonel.ID,
                        TC_NO = updatedPersonel.TC_NO,
                        NAME = updatedPersonel.NAME,
                        SURNAME = updatedPersonel.SURNAME,
                        EMAIL = email,
                        PASSWORD = password,
                        YEAR_OF_BIRTH = updatedPersonel.YEAR_OF_BIRTH,
                        NATIONALITY = updatedPersonel.NATIONALITY,
                        GENDER = updatedPersonel.GENDER,
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

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
