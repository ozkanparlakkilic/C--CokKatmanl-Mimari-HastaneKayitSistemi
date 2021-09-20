using System;
using System.Windows.Forms;
using HastaneInfo.Business.Abstract;
using HastaneInfo.Business.DependencyResolvers.Ninject;
using HastaneInfo.WebFormsUI.Utilities.HashPassword;

namespace HastaneInfo.WebFormsUI.LoginAndRegister.Personel
{
    public partial class RegisterForm : Form
    {
        private LoginForm _loginForm;
        public RegisterForm(LoginForm loginForm)
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            _loginForm = loginForm;
        }
        private IPersonelService _personelService;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var password = new HashPassword().hashPasswordText(txtPersonelPassword);
            try
            {
                if (rbPersonelMan.Checked)
                {
                    _personelService.Add(new Entities.Concrete.Personel()
                    {
                        TC_NO = txtPersonelTcNo.Text,
                        NAME = txtPersonelName.Text,
                        SURNAME = txtPersonelSurname.Text,
                        EMAIL = txtPersonelEmail.Text,
                        PASSWORD = password,
                        YEAR_OF_BIRTH = dtpAddPersonel.Text,
                        NATIONALITY = cmbPersonelNationality.Text,
                        GENDER = rbPersonelMan.Text

                    });
                }
                else
                {
                    _personelService.Add(new Entities.Concrete.Personel()
                    {
                        TC_NO = txtPersonelTcNo.Text,
                        NAME = txtPersonelName.Text,
                        SURNAME = txtPersonelSurname.Text,
                        EMAIL = txtPersonelEmail.Text,
                        PASSWORD = password,
                        YEAR_OF_BIRTH = dtpAddPersonel.Text,
                        NATIONALITY = cmbPersonelNationality.Text,
                        GENDER = rbPersonelWoman.Text

                    });
                }

                MessageBox.Show(txtPersonelName.Text + " " + txtPersonelSurname.Text + " eklendi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            //ClearInputs clearInputs = new ClearInputs();
            //clearInputs.ClearAllText(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Hide();
        }
    }
}
