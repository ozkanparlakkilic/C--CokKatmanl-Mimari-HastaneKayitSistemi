using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using HastaneInfo.WebFormsUI.MemberForms;
using HastaneInfo.WebFormsUI.PersonelForms;

namespace HastaneInfo.WebFormsUI.OperationForm
{
    public partial class AdminForm : Form
    {
        private IconButton currentButton;
        private Panel leftBorderBtn;
        int count = 0;
        public AdminForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 44);
            panelSideMenu.Controls.Add(leftBorderBtn);
            customizeDesign();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.BlueViolet;
            public static Color color2 = Color.Aqua;
            //public static Color color3 = Color.Lime;
            //public static Color color4 = Color.Yellow;
            //public static Color color5 = Color.Red;
        };

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                try
                {
                    DisableButton();

                    currentButton = (IconButton)senderBtn;
                    currentButton.ForeColor = color;
                    currentButton.TextAlign = ContentAlignment.MiddleLeft;
                    currentButton.IconColor = color;
                    currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                    currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentButton.Location.Y + panelLogo.Height);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.DarkRed;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void customizeDesign()
        {
            panelPersonel.Visible = false;
            panelAuthor.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelPersonel.Visible)
            {
                panelPersonel.Visible = false;
            }
            if (panelAuthor.Visible)
            {
                panelAuthor.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.Show();
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconBtnPersonel_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPersonel);
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconBtnMember_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAuthor);
            ActivateButton(sender, RGBColors.color2);
        }

        private void iconBtnAddPersonel_Click(object sender, EventArgs e)
        {
            openChildForm(new AddPersonelForm());
            HideSubMenu();
        }

        private void iconBtnUpdatePersonel_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdatePersonelForm());
            HideSubMenu();
        }

        private void iconBtnRemovePersonel_Click(object sender, EventArgs e)
        {
            openChildForm(new DeletePersonelForm());
            HideSubMenu();
        }

        private void iconBtnSearchPersonel_Click(object sender, EventArgs e)
        {
            openChildForm(new SearchPersonelForm());
            HideSubMenu();
        }

        private void iconBtnAddMember_Click(object sender, EventArgs e)
        {
            openChildForm(new AddMemberForm());
            HideSubMenu();
        }

        private void iconBtnUpdateMember_Click(object sender, EventArgs e)
        {
            openChildForm(new UpdateMemberForm());
            HideSubMenu();
        }

        private void iconBtnRemoveMember_Click(object sender, EventArgs e)
        {
            openChildForm(new DeleteMemberForm());
            HideSubMenu();
        }

        private void iconBtnSearchMember_Click(object sender, EventArgs e)
        {
            openChildForm(new SearchMemberForm());
            HideSubMenu();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            panelOperation.AutoScroll = false;
            panelOperation.Visible = true;
        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ıconPictureBox2_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                ıconPictureBox2.IconChar = IconChar.WindowRestore;
                ıconPictureBox2.IconSize = 18;
                ıconPictureBox2.IconColor = Color.White;
                count++;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ıconPictureBox2.IconChar = IconChar.Square;
                ıconPictureBox2.IconSize = 18;
                ıconPictureBox2.IconColor = Color.White;
                count--;
            }

        }

        private void ıconPictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
