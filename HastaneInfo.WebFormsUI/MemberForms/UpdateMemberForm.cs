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
using HastaneInfo.WebFormsUI.Utilities.ClearBox;
using HastaneInfo.WebFormsUI.Utilities.FormDesignControl;

namespace HastaneInfo.WebFormsUI.MemberForms
{
    public partial class UpdateMemberForm : Form
    {
        public UpdateMemberForm()
        {
            InitializeComponent();
            _memberService = InstanceFactory.GetInstance<IMemberService>();
            LoadMembers();
        }

        private void LoadMembers()
        {
            dgwMember.DataSource = _memberService.GetAll();
        }

        private IMemberService _memberService;

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwMember.CurrentRow != null)
                {

                    _memberService.Update(new Member()
                    {
                        ID = Convert.ToInt32(dgwMember.CurrentRow.Cells[0].Value),
                        TC_NO = txtUpdateMemberTcNo.Text,
                        MEMBER_NAME = txtUpdateMemberName.Text,
                        MEMBER_SURNAME = txtUpdateMemberSurname.Text,
                        USERNAME = txtUpdateMemberUsername.Text,
                        EMAIL = txtUpdateMemberEmail.Text,
                        PASSWORD = txtUpdateMemberPassword.Text
                    });


                    MessageBox.Show(txtUpdateMemberName.Text + " " + txtUpdateMemberSurname.Text + " güncellendi");

                    LoadMembers();

                    ClearInputs clearInputs = new ClearInputs();
                    clearInputs.ClearAllText(this);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwMember.CurrentRow != null)
            {
                txtUpdateMemberTcNo.Text = dgwMember.CurrentRow.Cells[1].Value.ToString();
                txtUpdateMemberName.Text = dgwMember.CurrentRow.Cells[2].Value.ToString();
                txtUpdateMemberSurname.Text = dgwMember.CurrentRow.Cells[3].Value.ToString();
                txtUpdateMemberUsername.Text = dgwMember.CurrentRow.Cells[4].Value.ToString();
                txtUpdateMemberEmail.Text = dgwMember.CurrentRow.Cells[5].Value.ToString();
                txtUpdateMemberPassword.Text = dgwMember.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void txtUpdateMemberTcNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUpdateMemberTcNo.Text))
            {
                dgwMember.DataSource = _memberService.GetMembersByMemberTcNo(txtUpdateMemberTcNo.Text);
            }
            else
            {
                LoadMembers();
            }
        }

        private void UpdateMemberForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
