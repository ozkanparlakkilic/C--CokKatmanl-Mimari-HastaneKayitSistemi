﻿using System;
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
using HastaneInfo.WebFormsUI.Utilities.HashPassword;

namespace HastaneInfo.WebFormsUI.MemberForms
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
            _memberService = InstanceFactory.GetInstance<IMemberService>();

        }

        private IMemberService _memberService;
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            var password = new HashPassword().hashPasswordText(txtMemberPassword);


            _memberService.Add(new Member()
            {
                TC_NO = txtMemberTcNo.Text,
                MEMBER_NAME = txtMemberName.Text,
                MEMBER_SURNAME = txtMemberSurname.Text,
                USERNAME = txtMemberUsername.Text,
                EMAIL = txtMemberEmail.Text,
                PASSWORD = password
            });

            MessageBox.Show(txtMemberName.Text + " " + txtMemberSurname.Text + " eklendi");


            ClearInputs clearInputs = new ClearInputs();
            clearInputs.ClearAllText(this);
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
