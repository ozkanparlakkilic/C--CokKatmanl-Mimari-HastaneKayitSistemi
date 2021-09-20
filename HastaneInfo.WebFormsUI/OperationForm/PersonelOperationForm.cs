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
using HastaneInfo.Business.Concrete;
using HastaneInfo.DataAccess.Concrete.EntityFramework;
using HastaneInfo.WebFormsUI.MemberForms;
using HastaneInfo.WebFormsUI.PersonelForms;
using HastaneInfo.WebFormsUI.Utilities.FormDesignControl;

namespace HastaneInfo.WebFormsUI
{
    public partial class PersonelOperationForm : Form
    {

        public PersonelOperationForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }

        private void btnAddPersonel_Click(object sender, EventArgs e)
        {
            AddPersonelForm addPersonelForm = new AddPersonelForm();
            addPersonelForm.Show();
            this.Hide();
        }

        private void btnDeletePersonel_Click(object sender, EventArgs e)
        {
            DeletePersonelForm deletePersonelForm = new DeletePersonelForm();
            deletePersonelForm.Show();
            this.Hide();
        }
    }
}
