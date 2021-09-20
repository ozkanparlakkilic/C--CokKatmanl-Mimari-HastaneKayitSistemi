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

namespace HastaneInfo.WebFormsUI.PersonelForms
{
    public partial class UpdatePersonelForm : Form
    {
        public UpdatePersonelForm()
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            LoadPersonels();
        }

        private void LoadPersonels()
        {
            dgwUpdatePersonel.DataSource = _personelService.GetAll();
        }

        private IPersonelService _personelService;
        private void btnUpdatePersonel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwUpdatePersonel.CurrentRow != null)
                {
                    if (rbUpdatePersonelMan.Checked)
                    {

                        _personelService.Update(new Personel()
                        {
                            ID = Convert.ToInt32(dgwUpdatePersonel.CurrentRow.Cells[0].Value),
                            TC_NO = txtUpdatePersonelTcNo.Text,
                            NAME = txtUpdatePersonelName.Text,
                            SURNAME = txtUpdatePersonelSurname.Text,
                            EMAIL = txtUpdatePersonelEmail.Text,
                            PASSWORD = txtPersonelUpdatePassword.Text,
                            YEAR_OF_BIRTH = dtpUpdatePersonel.Text,
                            NATIONALITY = cmbUpdatePersonelNationality.Text,
                            GENDER = rbUpdatePersonelMan.Text
                        });
                    }
                    else
                    {
                        _personelService.Update(new Personel()
                        {
                            ID = Convert.ToInt32(dgwUpdatePersonel.CurrentRow.Cells[0].Value),
                            TC_NO = txtUpdatePersonelTcNo.Text,
                            NAME = txtUpdatePersonelName.Text,
                            SURNAME = txtUpdatePersonelSurname.Text,
                            EMAIL = txtUpdatePersonelEmail.Text,
                            PASSWORD = txtPersonelUpdatePassword.Text,
                            YEAR_OF_BIRTH = dtpUpdatePersonel.Text,
                            NATIONALITY = cmbUpdatePersonelNationality.Text,
                            GENDER = rbUpdatePersonelWoman.Text

                        });
                    }

                    MessageBox.Show(txtUpdatePersonelName.Text + " " + txtUpdatePersonelSurname.Text + " güncellendi");

                    LoadPersonels();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void dgwUpdatePersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwUpdatePersonel.CurrentRow != null)
            {
                txtUpdatePersonelTcNo.Text = dgwUpdatePersonel.CurrentRow.Cells[1].Value.ToString();
                txtUpdatePersonelName.Text = dgwUpdatePersonel.CurrentRow.Cells[2].Value.ToString();
                txtUpdatePersonelSurname.Text = dgwUpdatePersonel.CurrentRow.Cells[3].Value.ToString();
                txtUpdatePersonelEmail.Text = dgwUpdatePersonel.CurrentRow.Cells[4].Value.ToString();
                txtPersonelUpdatePassword.Text = dgwUpdatePersonel.CurrentRow.Cells[5].Value.ToString();
                dtpUpdatePersonel.Text = dgwUpdatePersonel.CurrentRow.Cells[6].Value.ToString();
                cmbUpdatePersonelNationality.Text = dgwUpdatePersonel.CurrentRow.Cells[7].Value.ToString();
                if (rbUpdatePersonelMan.Text == dgwUpdatePersonel.CurrentRow.Cells[8].Value.ToString())
                {
                    rbUpdatePersonelMan.Checked = true;
                }
                else
                {
                    rbUpdatePersonelWoman.Checked = true;
                }
            }

            ClearInputs clearInputs = new ClearInputs();
            clearInputs.ClearAllText(this);
        }

        private void txtUpdatePersonelTcNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUpdatePersonelTcNo.Text))
            {
                dgwUpdatePersonel.DataSource = _personelService.GetPersonelsByPersonelTcNo(txtUpdatePersonelTcNo.Text);
            }
            else
            {
                LoadPersonels();
            }
        }

        private void UpdatePersonelForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
