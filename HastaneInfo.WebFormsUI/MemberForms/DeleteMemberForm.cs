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
    public partial class DeleteMemberForm : Form
    {
        public DeleteMemberForm()
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
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgwMember.CurrentRow != null)
            {
                try
                {
                    _memberService.Delete(new Member()
                    {
                        ID = Convert.ToInt32(dgwMember.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Silme işlemi başarılı.");
                    LoadMembers();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                ClearInputs clearInputs = new ClearInputs();
                clearInputs.ClearAllText(this);
            }
        }

        private void DeleteMemberForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }

        private void txtDeleteMemberTcNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDeleteMemberTcNo.Text))
            {
                dgwMember.DataSource = _memberService.GetMembersByMemberTcNo(txtDeleteMemberTcNo.Text);
            }
            else
            {
                LoadMembers();
            }
        }
    }
}
