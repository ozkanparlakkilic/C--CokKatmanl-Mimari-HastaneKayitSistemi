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
using HastaneInfo.WebFormsUI.Utilities.HashPassword;

namespace HastaneInfo.WebFormsUI.LoginAndRegister.Member
{
    public partial class MemberRegisterForm : Form
    {
        private LoginForm _loginForm;
        public MemberRegisterForm(LoginForm loginForm)
        {
            InitializeComponent();
            _memberService = InstanceFactory.GetInstance<IMemberService>();
            _loginForm = loginForm;
        }

        private IMemberService _memberService;
        private void btnMemberRegister_Click(object sender, EventArgs e)
        {
            var password = new HashPassword().hashPasswordText(txtMemberPassword);
            try
            {

                _memberService.Add(new Entities.Concrete.Member()
                {
                    TC_NO = txtMemberTcNo.Text,
                    MEMBER_NAME = txtMemberName.Text,
                    MEMBER_SURNAME = txtMemberSurname.Text,
                    USERNAME = txtMemberUsername.Text,
                    EMAIL = txtMemberEmail.Text,
                    PASSWORD = password

                });
                MessageBox.Show(txtMemberName.Text + " " + txtMemberSurname.Text + " eklendi");
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
