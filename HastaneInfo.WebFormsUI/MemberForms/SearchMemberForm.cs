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
using HastaneInfo.WebFormsUI.Utilities.FormDesignControl;

namespace HastaneInfo.WebFormsUI.MemberForms
{
    public partial class SearchMemberForm : Form
    {
        public SearchMemberForm()
        {
            InitializeComponent();
            _memberService = InstanceFactory.GetInstance<IMemberService>();
            LoadMembers();
        }

        private IMemberService _memberService;

        void LoadMembers()
        {
            dgwMember.DataSource = _memberService.GetAll();
        }
        private void txtSearchMemberTcNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearchMemberTcNo.Text))
            {
                dgwMember.DataSource = _memberService.GetMembersByMemberTcNo(txtSearchMemberTcNo.Text);
            }
            else
            {
                LoadMembers();
            }

        }

        private void SearchMemberForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
