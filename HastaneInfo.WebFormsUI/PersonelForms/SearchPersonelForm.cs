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
using HastaneInfo.WebFormsUI.Utilities.FormDesignControl;

namespace HastaneInfo.WebFormsUI.PersonelForms
{
    public partial class SearchPersonelForm : Form
    {

        public SearchPersonelForm()
        {
            InitializeComponent();
            _personelService = InstanceFactory.GetInstance<IPersonelService>();
            LoadPersonels();
        }

        private void LoadPersonels()
        {
            dgwSearchPersonel.DataSource = _personelService.GetAll();
        }

        private IPersonelService _personelService;
        private void txtSearchPersonelTcNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearchPersonelTcNo.Text))
            {
                dgwSearchPersonel.DataSource = _personelService.GetPersonelsByPersonelTcNo(txtSearchPersonelTcNo.Text);
            }
            else
            {
                LoadPersonels();
            }

        }

        private void SearchPersonelForm_Load(object sender, EventArgs e)
        {
            FormDesignControl formDesignControl = new FormDesignControl();
            formDesignControl.FormDesignSetControls(Controls, this);
        }
    }
}
