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
using HastaneInfo.Business.DependencyResolvers.Ninject;
using HastaneInfo.DataAccess.Concrete.EntityFramework;
using HastaneInfo.Entities.Concrete;
using HastaneInfo.WebFormsUI.Utilities.ClearBox;
using HastaneInfo.WebFormsUI.Utilities.FormDesignControl;
using HastaneInfo.WebFormsUI.Utilities.HashPassword;

namespace HastaneInfo.WebFormsUI.PersonelForms
{
    public partial class AddPersonelForm : Form
    {
        public AddPersonelForm()
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
        }

        private IPersonelService _personelService;
        private void btnAddPersonel_Click(object sender, EventArgs e)
        {
            var password = new HashPassword().hashPasswordText(txtPersonelPassword);
            try
            {
                if (rbPersonelMan.Checked)
                {
                    _personelService.Add(new Personel()
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
                    _personelService.Add(new Personel()
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

        private void AddPersonelForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
