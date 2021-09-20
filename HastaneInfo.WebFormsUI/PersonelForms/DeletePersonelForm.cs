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
    public partial class DeletePersonelForm : Form
    {
        public DeletePersonelForm()
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            LoadPersonels();
        }

        private void LoadPersonels()
        {
            dgwRemovePersonel.DataSource = _personelService.GetAll();
        }

        private IPersonelService _personelService;
        private void btnRemovePersonel_Click(object sender, EventArgs e)
        {
            if (dgwRemovePersonel.CurrentRow != null)
            {
                try
                {
                    _personelService.Delete(new Personel()
                    {
                        ID = Convert.ToInt32(dgwRemovePersonel.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Silme işlemi başarılı.");
                    LoadPersonels();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                ClearInputs clearInputs = new ClearInputs();
                clearInputs.ClearAllText(this);
            }

        }

        private void DeletePersonelForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }

        private void txtRemovePersonelTcNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtRemovePersonelTcNo.Text))
            {
                dgwRemovePersonel.DataSource = _personelService.GetPersonelsByPersonelTcNo(txtRemovePersonelTcNo.Text);
            }
            else
            {
                LoadPersonels();
            }
        }
    }
}
